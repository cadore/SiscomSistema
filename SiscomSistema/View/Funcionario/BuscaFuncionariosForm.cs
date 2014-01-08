using SiscomSistema.Util;
using System.Collections.Generic;
using System.Windows.Forms;
using Siscom.Entities;
namespace SiscomSistema.View.Funcionario    
{
    public partial class BuscaFuncionariosForm : DevExpress.XtraEditors.XtraForm
    {
        public BuscaFuncionariosForm()
        {
            InitializeComponent();
            getAll();
        }

        public void getAll()
        {
            //var session = ConnectionHelper.OpenSession();
            //bindingSource.DataSource = (List<Funcionarios>)session.CreateCriteria(typeof(Funcionarios)).SetMaxResults(100).List<Funcionarios>();
        }

        /*void getBy(string value)
        {
            //var session = ConnectionHelper.OpenSession();
            string tipo_documento = cbTipoPesquisa.SelectedItem.ToString();
            if ("NOME".Equals(tipo_documento) && value.Trim().Length > 1)
            {
                bindingSource.DataSource = session.QueryOver<Funcionarios>().WhereRestrictionOn(x => x.nome).IsInsensitiveLike("%" + value + "%").List();
            }
            else if (!"NOME".Equals(tipo_documento) && value.Trim().Length > 0)
            {
                long _id = int.Parse(value);
                bindingSource.DataSource = session.QueryOver<Funcionarios>().Where(x => x.id == _id).List();
            }
        }*/

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
           // getBy(tfValor.Text);
        }

        private void cbTipoPesquisa_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string tipo_documento = cbTipoPesquisa.SelectedItem.ToString();
            if ("NOME".Equals(tipo_documento))
            {
                this.tfValor.Properties.Mask.EditMask = null;
                this.tfValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            }
            else if (!"NOME".Equals(tipo_documento))
            {
                this.tfValor.Properties.Mask.EditMask = "d";
                this.tfValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            }
            
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            FuncionariosForm funcionariosForm = new FuncionariosForm(null, this);
            funcionariosForm.ShowDialog();
        }
        private void gridControl_Click(object sender, MouseEventArgs e)
        {
            Funcionarios f = (Funcionarios)bindingSource.Current;
            FuncionariosForm ff = new FuncionariosForm(f, this);
            ff.ShowDialog(); 
        }
    }
}
