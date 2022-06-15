/* Coder by KFY */
using System;
using System.Windows.Forms;

namespace SukranLibrary.Forms.SubForms
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorForm.AuthorForm -> ", _ex);
            }
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("AuthorForm.Close_Btn_Click -> ", _ex);
            }
        }
    }
}
