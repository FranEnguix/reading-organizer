
namespace Reading_Organizer
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.menDateFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menFontSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menOutputLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.cntReading = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numRestDays = new System.Windows.Forms.NumericUpDown();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.numReadDays = new System.Windows.Forms.NumericUpDown();
            this.radDaysOfTheWeek = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radEveryDay = new System.Windows.Forms.RadioButton();
            this.cntDate = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radProgressPerDay = new System.Windows.Forms.RadioButton();
            this.radEndDate = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.datStart = new System.Windows.Forms.DateTimePicker();
            this.cntDay = new System.Windows.Forms.GroupBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chkCurrentPage = new System.Windows.Forms.CheckBox();
            this.chkBookPercentage = new System.Windows.Forms.CheckBox();
            this.cntBook = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTotalPages = new System.Windows.Forms.CheckBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.numTotalPages = new System.Windows.Forms.NumericUpDown();
            this.numProgressPerDay = new System.Windows.Forms.NumericUpDown();
            this.menu.SuspendLayout();
            this.cntReading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReadDays)).BeginInit();
            this.cntDate.SuspendLayout();
            this.cntDay.SuspendLayout();
            this.cntBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProgressPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(18, 780);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(491, 35);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate PDF";
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menFile,
            this.menPreferences});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(528, 33);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // menFile
            // 
            this.menFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menNew,
            this.menOpen,
            this.menSave,
            this.menSaveAs});
            this.menFile.Name = "menFile";
            this.menFile.Size = new System.Drawing.Size(54, 29);
            this.menFile.Text = "File";
            // 
            // menNew
            // 
            this.menNew.Name = "menNew";
            this.menNew.Size = new System.Drawing.Size(185, 34);
            this.menNew.Text = "New";
            // 
            // menOpen
            // 
            this.menOpen.Name = "menOpen";
            this.menOpen.Size = new System.Drawing.Size(185, 34);
            this.menOpen.Text = "Open...";
            // 
            // menSave
            // 
            this.menSave.Name = "menSave";
            this.menSave.Size = new System.Drawing.Size(185, 34);
            this.menSave.Text = "Save";
            // 
            // menSaveAs
            // 
            this.menSaveAs.Name = "menSaveAs";
            this.menSaveAs.Size = new System.Drawing.Size(185, 34);
            this.menSaveAs.Text = "Save as...";
            this.menSaveAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // menPreferences
            // 
            this.menPreferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menDateFormat,
            this.menFontSettings,
            this.menOutputLocation});
            this.menPreferences.Name = "menPreferences";
            this.menPreferences.Size = new System.Drawing.Size(118, 29);
            this.menPreferences.Text = "Preferences";
            // 
            // menDateFormat
            // 
            this.menDateFormat.Name = "menDateFormat";
            this.menDateFormat.Size = new System.Drawing.Size(251, 34);
            this.menDateFormat.Text = "Date format...";
            // 
            // menFontSettings
            // 
            this.menFontSettings.Name = "menFontSettings";
            this.menFontSettings.Size = new System.Drawing.Size(251, 34);
            this.menFontSettings.Text = "Font settings...";
            // 
            // menOutputLocation
            // 
            this.menOutputLocation.Name = "menOutputLocation";
            this.menOutputLocation.Size = new System.Drawing.Size(251, 34);
            this.menOutputLocation.Text = "Output location...";
            // 
            // cntReading
            // 
            this.cntReading.Controls.Add(this.label5);
            this.cntReading.Controls.Add(this.numRestDays);
            this.cntReading.Controls.Add(this.txt7);
            this.cntReading.Controls.Add(this.txt6);
            this.cntReading.Controls.Add(this.txt5);
            this.cntReading.Controls.Add(this.txt4);
            this.cntReading.Controls.Add(this.txt3);
            this.cntReading.Controls.Add(this.txt2);
            this.cntReading.Controls.Add(this.txt1);
            this.cntReading.Controls.Add(this.chk7);
            this.cntReading.Controls.Add(this.chk6);
            this.cntReading.Controls.Add(this.chk5);
            this.cntReading.Controls.Add(this.chk4);
            this.cntReading.Controls.Add(this.chk3);
            this.cntReading.Controls.Add(this.chk2);
            this.cntReading.Controls.Add(this.chk1);
            this.cntReading.Controls.Add(this.numReadDays);
            this.cntReading.Controls.Add(this.radDaysOfTheWeek);
            this.cntReading.Controls.Add(this.label4);
            this.cntReading.Controls.Add(this.radEveryDay);
            this.cntReading.Location = new System.Drawing.Point(18, 205);
            this.cntReading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cntReading.Name = "cntReading";
            this.cntReading.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cntReading.Size = new System.Drawing.Size(491, 351);
            this.cntReading.TabIndex = 2;
            this.cntReading.TabStop = false;
            this.cntReading.Text = "Reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "days.";
            // 
            // numRestDays
            // 
            this.numRestDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRestDays.Location = new System.Drawing.Point(324, 31);
            this.numRestDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numRestDays.Name = "numRestDays";
            this.numRestDays.Size = new System.Drawing.Size(66, 26);
            this.numRestDays.TabIndex = 24;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(278, 312);
            this.txt7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(162, 26);
            this.txt7.TabIndex = 23;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(278, 277);
            this.txt6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(162, 26);
            this.txt6.TabIndex = 22;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(278, 242);
            this.txt5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(162, 26);
            this.txt5.TabIndex = 21;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(278, 207);
            this.txt4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(162, 26);
            this.txt4.TabIndex = 20;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(278, 172);
            this.txt3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(162, 26);
            this.txt3.TabIndex = 19;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(278, 137);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(162, 26);
            this.txt2.TabIndex = 18;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(278, 102);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(162, 26);
            this.txt1.TabIndex = 17;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(27, 313);
            this.chk7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(234, 24);
            this.chk7.TabIndex = 16;
            this.chk7.Text = "7th day of the week, named:";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(27, 278);
            this.chk6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(234, 24);
            this.chk6.TabIndex = 15;
            this.chk6.Text = "6th day of the week, named:";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(27, 243);
            this.chk5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(234, 24);
            this.chk5.TabIndex = 14;
            this.chk5.Text = "5th day of the week, named:";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(27, 208);
            this.chk4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(234, 24);
            this.chk4.TabIndex = 13;
            this.chk4.Text = "4th day of the week, named:";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(27, 173);
            this.chk3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(234, 24);
            this.chk3.TabIndex = 12;
            this.chk3.Text = "3rd day of the week, named:";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(27, 138);
            this.chk2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(238, 24);
            this.chk2.TabIndex = 11;
            this.chk2.Text = "2nd day of the week, named:";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(27, 103);
            this.chk1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(233, 24);
            this.chk1.TabIndex = 10;
            this.chk1.Text = "1st day of the week, named:";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // numReadDays
            // 
            this.numReadDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numReadDays.Location = new System.Drawing.Point(134, 31);
            this.numReadDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numReadDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReadDays.Name = "numReadDays";
            this.numReadDays.Size = new System.Drawing.Size(66, 26);
            this.numReadDays.TabIndex = 9;
            this.numReadDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radDaysOfTheWeek
            // 
            this.radDaysOfTheWeek.AutoSize = true;
            this.radDaysOfTheWeek.Location = new System.Drawing.Point(15, 66);
            this.radDaysOfTheWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radDaysOfTheWeek.Name = "radDaysOfTheWeek";
            this.radDaysOfTheWeek.Size = new System.Drawing.Size(292, 24);
            this.radDaysOfTheWeek.TabIndex = 8;
            this.radDaysOfTheWeek.Text = "Read the following days of the week:";
            this.radDaysOfTheWeek.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "days, and rest";
            // 
            // radEveryDay
            // 
            this.radEveryDay.AutoSize = true;
            this.radEveryDay.Checked = true;
            this.radEveryDay.Location = new System.Drawing.Point(15, 31);
            this.radEveryDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radEveryDay.Name = "radEveryDay";
            this.radEveryDay.Size = new System.Drawing.Size(114, 24);
            this.radEveryDay.TabIndex = 0;
            this.radEveryDay.TabStop = true;
            this.radEveryDay.Text = "Read every";
            this.radEveryDay.UseVisualStyleBackColor = true;
            // 
            // cntDate
            // 
            this.cntDate.Controls.Add(this.numProgressPerDay);
            this.cntDate.Controls.Add(this.label3);
            this.cntDate.Controls.Add(this.radProgressPerDay);
            this.cntDate.Controls.Add(this.radEndDate);
            this.cntDate.Controls.Add(this.label1);
            this.cntDate.Controls.Add(this.datEnd);
            this.cntDate.Controls.Add(this.datStart);
            this.cntDate.Location = new System.Drawing.Point(18, 565);
            this.cntDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cntDate.Name = "cntDate";
            this.cntDate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cntDate.Size = new System.Drawing.Size(491, 202);
            this.cntDate.TabIndex = 3;
            this.cntDate.TabStop = false;
            this.cntDate.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "percentage/pages.";
            // 
            // radProgressPerDay
            // 
            this.radProgressPerDay.AutoSize = true;
            this.radProgressPerDay.Location = new System.Drawing.Point(14, 152);
            this.radProgressPerDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radProgressPerDay.Name = "radProgressPerDay";
            this.radProgressPerDay.Size = new System.Drawing.Size(230, 24);
            this.radProgressPerDay.TabIndex = 4;
            this.radProgressPerDay.Text = "Amount of progress per day";
            this.radProgressPerDay.UseVisualStyleBackColor = true;
            // 
            // radEndDate
            // 
            this.radEndDate.AutoSize = true;
            this.radEndDate.Checked = true;
            this.radEndDate.Location = new System.Drawing.Point(15, 100);
            this.radEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radEndDate.Name = "radEndDate";
            this.radEndDate.Size = new System.Drawing.Size(102, 24);
            this.radEndDate.TabIndex = 3;
            this.radEndDate.TabStop = true;
            this.radEndDate.Text = "End Date";
            this.radEndDate.UseVisualStyleBackColor = true;
            this.radEndDate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // datEnd
            // 
            this.datEnd.Location = new System.Drawing.Point(142, 100);
            this.datEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(298, 26);
            this.datEnd.TabIndex = 1;
            // 
            // datStart
            // 
            this.datStart.Location = new System.Drawing.Point(142, 45);
            this.datStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datStart.Name = "datStart";
            this.datStart.Size = new System.Drawing.Size(298, 26);
            this.datStart.TabIndex = 0;
            // 
            // cntDay
            // 
            this.cntDay.Controls.Add(this.chkDate);
            this.cntDay.Controls.Add(this.chkCurrentPage);
            this.cntDay.Controls.Add(this.chkBookPercentage);
            this.cntDay.Location = new System.Drawing.Point(275, 42);
            this.cntDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cntDay.Name = "cntDay";
            this.cntDay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cntDay.Size = new System.Drawing.Size(234, 154);
            this.cntDay.TabIndex = 4;
            this.cntDay.TabStop = false;
            this.cntDay.Text = "Day info";
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(26, 105);
            this.chkDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(70, 24);
            this.chkDate.TabIndex = 2;
            this.chkDate.Text = "Date";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // chkCurrentPage
            // 
            this.chkCurrentPage.AutoSize = true;
            this.chkCurrentPage.Location = new System.Drawing.Point(26, 66);
            this.chkCurrentPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCurrentPage.Name = "chkCurrentPage";
            this.chkCurrentPage.Size = new System.Drawing.Size(128, 24);
            this.chkCurrentPage.TabIndex = 1;
            this.chkCurrentPage.Text = "Current page";
            this.chkCurrentPage.UseVisualStyleBackColor = true;
            // 
            // chkBookPercentage
            // 
            this.chkBookPercentage.AutoSize = true;
            this.chkBookPercentage.Location = new System.Drawing.Point(26, 31);
            this.chkBookPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBookPercentage.Name = "chkBookPercentage";
            this.chkBookPercentage.Size = new System.Drawing.Size(157, 24);
            this.chkBookPercentage.TabIndex = 0;
            this.chkBookPercentage.Text = "Book percentage";
            this.chkBookPercentage.UseVisualStyleBackColor = true;
            // 
            // cntBook
            // 
            this.cntBook.Controls.Add(this.numTotalPages);
            this.cntBook.Controls.Add(this.txtTitle);
            this.cntBook.Controls.Add(this.label2);
            this.cntBook.Controls.Add(this.chkTotalPages);
            this.cntBook.Location = new System.Drawing.Point(18, 42);
            this.cntBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cntBook.Name = "cntBook";
            this.cntBook.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cntBook.Size = new System.Drawing.Size(234, 154);
            this.cntBook.TabIndex = 5;
            this.cntBook.TabStop = false;
            this.cntBook.Text = "Book info";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(15, 57);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(206, 26);
            this.txtTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // chkTotalPages
            // 
            this.chkTotalPages.AutoSize = true;
            this.chkTotalPages.Location = new System.Drawing.Point(15, 105);
            this.chkTotalPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTotalPages.Name = "chkTotalPages";
            this.chkTotalPages.Size = new System.Drawing.Size(118, 24);
            this.chkTotalPages.TabIndex = 1;
            this.chkTotalPages.Text = "Total pages";
            this.chkTotalPages.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "rot";
            this.saveFileDialog.Filter = "RS Reading Organizer Template file (*.rot) | All files (*.*)";
            this.saveFileDialog.Title = "Save RS Reading Organizer template";
            // 
            // numTotalPages
            // 
            this.numTotalPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTotalPages.Location = new System.Drawing.Point(141, 104);
            this.numTotalPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numTotalPages.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numTotalPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalPages.Name = "numTotalPages";
            this.numTotalPages.Size = new System.Drawing.Size(80, 26);
            this.numTotalPages.TabIndex = 10;
            this.numTotalPages.ThousandsSeparator = true;
            this.numTotalPages.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // numProgressPerDay
            // 
            this.numProgressPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numProgressPerDay.DecimalPlaces = 1;
            this.numProgressPerDay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numProgressPerDay.Location = new System.Drawing.Point(252, 154);
            this.numProgressPerDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numProgressPerDay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numProgressPerDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numProgressPerDay.Name = "numProgressPerDay";
            this.numProgressPerDay.Size = new System.Drawing.Size(80, 26);
            this.numProgressPerDay.TabIndex = 11;
            this.numProgressPerDay.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 834);
            this.Controls.Add(this.cntBook);
            this.Controls.Add(this.cntDay);
            this.Controls.Add(this.cntDate);
            this.Controls.Add(this.cntReading);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 890);
            this.Name = "MainForm";
            this.Text = "RS Reading Organizer";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.cntReading.ResumeLayout(false);
            this.cntReading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReadDays)).EndInit();
            this.cntDate.ResumeLayout(false);
            this.cntDate.PerformLayout();
            this.cntDay.ResumeLayout(false);
            this.cntDay.PerformLayout();
            this.cntBook.ResumeLayout(false);
            this.cntBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProgressPerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menFile;
        private System.Windows.Forms.ToolStripMenuItem menNew;
        private System.Windows.Forms.ToolStripMenuItem menOpen;
        private System.Windows.Forms.ToolStripMenuItem menSave;
        private System.Windows.Forms.ToolStripMenuItem menSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menPreferences;
        private System.Windows.Forms.GroupBox cntReading;
        private System.Windows.Forms.GroupBox cntDate;
        private System.Windows.Forms.RadioButton radEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datEnd;
        private System.Windows.Forms.DateTimePicker datStart;
        private System.Windows.Forms.GroupBox cntDay;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox chkCurrentPage;
        private System.Windows.Forms.CheckBox chkBookPercentage;
        private System.Windows.Forms.GroupBox cntBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTotalPages;
        private System.Windows.Forms.ToolStripMenuItem menDateFormat;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.NumericUpDown numReadDays;
        private System.Windows.Forms.RadioButton radDaysOfTheWeek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radEveryDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radProgressPerDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRestDays;
        private System.Windows.Forms.ToolStripMenuItem menFontSettings;
        private System.Windows.Forms.ToolStripMenuItem menOutputLocation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NumericUpDown numProgressPerDay;
        private System.Windows.Forms.NumericUpDown numTotalPages;
    }
}

