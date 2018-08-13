using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //para uso do DataTable (tabela de Dados)
using System.Data.SqlClient; // Para uso do DataReader (Dados para Leitura)

namespace Agenda_C_sharp
{
    class ClnAgenda
    {
        //Comando de SQL que serão enviados
        string comando;

        //Cria objeto para acesso a Camada de Dados
        cldBancoDados objBancoDados = new cldBancoDados();

        private string _cod, _nome, _tel, _cep, _endereco, _UF, _nr, _bairro, _cidade;

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public string Nr1
        {
            get { return _nr; }
            set { _nr = value; }
        }

        public string Nr
        {
            get { return _nr; }
            set { _nr = value; }
        }

        public string UF
        {
            get { return _UF; }
            set { _UF = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cod
        {
            get { return _cod; }
            set { _cod = value; }
        }

       



        //public string Cod { get => _cod; set => _cod = value.ToUpper(); }
        //public string Nome { get => _nome; set => _nome = value.ToUpper(); }
        //public string Tel { get => _tel; set => _tel = value.ToUpper(); }
        //public string Cep { get => _cep; set => _cep = value.ToUpper(); }
        //public string Endereco { get => _endereco; set => _endereco = value.ToUpper(); }
        //public string UF { get => _UF; set => _UF = value.ToUpper(); }
        //public string Nr { get => _nr; set => _nr = value.ToUpper(); }
        //public string Bairro { get => _bairro; set => _bairro = value.ToUpper(); }
        //public string Cidade { get => _cidade; set => _cidade = value.ToUpper(); }


        public DataTable LocalizarPorNome(string strDescricao)
        {
            //Recebe a decrição/ nome para consultar. 
            //comando SQL pesquisando por qualquer parte do nome e somente o ativo
            //comando = "Select novo,consultar,alterar,excluir from t_dadosAgenda where nome like '%" +
            //strDescricao + "%'and Ativo='1' order by cod";

            comando = "Select tipo,nome,genero,faixaEtaria from BuscaProduto where nome like '%" +
            strDescricao + "%'and Ativo='1' order by cod";
            
            //comando = "Select*from T_DadosAgenda";

            //Envia a consulta por parâmetro para objeto e aguarda o retorno
            return objBancoDados.RetornaTabela(comando);

        }
        public void ExcluirLogicamente()
        //alterar o códogo ativo=0 para não apresentar o dado
        {
            comando = ("UPDATE BuscaProduto");
            comando += ("SET");
            comando += ("ATIVO = '" + 0 + "'");
            comando += ("WHERE");
            comando += ("cod = '" + _cod + "'");
            objBancoDados.ExecutaComando(comando);
        }
        //Na Classe clnAgenda
        public SqlDataReader localizarCodigo(string cod)
        {
            comando = "select * from BuscaProduto where cod='" + cod + "'";
            return objBancoDados.RetornaLinha(comando);



        }
    }
}

