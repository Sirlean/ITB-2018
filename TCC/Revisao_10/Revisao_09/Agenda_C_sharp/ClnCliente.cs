using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Agenda_C_sharp
{
    class ClnCliente
    {
        private int _cd_Cliente;
        private string _Nome, _Cpf, _Rg, _Genero, _Endereco, _Numero, _Cidade, _Cep, _Estado, _UF, _Email, _telefone, _Celular, _codigo;
        private string comando;

        public string Nome { get => _Nome; set => _Nome = value; }
        public string Cpf { get => _Cpf; set => _Cpf = value; }
        public string Rg { get => _Rg; set => _Rg = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Endereco { get => _Endereco; set => _Endereco = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
        public string Cidade { get => _Cidade; set => _Cidade = value; }
        public string Cep { get => _Cep; set => _Cep = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string UF { get => _UF; set => _UF = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _Celular; set => _Celular = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }

        public SqlDataReader localizarnome(string nome)
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = " select * from Tb_cliente ";
            comando += " where cd_cliente = " + nome;


            return objBancoDados.RetornaLinha(comando);
        }

        public DataTable LocalizarPorCampo(string strValorCampo, string strNomeCampo)
        {
            cldBancoDados objBancoDados = new cldBancoDados();

            comando = "select cd_cliente, Nome,Cpf, Rg,Genero, Endereco, Numero,Complemento, Cidade, Cep, Estado, UF, Email, telefone, Celular from Tb_fornecedor  where " + strNomeCampo + " like '%" +
            strValorCampo + "%' and Ativo= 1 order by cd_cliente";

            return objBancoDados.RetornaTabela(comando);

        }

        public void ExcluirLogicamente()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = (" UPDATE tb_Cliente ");
            comando += (" SET ");
            comando += (" ATIVO = '" + 0 + "' ");
            comando += (" WHERE ");
            comando += (" cd_Cliente = '" + Codigo + "' ");

            objBancoDados.ExecutaComando(comando);
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

        private void Inserir()
        {
            throw new NotImplementedException();
        }
    }


}
