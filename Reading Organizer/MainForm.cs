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
using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

namespace Reading_Organizer
{
    public partial class MainForm : Form
    {
        private Hashtable formData;
        private string path = "default.json";

        public MainForm() {
            // formData = new Hashtable();
            InitializeComponent();
            if (File.Exists(path)) {
                LoadTemplate(path);
            } else {
                formData = new Hashtable();
                GetFormData(formData);
            }
            SetFormData(formData);
        }

        private void SaveCurrentTemplate(string path) {
            GetFormData(formData);
            SaveTemplate(path, formData);
        }

        private void SaveTemplate(string path, Hashtable data) {
            TemplateFile.SaveTemplate(path, data);
        }

        private void LoadTemplate(string path) {
            formData = TemplateFile.LoadTemplate(path);
            SetFormData(formData);
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

            for (int i = 0; i < 186; i++) {
                Table mainDiv = new Table(new float[] { 75, 25 });
                mainDiv.SetKeepTogether(true); // Avoid splitting cells in different pages

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
            var dialog = saveFileDialog.ShowDialog();
            if (dialog == DialogResult.OK) {
                string fileName = saveFileDialog.FileName;
                string filePath = Path.GetFullPath(fileName);
                SaveCurrentTemplate(filePath);
            }
        }
        private void menOpen_Click(object sender, EventArgs e) {
            var dialog = openFileDialog.ShowDialog();
            if (dialog == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
                string filePath = Path.GetFullPath(fileName);
                LoadTemplate(filePath);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e) {

        }

        // Set hashtable data into form
        private void SetFormData(Hashtable data) {
            txtTitle.Text = data[txtTitle.Name].ToString();
            chkTotalPages.Checked = Boolean.Parse(data[chkTotalPages.Name].ToString());
            numTotalPages.Value = int.Parse(data[numTotalPages.Name].ToString());
            chkBookPercentage.Checked = Boolean.Parse(data[chkBookPercentage.Name].ToString());
            chkCurrentPage.Checked = Boolean.Parse(data[chkCurrentPage.Name].ToString());
            chkDate.Checked = Boolean.Parse(data[chkDate.Name].ToString());
            radEveryDay.Checked = Boolean.Parse(data[radEveryDay.Name].ToString());
            numReadDays.Value = int.Parse(data[numReadDays.Name].ToString());
            numRestDays.Value = int.Parse(data[numRestDays.Name].ToString());
            radDaysOfTheWeek.Checked = Boolean.Parse(data[radDaysOfTheWeek.Name].ToString());
            chk1.Checked = Boolean.Parse(data[chk1.Name].ToString());
            chk2.Checked = Boolean.Parse(data[chk2.Name].ToString());
            chk3.Checked = Boolean.Parse(data[chk3.Name].ToString());
            chk4.Checked = Boolean.Parse(data[chk4.Name].ToString());
            chk5.Checked = Boolean.Parse(data[chk5.Name].ToString());
            chk6.Checked = Boolean.Parse(data[chk6.Name].ToString());
            chk7.Checked = Boolean.Parse(data[chk7.Name].ToString());
            txt1.Text = data[txt1.Name].ToString();
            txt2.Text = data[txt2.Name].ToString();
            txt3.Text = data[txt3.Name].ToString();
            txt4.Text = data[txt4.Name].ToString();
            txt5.Text = data[txt5.Name].ToString();
            txt6.Text = data[txt6.Name].ToString();
            txt7.Text = data[txt7.Name].ToString();
            datStart.Value = DateTime.Parse(data[datStart.Name].ToString());
            datEnd.Value = DateTime.Parse(data[datEnd.Name].ToString());
            radEndDate.Checked = Boolean.Parse(data[radEndDate.Name].ToString());
            radProgressPerDay.Checked = Boolean.Parse(data[radProgressPerDay.Name].ToString());
            numProgressPerDay.Value = TextToDecimal(data[numProgressPerDay.Name].ToString());
            cmbProgressType.SelectedIndex = int.Parse(data[cmbProgressType.Name].ToString());
        }

        // Puts form data into hashtable
        private void GetFormData(Hashtable data) {
            data.Clear();
            data.Add(txtTitle.Name, txtTitle.Text);
            data.Add(chkTotalPages.Name, chkTotalPages.Checked);
            data.Add(numTotalPages.Name, numTotalPages.Value);
            data.Add(chkBookPercentage.Name, chkBookPercentage.Checked);
            data.Add(chkCurrentPage.Name, chkCurrentPage.Checked);
            data.Add(chkDate.Name, chkDate.Checked);
            data.Add(radEveryDay.Name, radEveryDay.Checked);
            data.Add(numReadDays.Name, numReadDays.Value);
            data.Add(numRestDays.Name, numRestDays.Value);
            data.Add(radDaysOfTheWeek.Name, radDaysOfTheWeek.Checked);
            data.Add(chk1.Name, chk1.Checked);
            data.Add(chk2.Name, chk2.Checked);
            data.Add(chk3.Name, chk3.Checked);
            data.Add(chk4.Name, chk4.Checked);
            data.Add(chk5.Name, chk5.Checked);
            data.Add(chk6.Name, chk6.Checked);
            data.Add(chk7.Name, chk7.Checked);
            data.Add(txt1.Name, txt1.Text);
            data.Add(txt2.Name, txt2.Text);
            data.Add(txt3.Name, txt3.Text);
            data.Add(txt4.Name, txt4.Text);
            data.Add(txt5.Name, txt5.Text);
            data.Add(txt6.Name, txt6.Text);
            data.Add(txt7.Name, txt7.Text);
            data.Add(datStart.Name, datStart.Value);
            data.Add(datEnd.Name, datEnd.Value);
            data.Add(radEndDate.Name, radEndDate.Checked);
            data.Add(radProgressPerDay.Name, radProgressPerDay.Checked);
            data.Add(numProgressPerDay.Name, numProgressPerDay.Value);
            data.Add(cmbProgressType.Name, cmbProgressType.SelectedIndex);
        }

        private decimal TextToDecimal(string text) {
            decimal result;
            if (decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal progress))
                result = progress;
            else
                // TODO Create custom exception
                throw new Exception("Invalid format number in amount of progress per day");
            return result;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            GetFormData(formData);
            TemplateFile.SaveTemplate(path, formData);
        }

    }
}
