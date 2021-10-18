using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_Organizer
{
    class PdfGenerator
    {
        private Hashtable formData;
        private Hashtable preferences;
        private string filePath;
        private Style daysLeftStyle;
        private Style dateStyle;
        private Style infoStyle;

        public PdfGenerator() {
            SetupStyles();
        }

        private void SetupStyles() {
            PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            PdfFont infoFont = PdfFontFactory.CreateFont(StandardFonts.COURIER);
            daysLeftStyle = new Style();
            daysLeftStyle.SetFont(normalFont).SetFontSize(20);
            dateStyle = new Style();
            dateStyle.SetFont(infoFont).SetFontSize(10);
            infoStyle = new Style();
            infoStyle.SetFont(infoFont).SetFontSize(8);
        }

        public Hashtable FormData {
            get => formData;
            set => formData = value;
        }
        public Hashtable Preferences {
            get => preferences;
            set => preferences = value;
        }

        public string FilePath {
            get => filePath;
            set => filePath = value;
        }

        public void GeneratePdf() {
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(fileStream));
            Document document = new Document(pdfDocument);
            Table mainTable = GenerateMainTable();
            document.Add(mainTable);
            document.Close();
        }

        private Table GenerateMainTable() {
            const short numDaysOfTheWeek = 7;
            Table table = new Table(numDaysOfTheWeek, false);
            GenerateHeader(table);
            return table;
        }

        private void GenerateHeader(Table table) {
            table.UseAllAvailableWidth();
            string[] daysOfTheWeek = (string[]) preferences["daysOfTheWeek"];
            for (int i = 0; i < daysOfTheWeek.Length; i++) {
                string day = daysOfTheWeek[i];
                Paragraph paragraph = new Paragraph(day);
                paragraph.SetTextAlignment(TextAlignment.CENTER);
                Cell cell = new Cell();
                cell.SetBorder(Border.NO_BORDER);
                cell.Add(paragraph);
                table.AddHeaderCell(cell);
            }
        }
    }
}
