/* Coder by KFY */
using System;
using System.Windows.Forms;

namespace SukranLibrary.Forms.SubForms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("SettingsForm.SettingsForm -> ", _ex);
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
                Logger.WriteLog("SettingsForm.Close_Btn_Click -> ", _ex);
            }
        }
    }
}
