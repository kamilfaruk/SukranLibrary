/* Coder by KFY */
using System;
using System.Windows.Forms;

namespace SukranLibrary.Forms.SubForms
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FilterForm.FilterForm -> ", _ex);
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
                Logger.WriteLog("FilterForm.Close_Btn_Click -> ", _ex);
            }
        }
        private void BookFilter_Btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!Main_Table.Controls.Contains(Main_BookFilterControl))
                {
                    if (Main_Table.Controls.Contains(Main_QuotationFilterControl))
                    {
                        Main_Table.Controls.Remove(Main_QuotationFilterControl);
                    }
                    Main_Table.Controls.Add(Main_BookFilterControl, 0, 2);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FilterForm.BookFilter_Btn_Click -> ", _ex);
            }
        }
        private void QuotationFilter_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Main_Table.Controls.Contains(Main_QuotationFilterControl))
                {
                    if (Main_Table.Controls.Contains(Main_BookFilterControl))
                    {
                        Main_Table.Controls.Remove(Main_BookFilterControl);
                    }
                    Main_Table.Controls.Add(Main_QuotationFilterControl, 0, 2);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FilterForm.QuotationFilter_Btn_Click -> ", _ex);
            }
        }
    }
}
