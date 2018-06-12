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
        private string _Codigo,_Tipo,_Nome,_Fabricante,_Genero,_Plataforma,_Preco,_fornecedor;
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

        public DataTable PesquisarPorTipo(string strDescricao)
        {
            return null;
        }

        public DataTable LocalizarPorNome(string strDescricao)
        {
            comando = "Select tipo, nome, genero, faixa_Etaria from tb_Produto where tipo like '%" +
            strDescricao + "%' and Ativo='1' order by cd_produto";

            //comando = "Select*from T_DadosAgenda";

            //Envia a consulta por parâmetro para objeto e aguarda o retorno
            return objBancoDados.RetornaTabela(comando);

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





        }

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
