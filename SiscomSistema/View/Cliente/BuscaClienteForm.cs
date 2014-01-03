using Siscom.Entities;
using SiscomSistema.Util;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SiscomSistema.View
{
    public partial class BuscaClienteForm : Form
    {
        public BuscaClienteForm()
        {
            InitializeComponent();

            preencher_tabela();
        }

        void preencher_tabela()
        {
            var session = ConnectionHelper.OpenSession();

            bindingSource.DataSource = (List<Cliente>)session.CreateCriteria(typeof(Cliente)).List<Cliente>();
        }
    }
}
