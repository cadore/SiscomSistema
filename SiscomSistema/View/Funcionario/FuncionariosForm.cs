using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using SecureApp;
using Siscom.Entities;
using SiscomSistema.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiscomSistema.View.Funcionario
{ 
    public partial class FuncionariosForm : DevExpress.XtraEditors.XtraForm
    {
        private BuscaFuncionariosForm bff;
        private CustomValidationRuleTamanhoSenha cVRTS;
        private CustomValidationRuleSenhaAtual cVRSA;
        private Funcionarios funcionario;
        private string status = "save";
        public FuncionariosForm(Funcionarios _funcionario, BuscaFuncionariosForm _bff)
        {
            InitializeComponent();
            if(_funcionario == null){
                _funcionario = new Funcionarios();
            }
            else
            {
                status = "update";
                tfSenhaAtual.Enabled = true;
            }

            funcionario = _funcionario;
            bff = _bff;
            bindingSource.Add(funcionario);
            Console.WriteLine(funcionario.senha);

            foreach (Control c in panelControl.Controls)
            {
                dxValidationProvider.SetIconAlignment(c, ErrorIconAlignment.MiddleRight);
            }

            tfNovaSenha.Properties.UseSystemPasswordChar = true;
            tfSenhaAtual.Properties.UseSystemPasswordChar = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            setValidationsSenha();
            if(dxValidationProvider.Validate()){
                DTICrypto crypto = new DTICrypto();
                funcionario = (Funcionarios) bindingSource.Current;
                var session = ConnectionHelper.OpenSession();
                using (var transaction = session.BeginTransaction())
                {
                    if(tfNovaSenha.Text.Trim().Length >= 1)
                    {
                        funcionario.senha = crypto.Cifrar(tfNovaSenha.Text, CryptoUtil.chave());
                    }

                    session.SaveOrUpdate(funcionario);
                    transaction.Commit();
                    bff.getAll();
                    Dispose();
                }
            }
        }

        public class CustomValidationRuleTamanhoSenha : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                String str = value as String;
                if (str != null)
                {
                    if(str.Trim().Length >= 4){
                        return true;
                    }else{
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public class CustomValidationRuleSenhaAtual : ValidationRule, IDisposable
        {
            FuncionariosForm form;
            public void Dispose()
            {
                if (form != null)
                {
                    form.Dispose();
                    form = null;
                }
            }
            public CustomValidationRuleSenhaAtual(FuncionariosForm _form)
            {
                form = _form;
            }
            public override bool Validate(Control control, object value)
            {
                String str = value as String;
                if (form.funcionario.senha == null || form.funcionario.senha == "")
                {
                    return false;
                }
                
                DTICrypto crypto = new DTICrypto();
                string senha_cad = crypto.Cifrar(str, CryptoUtil.chave());
                if (senha_cad.Equals(form.funcionario.senha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void setValidationsSenha()
        {
            if (tfNovaSenha.Text.Trim().Length >= 1 || tfSenhaAtual.Text.Trim().Length >= 1)
            {
                if ("update".Equals(status))
                {
                    cVRSA = null;
                    cVRSA = new CustomValidationRuleSenhaAtual(this);
                    cVRSA.ErrorText = "Senha atual incorreta.";
                    cVRSA.ErrorType = ErrorType.Critical;
                    dxValidationProvider.SetValidationRule(tfSenhaAtual, cVRSA);
                }
                else
                {
                    cVRSA = null;
                    dxValidationProvider.SetValidationRule(tfSenhaAtual, cVRSA);
                }
            }
            else
            {
                cVRSA = null;
                dxValidationProvider.SetValidationRule(tfSenhaAtual, cVRSA);
            }

            if ("save".Equals(status) || tfNovaSenha.Text.Trim().Length >= 1 || tfSenhaAtual.Text.Trim().Length >= 1)
            {
                cVRTS = null;
                cVRTS = new CustomValidationRuleTamanhoSenha();
                cVRTS.ErrorText = "Senha deve ter no minimo 4 caracteres.";
                cVRTS.ErrorType = ErrorType.Critical;
                dxValidationProvider.SetValidationRule(tfNovaSenha, cVRTS);
            }
            else
            {
                cVRTS = null;
                dxValidationProvider.SetValidationRule(tfNovaSenha, cVRTS);
            }
        }

        private void ckAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if(ckAdministrador.Checked == true){
                ckVendas.Checked = true;
                ckRelatorios.Checked = true;
                ckVendas.Enabled = false;
                ckRelatorios.Enabled = false;
            }
            else
            {
                ckVendas.Enabled = true;
                ckRelatorios.Enabled = true;
            }
        }
    }
}
