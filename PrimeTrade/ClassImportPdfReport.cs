using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using PrimeTrade.connections;
using Syncfusion;
using PagedList;
using DGVPrinterHelper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace PrimeTrade
{
    class ClassImportPdfReport
    {
        public void exportGridtoPdf(DataGridView dtpView, string filename)
        {
            BaseFont bt = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dtpView.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bt, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in dtpView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dtpView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFiledialog = new SaveFileDialog();
            saveFiledialog.FileName = filename;
            saveFiledialog.DefaultExt = ".pdf";

            if (saveFiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }
    }
}
