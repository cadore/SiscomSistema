using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiscomSistema.Util
{
    public static class Utils
    {
        public static bool textFieldIsEmpty(TextEdit textField)
        {
            string t = textField.Text;
            try
            {
                if (t == null || t.Equals(String.Empty))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
