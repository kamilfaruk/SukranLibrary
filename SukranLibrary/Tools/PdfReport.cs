/* Coder by KFY */
using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace SukranLibrary.Tools
{
    public class PdfReport
    {

        public bool GenerateAndSaveReport(string _creationReasonText)
        {
            try
            {
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("PdfReport.GenerateAndSaveReport -> ", _ex);
                return false;
            }
        }
        void FillTableCells(PdfPTable table, Font fontValue, string _modName, string _totalMoney, string _totalTime, string _workCount)
        {
            try
            {
                table.AddCell(new PdfPCell(new Phrase(_modName, fontValue)));
                table.AddCell(new PdfPCell(new Phrase(_totalMoney, fontValue)));
                table.AddCell(new PdfPCell(new Phrase(_totalTime, fontValue)));
                table.AddCell(new PdfPCell(new Phrase(_workCount, fontValue)));
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("PdfReport.FillTableCells -> ", _ex);
            }

        }
    }
}

