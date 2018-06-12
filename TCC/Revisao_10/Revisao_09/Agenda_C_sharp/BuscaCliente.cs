using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agenda_C_sharp
{
    public partial class BuscaCliente : Form
       

    {
        ClnCliente ObjCliente = new ClnCliente();
        ClnUtil ObjUtil = new ClnUtil();
        
        private object buscaCliente;

      
        public BuscaCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisarBuscaCliente_Click(object sender, EventArgs e)
        {
            CadastroFornecedor objcadastroCliente = new CadastroFornecedor();
            objcadastroCliente.ShowDialog();

        }

        private void btnNovoBuscaCliente_Click(object sender, EventArgs e)
        {
          

        }

        private void btnAlterarBuscaCliente_Click(object sender, EventArgs e)
        {
        }

        private void btnExcluirBuscaCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
   
      // ClnAgenda objAgenda = new ClnAgenda();
      //ClnUtil objClnUtil = new ClnUtil();

//        public frmPrincipal()
//        {
//            InitializeComponent();
//        }
//         private void btnNovo_Click(object sender, EventArgs e)
//        {
//            //Cria objeto do outro frmulário
//            frmCompleto ObjCadastroAgenda = new frmCompleto();

//            //Alterar as propriedades do outro form:
//            ObjCadastroAgenda.Text = ">>>Novo cadastro<<<";
//            ObjCadastroAgenda.txtCod.Enabled = false;

//            //Apresenta o formulário
//            ObjCadastroAgenda.ShowDialog();
//            //No fechamento do frmCompleto:preencher a grid
//            CarregaDataGrid();