using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_C_sharp
{
    class ClnProduto
    {

        private int _cd_Produto;
        private string _Codigo, _Tipo, _Nome, _Fabricante, _Genero, _Plataforma, _Preco, _fornecedor;
        private string comando;
        //Cria objeto para acesso a Camada de Dados
        cldBancoDados objBancoDados = new cldBancoDados();

        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Fabricante { get => _Fabricante; set => _Fabricante = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Plataforma { get => _Plataforma; set => _Plataforma = value; }
        public string Preco { get => _Preco; set => _Preco = value; }
        public string Fornecedor { get => _fornecedor; set => _fornecedor = value; }

        public DataTable PesquisarPorTipo(string strDescricao, string tipo)
        {

            comando = "" +
             " Select " +
             " 	tb_Produto.cd_Produto, " +
             " 	tb_TipoProduto.ds_TipoProduto, " +
             " 	tb_Produto.Nome, " +
             " 	tb_Genero.ds_Genero, " +
             " 	tb_FaixaEtaria.ds_FaixaEtaria, " +
             " 	tb_Fornecedor.NomeFantasia " +
             " from tb_Produto " +
             " 	inner join tb_TipoProduto on tb_TipoProduto.Cd_TipoProduto = tb_Produto.cd_TipoProduto and tb_TipoProduto.Ativo = 1 " +
             " 	inner join tb_Genero on tb_Genero.cd_Genero = tb_Produto.cd_Genero and tb_Genero.Ativo = 1 " +
             " 	inner join tb_FaixaEtaria on tb_FaixaEtaria.cd_FaixaEtaria = tb_Produto.cd_FaixaEtaria and tb_FaixaEtaria.Ativo = 1 " +
             "  inner join tb_Fornecedor on tb_Fornecedor.cd_Fornecedor = tb_Produto.cd_fornecedor and tb_Fornecedor.Ativo = 1 " +
             " where " +
             " 	tb_Produto.Ativo = 1 and " +
             " ";

            if (tipo == "tipo")
            {
                comando = comando + " tb_TipoProduto.ds_TipoProduto like '%" + strDescricao + "%' ";
            }
            else if (tipo == "codigo")
            {
                comando = comando + " tb_Produto.cd_Produto = " + strDescricao + " ";
            }
            else if (tipo == "nome")
            {
                comando = comando + " tb_Produto.Nome like '%" + strDescricao + "%' ";
            }
            else if (tipo == "genero")
            {
                comando = comando + " tb_Genero.ds_Genero like '%" + strDescricao + "%' ";
            }
            else if (tipo == "faixaEtaria")
            {
                comando = comando + " tb_FaixaEtaria.ds_FaixaEtaria like '%" + strDescricao + "%' ";
            }
            else if (tipo == "fornecedor")
            {
                comando = comando + " tb_Fornecedor.NomeFantasia like '%" + strDescricao + "%' ";
            }

            comando = comando + " order by tb_Produto.Nome ";

            //Envia a consulta por parâmetro para objeto e aguarda o retorno
            return objBancoDados.RetornaTabela(comando);
        }

        public DataTable LocalizarPorNome(string strDescricao)
        {
            return PesquisarPorTipo(strDescricao, "nome");
        }

        ////Comando SQL PARA iNSERIR
        //public void Gravar()
        //{
        //    comando = "INSERT INTO tb_produto";
        //    comando += ("values(");
        //    comando += ("'" + NomeCadastroDeProduto + "',");
        //    comando += ("'" + TipoCadastroDeProduto + "',");
        //    comando += ("'" + FornecedorCadastroDeProduto + "',");
        //    comando += ("'" + FabricanteCadastroDeProduto + "',");
        //    comando += ("'" + GeneroCadastroDeProduto + "',");
        //    comando += ("'" + PlataformaCadastroDeProduto + "',");
        //    comando += ("'" + PrecoCadastroDeProduto + "',");
        //    comando += ("'" + QuantidadeCadastroDeProduto + "',");
        //    comando += ("'1'");
        //    comando += (")");
        //    objBancoDados.ExecutaComando(comando);
        //}
        ////Comando SQL PARA ALTERAR
        //public void Alterar()
        //{
        //    comando = "UPDATE tb_produto";
        //    comando += ("values(");
        //    comando += ("'" + NomeCadastroDeProduto + "',");
        //    comando += ("'" + TipoCadastroDeProduto + "',");
        //    comando += ("'" + FornecedorCadastroDeProduto + "',");
        //    comando += ("'" + FabricanteCadastroDeProduto + "',");
        //    comando += ("'" + GeneroCadastroDeProduto + "',");
        //    comando += ("'" + PlataformaCadastroDeProduto + "',");
        //    comando += ("'" + PrecoCadastroDeProduto + "',");
        //    comando += ("'" + QuantidadeCadastroDeProduto + "',");
        //    comando += ("'1'");
        //    comando += (")");
        //    objBancoDados.ExecutaComando(comando);
        //}



        public void Gravar()
        {
            if (string.IsNullOrEmpty(Codigo))
            {
                Inserir();
            }
            else
            {
                Atualizar();
            }
        }

        private void Atualizar()
        {
            throw new NotImplementedException();
        }

        internal void Alterar()
        {
            throw new NotImplementedException();
        }

        private void Inserir()
        {
            throw new NotImplementedException();
        }

        internal void ExcluirLogicamente()
        {
            throw new NotImplementedException();
        }

    }
}
