/* Coder by KFY */
using System;
using System.Windows.Forms;

namespace SukranLibrary.Forms.SubForms
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookForm.BookForm -> ", _ex);
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
                Logger.WriteLog("BookForm.Close_Btn_Click -> ", _ex);
            }
        }
        private void Main_BookCrudControl_BookSelected(int _bookId)
        {
            Main_QuotationCrudControl.Refresh(_bookId);
        }
    }
}
