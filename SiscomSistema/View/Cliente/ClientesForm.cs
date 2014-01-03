
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using NHibernate.Criterion;
using NHibernate.Mapping;
using Siscom.Entities;
using SiscomSistema.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SiscomSistema.View
{
    public partial class ClientesForm : DevExpress.XtraEditors.XtraForm
    {
        private BuscaClientesForm bcf;
        private CustomValidationRuleCPF customValidationCPF;
        private CustomValidationRuleCNPJ customValidationCNPJ;
        private CustomValidationRuleIE customValidationIE;
        private string status = "save";
        public ClientesForm(Clientes cliente, BuscaClientesForm _bcf)
        {
            InitializeComponent();
            loadCidades();
            bcf = _bcf;
            if (cliente == null)
            {
                cliente = new Clientes();   
            }
            else
            {                              
                loadBairrosAndEnderecos(cliente.cidade.ToString());
                tfDocumento.Properties.ReadOnly = true;
                status = "update";
                btnInativar.Enabled = true;
            }

            bindingSource.Add(cliente);

            foreach (Control c in panelControl.Controls)
            {
                dxValidationProvider.SetIconAlignment(c, ErrorIconAlignment.MiddleRight);
            }
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if(dxValidationProvider.Validate()){
                var session = ConnectionHelper.OpenSession();
                using (var transaction = session.BeginTransaction())
                {
                    if("save".Equals(status) && uniqDocumento(tfDocumento.Text) > 1){
                        XtraMessageBox.Show(l_documento.Text + " " + tfDocumento.Text+" já esta cadastrado para outro cliente, verifique.");
                        return;
                    }
                    session.SaveOrUpdate(bindingSource.Current);
                    transaction.Commit();
                    bcf.getAll();
                    Dispose();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        }
        public class CustomValidationRuleCPF : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                String str = value as String;
                if (str != null)
                {
                    return Validations.validCPF(str);
                }
                else
                {
                    return false;
                }
            }
        }
        public class CustomValidationRuleCNPJ : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                String str = value as String;
                if (str != null)
                {
                    return Validations.validCNPJ(str);
                }
                else
                {
                    return false;
                }
            }
        }

        public class CustomValidationRuleIE : ValidationRule, IDisposable
        {
            ClientesForm form;
            public void Dispose()
            {
                if (form != null)
                {
                    form.Dispose();
                    form = null;
                }
            }
            public CustomValidationRuleIE(ClientesForm _form) 
            {
                form = _form;
            }
            public override bool Validate(Control control, object value)
            {
                String str = value as String;
                String estado = form.tfEstado.Text;

                if (estado == null || estado.Equals(string.Empty)) 
                {
                    return false;
                }

                if (str != null)
                {
                    return Validations.validIE(str, estado);
                }
                else
                {
                    return false;
                }
            }
        }

        public class CustomValidationRuleUniqDocumento : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                if (uniqDocumento(value.ToString()) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cbTipoDocumento.SelectedItem.ToString();
            if("CPF".Equals(value)){
                this.tfDocumento.Properties.Mask.EditMask = "000.000.000-00";
                customValidationCPF = null;
                customValidationCPF = new CustomValidationRuleCPF();
                customValidationCPF.ErrorText = "Preencha com um CPF válido";
                customValidationCPF.ErrorType = ErrorType.Critical;
                dxValidationProvider.SetValidationRule(tfDocumento, customValidationCPF);

                customValidationIE = null;
                dxValidationProvider.SetValidationRule(tfIE, customValidationIE);
                ckIsento.Enabled = false;
                ckIsento.Checked = false;

                l_documento.Text = "CPF:";
                l_ie.Text = "RG:";                                
            }
            else if ("CNPJ".Equals(value))
            {
                this.tfDocumento.Properties.Mask.EditMask = "00.000.000/0000-00";
                customValidationCNPJ = null;
                customValidationCNPJ = new CustomValidationRuleCNPJ();
                customValidationCNPJ.ErrorText = "Preencha com um CNPJ válido";
                customValidationCNPJ.ErrorType = ErrorType.Critical;
                dxValidationProvider.SetValidationRule(tfDocumento, customValidationCNPJ);

                customValidationIE = null;
                dxValidationProvider.SetValidationRule(tfIE, customValidationIE);
                customValidationIE = new CustomValidationRuleIE(this);
                customValidationIE.ErrorText = "Preencha uma Incrição Estadual Válida";
                customValidationIE.ErrorType = ErrorType.Critical;
                dxValidationProvider.SetValidationRule(tfIE, customValidationIE);

                ckIsento.Enabled = true;

                l_documento.Text = "CNPJ:";
                l_ie.Text = "I.E.:";
            }
            else
            {
                return;
            }
        }

        private void ckIsento_CheckedChanged(object sender, EventArgs e)
        {
            if(ckIsento.Checked){
                customValidationIE = null;
                dxValidationProvider.SetValidationRule(tfIE, customValidationIE);
                tfIE.Text = null;
                tfIE.Properties.ReadOnly = true;
            }
            else
            {
                customValidationIE = null;
                dxValidationProvider.SetValidationRule(tfIE, customValidationIE);
                tfIE.Text = null;
                tfIE.Properties.ReadOnly = false;

                customValidationIE = new CustomValidationRuleIE(this);
                customValidationIE.ErrorText = "Preencha uma Incrição Estadual Válida";
                customValidationIE.ErrorType = ErrorType.Critical;
                dxValidationProvider.SetValidationRule(tfIE, customValidationIE);
            }
        }

        private void loadCidades()
        {
            try
            {
                List<Cidades> lista_cidades = new List<Cidades>();                
                ComboBoxItemCollection col = this.cbCidade.Properties.Items;

                col.BeginUpdate();
                col.Clear();
                var session = ConnectionHelper.OpenSession();
                lista_cidades = (List<Cidades>)session.CreateCriteria(typeof(Cidades)).AddOrder(Order.Asc("cidade")).List<Cidades>();
                foreach (Cidades c in lista_cidades)
                {
                    col.Add(c);
                }
                col.EndUpdate();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void loadBairrosAndEnderecos(string name_cidade)
        {
            try
            {
            var session = ConnectionHelper.OpenSession();
            Cidades c = session.QueryOver<Cidades>().Where(x => x.cidade == name_cidade).SingleOrDefault();
            tfEstado.Text = c.uf; 
            ComboBoxItemCollection cb_bairro = this.cbBairro.Properties.Items;
            ComboBoxItemCollection cb_endereco = this.cbEndereco.Properties.Items;
            IList<Bairros> lista_bairros = c.bairros;
            IList<Enderecos> lista_enderecos = c.enderecos;

            cb_bairro.BeginUpdate();
            cb_bairro.Clear();

            cb_endereco.BeginUpdate();
            cb_endereco.Clear();
            foreach (Bairros b in lista_bairros)
                {
                    cb_bairro.Add(b);
                }
                cb_bairro.EndUpdate();

            foreach (Enderecos e in lista_enderecos)
                {
                    cb_endereco.Add(e);
                }
                cb_endereco.EndUpdate();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void loadCep()
        {
            if (cbEndereco.SelectedItem != null)
            {
                string endereco_ = cbEndereco.SelectedItem.ToString();
                var session = ConnectionHelper.OpenSession();
                Enderecos c = session.QueryOver<Enderecos>().Where(x=>x.endereco == endereco_).SingleOrDefault();
                tfCep.Text = c.cep;
            }
        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCidade.SelectedIndex > -1){
                loadBairrosAndEnderecos(cbCidade.SelectedItem.ToString());
            }

        }

        private void cbEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {            
            loadCep();
        }

        private static int uniqDocumento(string value)
        {
            var session = ConnectionHelper.OpenSession();
            return session.QueryOver<Clientes>().Where(x => x.documento == value).RowCount();
        }

        private int uniqRG(string value)
        {
            var session = ConnectionHelper.OpenSession();
            return session.QueryOver<Clientes>().Where(x => x.ie == value).RowCount();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConnectionHelper.CloseSession();
            this.Dispose();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
        }
    }
}