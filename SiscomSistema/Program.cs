using DevExpress.LookAndFeel;
using SiscomSistema.Util;
using SiscomSistema.View;
using SiscomSistema.View.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SiscomSistema
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");

            log4net.Config.XmlConfigurator.Configure();

            Application.Run(new BuscaFuncionariosForm());            
        }
    }
}
