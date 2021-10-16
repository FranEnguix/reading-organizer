
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
            this.cmbProgressType = new System.Windows.Forms.ComboBox();
            this.numProgressPerDay = new System.Windows.Forms.NumericUpDown();
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
            this.numTotalPages = new System.Windows.Forms.NumericUpDown();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTotalPages = new System.Windows.Forms.CheckBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.cntReading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReadDays)).BeginInit();
            this.cntDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProgressPerDay)).BeginInit();
            this.cntDay.SuspendLayout();
            this.cntBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(12, 513);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(326, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate PDF";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menFile,
            this.menPreferences});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menu.Size = new System.Drawing.Size(350, 24);
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
            this.menFile.Size = new System.Drawing.Size(37, 22);
            this.menFile.Text = "File";
            // 
            // menNew
            // 
            this.menNew.Name = "menNew";
            this.menNew.Size = new System.Drawing.Size(180, 22);
            this.menNew.Text = "New";
            this.menNew.Click += new System.EventHandler(this.menNew_Click);
            // 
            // menOpen
            // 
            this.menOpen.Name = "menOpen";
            this.menOpen.Size = new System.Drawing.Size(121, 22);
            this.menOpen.Text = "Open...";
            this.menOpen.Click += new System.EventHandler(this.menOpen_Click);
            // 
            // menSave
            // 
            this.menSave.Name = "menSave";
            this.menSave.Size = new System.Drawing.Size(121, 22);
            this.menSave.Text = "Save";
            // 
            // menSaveAs
            // 
            this.menSaveAs.Name = "menSaveAs";
            this.menSaveAs.Size = new System.Drawing.Size(121, 22);
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
            this.menPreferences.Size = new System.Drawing.Size(80, 22);
            this.menPreferences.Text = "Preferences";
            // 
            // menDateFormat
            // 
            this.menDateFormat.Name = "menDateFormat";
            this.menDateFormat.Size = new System.Drawing.Size(167, 22);
            this.menDateFormat.Text = "Date format...";
            // 
            // menFontSettings
            // 
            this.menFontSettings.Name = "menFontSettings";
            this.menFontSettings.Size = new System.Drawing.Size(167, 22);
            this.menFontSettings.Text = "Font settings...";
            // 
            // menOutputLocation
            // 
            this.menOutputLocation.Name = "menOutputLocation";
            this.menOutputLocation.Size = new System.Drawing.Size(167, 22);
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
            this.cntReading.Location = new System.Drawing.Point(12, 133);
            this.cntReading.Name = "cntReading";
            this.cntReading.Size = new System.Drawing.Size(326, 237);
            this.cntReading.TabIndex = 2;
            this.cntReading.TabStop = false;
            this.cntReading.Text = "Reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "days.";
            // 
            // numRestDays
            // 
            this.numRestDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRestDays.Location = new System.Drawing.Point(216, 20);
            this.numRestDays.Name = "numRestDays";
            this.numRestDays.Size = new System.Drawing.Size(44, 20);
            this.numRestDays.TabIndex = 24;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(185, 203);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(122, 20);
            this.txt7.TabIndex = 23;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(185, 180);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(122, 20);
            this.txt6.TabIndex = 22;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(185, 157);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(122, 20);
            this.txt5.TabIndex = 21;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(185, 135);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(122, 20);
            this.txt4.TabIndex = 20;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(185, 112);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(122, 20);
            this.txt3.TabIndex = 19;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(185, 89);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(122, 20);
            this.txt2.TabIndex = 18;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(185, 66);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(122, 20);
            this.txt1.TabIndex = 17;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(18, 203);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(161, 17);
            this.chk7.TabIndex = 16;
            this.chk7.Text = "7th day of the week, named:";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(18, 181);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(161, 17);
            this.chk6.TabIndex = 15;
            this.chk6.Text = "6th day of the week, named:";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(18, 158);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(161, 17);
            this.chk5.TabIndex = 14;
            this.chk5.Text = "5th day of the week, named:";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(18, 135);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(161, 17);
            this.chk4.TabIndex = 13;
            this.chk4.Text = "4th day of the week, named:";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(18, 112);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(161, 17);
            this.chk3.TabIndex = 12;
            this.chk3.Text = "3rd day of the week, named:";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(18, 90);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(164, 17);
            this.chk2.TabIndex = 11;
            this.chk2.Text = "2nd day of the week, named:";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(18, 67);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(160, 17);
            this.chk1.TabIndex = 10;
            this.chk1.Text = "1st day of the week, named:";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // numReadDays
            // 
            this.numReadDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numReadDays.Location = new System.Drawing.Point(89, 20);
            this.numReadDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReadDays.Name = "numReadDays";
            this.numReadDays.Size = new System.Drawing.Size(44, 20);
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
            this.radDaysOfTheWeek.Location = new System.Drawing.Point(10, 43);
            this.radDaysOfTheWeek.Name = "radDaysOfTheWeek";
            this.radDaysOfTheWeek.Size = new System.Drawing.Size(200, 17);
            this.radDaysOfTheWeek.TabIndex = 8;
            this.radDaysOfTheWeek.Text = "Read the following days of the week:";
            this.radDaysOfTheWeek.UseVisualStyleBackColor = true;
            this.radDaysOfTheWeek.CheckedChanged += new System.EventHandler(this.radDaysOfTheWeek_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "days, and rest";
            // 
            // radEveryDay
            // 
            this.radEveryDay.AutoSize = true;
            this.radEveryDay.Checked = true;
            this.radEveryDay.Location = new System.Drawing.Point(10, 20);
            this.radEveryDay.Name = "radEveryDay";
            this.radEveryDay.Size = new System.Drawing.Size(80, 17);
            this.radEveryDay.TabIndex = 0;
            this.radEveryDay.TabStop = true;
            this.radEveryDay.Text = "Read every";
            this.radEveryDay.UseVisualStyleBackColor = true;
            this.radEveryDay.CheckedChanged += new System.EventHandler(this.radEveryDay_CheckedChanged);
            // 
            // cntDate
            // 
            this.cntDate.Controls.Add(this.cmbProgressType);
            this.cntDate.Controls.Add(this.numProgressPerDay);
            this.cntDate.Controls.Add(this.radProgressPerDay);
            this.cntDate.Controls.Add(this.radEndDate);
            this.cntDate.Controls.Add(this.label1);
            this.cntDate.Controls.Add(this.datEnd);
            this.cntDate.Controls.Add(this.datStart);
            this.cntDate.Location = new System.Drawing.Point(12, 376);
            this.cntDate.Name = "cntDate";
            this.cntDate.Size = new System.Drawing.Size(326, 131);
            this.cntDate.TabIndex = 3;
            this.cntDate.TabStop = false;
            this.cntDate.Text = "Date";
            // 
            // cmbProgressType
            // 
            this.cmbProgressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgressType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProgressType.FormattingEnabled = true;
            this.cmbProgressType.Items.AddRange(new object[] {
            "percentage",
            "pages"});
            this.cmbProgressType.Location = new System.Drawing.Point(227, 98);
            this.cmbProgressType.Name = "cmbProgressType";
            this.cmbProgressType.Size = new System.Drawing.Size(80, 21);
            this.cmbProgressType.TabIndex = 12;
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
            this.numProgressPerDay.Location = new System.Drawing.Point(168, 100);
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
            this.numProgressPerDay.Size = new System.Drawing.Size(53, 20);
            this.numProgressPerDay.TabIndex = 11;
            this.numProgressPerDay.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // radProgressPerDay
            // 
            this.radProgressPerDay.AutoSize = true;
            this.radProgressPerDay.Location = new System.Drawing.Point(9, 99);
            this.radProgressPerDay.Name = "radProgressPerDay";
            this.radProgressPerDay.Size = new System.Drawing.Size(154, 17);
            this.radProgressPerDay.TabIndex = 4;
            this.radProgressPerDay.Text = "Amount of progress per day";
            this.radProgressPerDay.UseVisualStyleBackColor = true;
            this.radProgressPerDay.CheckedChanged += new System.EventHandler(this.radProgressPerDay_CheckedChanged);
            // 
            // radEndDate
            // 
            this.radEndDate.AutoSize = true;
            this.radEndDate.Checked = true;
            this.radEndDate.Location = new System.Drawing.Point(10, 65);
            this.radEndDate.Name = "radEndDate";
            this.radEndDate.Size = new System.Drawing.Size(70, 17);
            this.radEndDate.TabIndex = 3;
            this.radEndDate.TabStop = true;
            this.radEndDate.Text = "End Date";
            this.radEndDate.UseVisualStyleBackColor = true;
            this.radEndDate.CheckedChanged += new System.EventHandler(this.radEndDate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // datEnd
            // 
            this.datEnd.Location = new System.Drawing.Point(95, 65);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(212, 20);
            this.datEnd.TabIndex = 1;
            // 
            // datStart
            // 
            this.datStart.Location = new System.Drawing.Point(95, 29);
            this.datStart.Name = "datStart";
            this.datStart.Size = new System.Drawing.Size(212, 20);
            this.datStart.TabIndex = 0;
            // 
            // cntDay
            // 
            this.cntDay.Controls.Add(this.chkDate);
            this.cntDay.Controls.Add(this.chkCurrentPage);
            this.cntDay.Controls.Add(this.chkBookPercentage);
            this.cntDay.Location = new System.Drawing.Point(183, 27);
            this.cntDay.Name = "cntDay";
            this.cntDay.Size = new System.Drawing.Size(155, 100);
            this.cntDay.TabIndex = 4;
            this.cntDay.TabStop = false;
            this.cntDay.Text = "Day info";
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(17, 68);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(49, 17);
            this.chkDate.TabIndex = 2;
            this.chkDate.Text = "Date";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // chkCurrentPage
            // 
            this.chkCurrentPage.AutoSize = true;
            this.chkCurrentPage.Location = new System.Drawing.Point(17, 43);
            this.chkCurrentPage.Name = "chkCurrentPage";
            this.chkCurrentPage.Size = new System.Drawing.Size(87, 17);
            this.chkCurrentPage.TabIndex = 1;
            this.chkCurrentPage.Text = "Current page";
            this.chkCurrentPage.UseVisualStyleBackColor = true;
            // 
            // chkBookPercentage
            // 
            this.chkBookPercentage.AutoSize = true;
            this.chkBookPercentage.Location = new System.Drawing.Point(17, 20);
            this.chkBookPercentage.Name = "chkBookPercentage";
            this.chkBookPercentage.Size = new System.Drawing.Size(108, 17);
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
            this.cntBook.Location = new System.Drawing.Point(12, 27);
            this.cntBook.Name = "cntBook";
            this.cntBook.Size = new System.Drawing.Size(156, 100);
            this.cntBook.TabIndex = 5;
            this.cntBook.TabStop = false;
            this.cntBook.Text = "Book info";
            // 
            // numTotalPages
            // 
            this.numTotalPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTotalPages.Location = new System.Drawing.Point(94, 68);
            this.numTotalPages.Maximum = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.numTotalPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalPages.Name = "numTotalPages";
            this.numTotalPages.Size = new System.Drawing.Size(53, 20);
            this.numTotalPages.TabIndex = 10;
            this.numTotalPages.Value = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(10, 37);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(138, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // chkTotalPages
            // 
            this.chkTotalPages.AutoSize = true;
            this.chkTotalPages.Location = new System.Drawing.Point(10, 68);
            this.chkTotalPages.Name = "chkTotalPages";
            this.chkTotalPages.Size = new System.Drawing.Size(82, 17);
            this.chkTotalPages.TabIndex = 1;
            this.chkTotalPages.Text = "Total pages";
            this.chkTotalPages.UseVisualStyleBackColor = true;
            this.chkTotalPages.CheckedChanged += new System.EventHandler(this.chkTotalPages_CheckedChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "rot";
            this.saveFileDialog.Filter = "RS Reading Organizer Template file (*.rot) | *.rot | All files (*.*) | *.*";
            this.saveFileDialog.Title = "Save RS Reading Organizer template";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "rot";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "RS Reading Organizer Template | *.rot | All files | *.*";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 543);
            this.Controls.Add(this.cntBook);
            this.Controls.Add(this.cntDay);
            this.Controls.Add(this.cntDate);
            this.Controls.Add(this.cntReading);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(366, 582);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RS Reading Organizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.cntReading.ResumeLayout(false);
            this.cntReading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReadDays)).EndInit();
            this.cntDate.ResumeLayout(false);
            this.cntDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProgressPerDay)).EndInit();
            this.cntDay.ResumeLayout(false);
            this.cntDay.PerformLayout();
            this.cntBook.ResumeLayout(false);
            this.cntBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPages)).EndInit();
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
        private System.Windows.Forms.RadioButton radProgressPerDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRestDays;
        private System.Windows.Forms.ToolStripMenuItem menFontSettings;
        private System.Windows.Forms.ToolStripMenuItem menOutputLocation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NumericUpDown numProgressPerDay;
        private System.Windows.Forms.NumericUpDown numTotalPages;
        private System.Windows.Forms.ComboBox cmbProgressType;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

