using DevExpress.XtraEditors;
using Siscom.Entities;
using SiscomSistema.Util;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SiscomSistema.View
{
    public partial class BuscaClientesForm : Form
    {
        public BuscaClientesForm()
        {
            InitializeComponent();
            getAll();
        }

        public void getAll()
        {
            var session = ConnectionHelper.OpenSession();
            bindingSource.DataSource = (List<Clientes>) session.CreateCriteria(typeof(Clientes)).SetMaxResults(100).List<Clientes>();
        }

        void getBy(string value)
        {
            var session = ConnectionHelper.OpenSession();
            string tipo_documento = cbTipoDocumento.SelectedItem.ToString();
            if ("NOME".Equals(tipo_documento) && value.Trim().Length > 1)
            {
                bindingSource.DataSource = session.QueryOver<Clientes>().WhereRestrictionOn(x => x.nome).IsInsensitiveLike("%"+value+"%").List();
            }
            else if (!"NOME".Equals(tipo_documento) && value.Trim().Length > 5)
            {
                bindingSource.DataSource = session.QueryOver<Clientes>().Where(x => x.documento == value).List();
            }
        }

        private void gridControl_Click(object sender, System.EventArgs e)
        {
            Clientes c = (Clientes) bindingSource.Current;
            ClientesForm cf = new ClientesForm(c, this);
            cf.ShowDialog();            
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            ClientesForm cf = new ClientesForm(null, this);            
            cf.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            getBy(tfDocumento.Text);
        }

        private void cb_Tipo_Documento_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string tipo_documento = cbTipoDocumento.SelectedItem.ToString();
            if ("NOME".Equals(tipo_documento))
            {
                this.tfDocumento.Text = null;
                this.tfDocumento.Properties.Mask.EditMask = "";
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
            ConnectionHelper.CloseSession();
            this.Dispose();
        }
    }
}
