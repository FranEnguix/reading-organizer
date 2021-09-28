using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using iText.Kernel.Colors;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Font;
using iText.IO.Font;
using System.Drawing.Text;
using iText.IO.Font.Constants;

namespace Reading_Organizer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Temporal();
        }

        private static void Temporal() {
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream("holi.pdf", FileMode.Create, FileAccess.Write)));
            Document document = new Document(pdfDocument);

            Environment.SpecialFolder specialFolder = Environment.SpecialFolder.Fonts;
            string path = Environment.GetFolderPath(specialFolder);
            PdfFontFactory.RegisterDirectory(path);
            var installedFonts = PdfFontFactory.GetRegisteredFonts();

            PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            PdfFont infoFont = PdfFontFactory.CreateFont(StandardFonts.COURIER);
            Style daysLeft = new Style();
            daysLeft.SetFont(normalFont).SetFontSize(20);
            Style date = new Style();
            date.SetFont(infoFont).SetFontSize(10);
            Style positionInfo = new Style();
            positionInfo.SetFont(infoFont).SetFontSize(8);

            Table table = new Table(7, false);
            table.UseAllAvailableWidth();
            var days = new List<String>
            {
                "L",
                "M",
                "X",
                "J",
                "V",
                "S",
                "D"
            };
            foreach (var day in days) {
                Paragraph paragraph = new Paragraph(day);
                paragraph.SetTextAlignment(TextAlignment.CENTER);
                Cell cell = new Cell();
                cell.SetBorder(Border.NO_BORDER);
                cell.Add(paragraph);
                table.AddHeaderCell(cell);
            }

            for (int i = 0; i < 16; i++) {
                Table mainDiv = new Table(new float[] { 75, 25 });
                Cell leftDiv = new Cell();
                Cell rightDiv = new Cell();
                mainDiv.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);
                mainDiv.UseAllAvailableWidth();
                mainDiv.SetPadding(0);
                mainDiv.AddCell(leftDiv);
                mainDiv.AddCell(rightDiv);

                leftDiv.SetBorder(Border.NO_BORDER);
                leftDiv.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);
                leftDiv.SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE);
                leftDiv.Add(new Paragraph("23").AddStyle(daysLeft).SetTextAlignment(TextAlignment.CENTER));
                leftDiv.SetPadding(0);
                leftDiv.SetMargin(0);
                //leftDiv.SetWidth(UnitValue.CreatePercentValue(50));
                //leftDiv.SetBackgroundColor(new DeviceRgb(255,0,0));

                rightDiv.SetBorder(Border.NO_BORDER);
                rightDiv.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);
                rightDiv.SetVerticalAlignment(VerticalAlignment.BOTTOM);
                rightDiv.SetTextAlignment(TextAlignment.RIGHT);
                rightDiv.Add(new Paragraph("13,7%").AddStyle(positionInfo));
                rightDiv.Add(new Paragraph("152p").AddStyle(positionInfo));
                rightDiv.Add(new Paragraph("08/10").AddStyle(date));
                rightDiv.SetPadding(0);
                rightDiv.SetMargin(0);
                //rightDiv.SetWidth(UnitValue.CreatePercentValue(50));
                //rightDiv.SetBackgroundColor(new DeviceRgb(0,255,0));

                table.AddCell(mainDiv);
            }
            document.Add(table);
            document.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
