using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using ServicoDeOperacaoClienteUsuarios;
using Siscom.Entities;
using SiscomSistema.Util;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;
namespace SiscomSistema.View
{
    public partial class ClientesForm : DevExpress.XtraEditors.XtraForm
    {
        private CustomValidationRuleCPF customValidationCPF;
        private CustomValidationRuleCNPJ customValidationCNPJ;
        private CustomValidationRuleIE customValidationIE;
        private IService vService;
        Clientes _c = null;
        public ClientesForm(Clientes cliente)
        {
            InitializeComponent();
            btnSalvar.DialogResult = DialogResult.OK;
            vService = ConnectionHelper.iniciaConexao();
            loadCidades();
            if (cliente == null)
            {
                cliente = new Clientes();
                cbBairro.Enabled = false;
                cbEndereco.Enabled = false;
            }
            else
            {                
                cbCidade.EditValue = cliente.id_cidades;
                loadBairrosAndEnderecos(Convert.ToInt64(cbCidade.EditValue));
                tfDocumento.Properties.ReadOnly = true;
                btnInativar.Enabled = true;
                cbBairro.EditValue = cliente.id_bairros;
                cbEndereco.EditValue = cliente.id_enderecos;
            }
            _c = cliente;
            bindingSource.Add(cliente);

            foreach (Control c in panelControl.Controls)
            {
                dxValidationProvider.SetIconAlignment(c, ErrorIconAlignment.MiddleRight);
            }
        }       

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if(dxValidationProvider.Validate()){
                if(Utils.textFieldIsEmpty(tfDocumento) == false && uniqDocumento(tfDocumento.Text) >= 1){
                    XtraMessageBox.Show(String.Format("{0} {1} já esta cadastrado para outro cliente, verifique.", l_documento.Text, tfDocumento.Text));
                     return;
                }
                Clientes c = (Clientes) bindingSource.Current;
                c.id_cidades = Convert.ToInt64(cbCidade.EditValue);
                //transaction.Commit();                
                Dispose();
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

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cbTipoDocumento.SelectedItem.ToString();
            if("CPF".Equals(value)){
                this.tfDocumento.Properties.Mask.EditMask = "000.000.000-00";
                customValidationCPF = null;
                customValidationCPF = new CustomValidationRuleCPF() { ErrorText = "Preencha com um CPF válido", ErrorType = ErrorType.Critical };
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
                customValidationCNPJ = new CustomValidationRuleCNPJ() { ErrorText = "Preencha com um CNPJ válido", ErrorType = ErrorType.Critical };
                dxValidationProvider.SetValidationRule(tfDocumento, customValidationCNPJ);

                customValidationIE = null;
                dxValidationProvider.SetValidationRule(tfIE, customValidationIE);
                customValidationIE = new CustomValidationRuleIE(this) { ErrorText = "Preencha uma Incrição Estadual Válida", ErrorType = ErrorType.Critical };
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

                customValidationIE = new CustomValidationRuleIE(this) { ErrorText = "Preencha uma Incrição Estadual Válida", ErrorType = ErrorType.Critical };
                dxValidationProvider.SetValidationRule(tfIE, customValidationIE);
            }
        }

        private void loadCidades()
        {
            try
            {
                List<Cidades> lista_cidades = vService.recuperarTodasAsCidades();
                bindingSourceCidade.DataSource = lista_cidades;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void loadBairrosAndEnderecos(long id_cidade)
        {
            try
            {
            Cidades cidade = vService.recuperarCidadePorId(id_cidade);
            tfEstado.Text = cidade.uf;

            List<Bairros> lista_bairros = vService.recuperarBairroPorIdCidade(id_cidade);            
            bindingSourceBairros.DataSource = lista_bairros;

            List<Enderecos> lista_enderecos = vService.recuperaEnderecosPorIdCidade(id_cidade);
            bindingSourceEnderecos.DataSource = lista_enderecos;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void loadCep()
        {
            string _endereco = cbEndereco.Text;
            if (_endereco != null)
            {
                Enderecos c = vService.recuperaEnderecoPorNome(_endereco);
                //tfCep.Text = c.cep;
            }
        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            long a = Convert.ToInt64(cbCidade.EditValue);
            loadBairrosAndEnderecos(a);
            cbBairro.Enabled = true;
            cbEndereco.Enabled = true;
        }

        private void cbEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {            
            loadCep();
        }

        private int uniqDocumento(string value)
        {
           return vService.countClassClientes(value, "documento");
        }

        private int uniqRG(string value)
        {
            return vService.countClassClientes(value, "ie");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            cbBairro.EditValue = _c.id_bairros;
            cbEndereco.EditValue = _c.id_enderecos;
        }
    }
}