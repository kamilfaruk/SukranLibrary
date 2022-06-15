/* Coder by KFY */
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SukranLibrary.Models;
using SukranLibrary.Database;
using SukranLibrary.Components;
using System.Collections.Generic;
using SukranLibrary.Components.Notification;

namespace SukranLibrary.Controls
{
    public partial class QuotationCrudControl : UserControl
    {
        public int Main_BookId = 0;
        Quotation Main_Quotation = new Quotation();
        public delegate void AddQuotationEvent();
        public event AddQuotationEvent AddQuotation;
        public delegate void UpdateQuotationEvent();
        public event UpdateQuotationEvent UpdateQuotation;
        public delegate void DeleteQuotationEvent();
        public event DeleteQuotationEvent DeleteQuotation;
        public delegate void QuotationSelectedEvent();
        public event QuotationSelectedEvent QuotationSelected;
        public QuotationCrudControl()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationCrudControl.QuotationCrudControl -> ", _ex);
            }
        }
        public void Refresh(int _bookId)
        {
            Main_BookId = _bookId;
            PopulateDataGridView();
        }
        private void QuotationCrudControl_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                PopulateDataGridView();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationCrudControl.QuotationCrudControl_Load -> ", _ex);
            }
        }
        private void Quotation_Dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    if (Quotation_Dgv.CurrentRow.Index != -1)
                    {
                        Main_Quotation.Id = Convert.ToInt32(Quotation_Dgv.CurrentRow.Cells["Id"].Value);
                        Main_Quotation = _dbManager.GetQuotationList().Where(x => x.Id == Main_Quotation.Id).FirstOrDefault();
                        Page_Num.Value = Main_Quotation.Page;
                        Summary_Txt.Texts = Main_Quotation.Summary;
                        Save_Btn.Text = "DÜZENLE";
                        Save_Btn.Image = Properties.Resources.Edit_Image;
                        Delete_Btn.Enabled = true;
                        if (QuotationSelected != null)
                        {
                            QuotationSelected();
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationCrudControl.Quotation_Dgv_DoubleClick -> ", _ex);
            }
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_BookId == 0)
                {
                    using (MsgBox _msgBox = new MsgBox())
                    {
                        string _message = "Herhangi bir alıntı ekleyebilmek veya değişiklik yapabilmek için lütfen ilk olarak kitap seçiniz.";
                        string _header = "ALINTI DEĞİŞİKLİK BİLGİLENDİRMESİ";
                        DialogResult _ans = _msgBox.Show(_message, _header, MsgBox.Buttons.OK, MsgBox.Icons.Info);
                    }
                }
                else
                {
                    using (DBManager _dbManager = new DBManager())
                    {
                        Main_Quotation.Page = Convert.ToInt32(Page_Num.Value);
                        Main_Quotation.Summary = Summary_Txt.Texts;
                        if (Main_Quotation.Id == 0)
                        {
                            Book _book = _dbManager.GetBook(Main_BookId);
                            Main_Quotation.Book = _book;
                            Main_Quotation.BookId = _book.Id;
                            if (_dbManager.AddQuotation(Main_Quotation))
                            {
                                if (AddQuotation != null)
                                {
                                    AddQuotation();
                                }
                            }
                        }
                        else
                        {
                            if (_dbManager.UpdateQuotation(Main_Quotation))
                            {
                                if (UpdateQuotation != null)
                                {
                                    UpdateQuotation();
                                }
                            }
                        }
                    }
                    Clear();
                    PopulateDataGridView();
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationCrudControl.Save_Btn_Click -> ", _ex);
            }
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MsgBox _msgBox = new MsgBox())
                {
                    string _message = "Alıntıyı silmek istediğinizden emin misiniz?";
                    string _header = "ALINTI SİLME ONAYI";
                    DialogResult _ans = _msgBox.Show(_message, _header, MsgBox.Buttons.YesNo, MsgBox.Icons.Question);
                    if (_ans == DialogResult.Yes)
                    {
                        using (DBManager _dbManager = new DBManager())
                        {
                            if (_dbManager.DeleteQuotation(Main_Quotation))
                            {
                                if (DeleteQuotation != null)
                                {
                                    DeleteQuotation();
                                }
                            }
                        }
                        PopulateDataGridView();
                        Clear();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationCrudControl.Delete_Btn_Click -> ", _ex);
            }
        }
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("QuotationCrudControl.Cancel_Btn_Click -> ", _ex);
            }
        }
        private void Clear()
        {
            try
            {
                Page_Num.Value = 0;
                Summary_Txt.Texts = "";
                Save_Btn.Text = "KAYDET";
                Save_Btn.Image = Properties.Resources.Save_Image;
                Delete_Btn.Enabled = false;
                Main_Quotation.Id = 0;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookCrudControl.Clear -> ", _ex);
            }
        }
        private void PopulateDataGridView()
        {
            try
            {
                Quotation_Dgv.AutoGenerateColumns = false;
                using (DBManager _dbManager = new DBManager())
                {
                    if (Main_BookId != 0)
                    {
                        List<Quotation> _quotationList = _dbManager.GetQuotationList().FindAll(_quotation => _quotation.BookId == Main_BookId);
                        if (_quotationList != null)
                        {
                            _quotationList = _quotationList.OrderBy(_quotation => _quotation.Page).ToList();
                            Quotation_Dgv.DataSource = _quotationList;
                        }
                    }
                    else
                    {
                        List<Quotation> _quotationList = _dbManager.GetQuotationList();
                        _quotationList = _quotationList.OrderBy(_quotation => _quotation.Page).ToList();
                        Quotation_Dgv.DataSource = _quotationList;
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("BookCrudControl.PopulateDataGridView -> ", _ex);
            }
        }
    }
}
