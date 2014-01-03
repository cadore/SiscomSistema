
using Siscom.Entities;
using SiscomSistema.Util;
using System;
using System.Windows.Forms;

namespace SiscomSistema.View
{
    public partial class ClienteForm : DevExpress.XtraEditors.XtraForm
    {
        Cliente cliente;

        public ClienteForm(Cliente cliente)
        {
            InitializeComponent();

            if (cliente == null)
            {
                cliente = new Cliente();
            }

            bindingSource.Add(cliente);

            foreach (Control c in panelControl.Controls)
            {
                dxValidationProvider.SetIconAlignment(c, ErrorIconAlignment.MiddleRight);
            }

            
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            if(dxValidationProvider.Validate()){
                var session = ConnectionHelper.OpenSession();
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(bindingSource.Current);
                    transaction.Commit();                    
                }
            }
        }
    }
}