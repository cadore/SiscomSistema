using DevExpress.XtraEditors;
using ServicoDeOperacaoClienteUsuarios;
using Siscom.Entities;
using SiscomSistema.Util;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Windows.Forms;

namespace SiscomSistema.View
{
    public partial class BuscaClientesForm : Form
    {

        private IService vService;
        public BuscaClientesForm()
        {
            vService = ConnectionHelper.iniciaConexao();
            InitializeComponent();            
            getAll();
        }
        public void getAll()
        {
            try
            {
                bindingSource.DataSource = (List<Clientes>) vService.retornaTodosCliFor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        void getBy(string value)
        {
            string tipo_documento = cbTipoDocumento.SelectedItem.ToString();
            if ("NOME".Equals(tipo_documento) && value.Trim().Length > 1)
            {
                bindingSource.DataSource = (List<Clientes>)vService.retornaCliForPorNome(value);
            }
            else if (!"NOME".Equals(tipo_documento) && value.Trim().Length > 5)
            {
                bindingSource.DataSource = (List<Clientes>)vService.retornaCliForPorDocumento(value);
            }
        }

        private void gridControl_Click(object sender, System.EventArgs e)
        {
            showClientesForm((Clientes) bindingSource.Current);
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            showClientesForm(null);
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            getBy(tfDocumento.Text);
        }

        private DialogResult showClientesForm(Clientes c)
        {
            ClientesForm cf = new ClientesForm(c);
            DialogResult rs = cf.ShowDialog();
            if (rs == DialogResult.OK)
            {
                this.getAll();
            }
            return rs;
        }

        private void cb_Tipo_Documento_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string tipo_documento = cbTipoDocumento.SelectedItem.ToString();
            if ("NOME".Equals(tipo_documento))
            {
                this.tfDocumento.Text = null;
                this.tfDocumento.Properties.Mask.EditMask = null;
                this.tfDocumento.Select();
            }else if ("CNPJ".Equals(tipo_documento))
            {
                this.tfDocumento.Text = null;
                this.tfDocumento.Properties.Mask.EditMask = "00.000.000/0000-00";
                this.tfDocumento.Select();
            } else if ("CPF".Equals(tipo_documento))
            {
                this.tfDocumento.Text = null;
                this.tfDocumento.Properties.Mask.EditMask = "000.000.000-00";                
                this.tfDocumento.Select();
            }
        }

        private void tfDocumento_FocusEnter(object sender, System.EventArgs e)
        {
            tfDocumento.SelectAll();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}
