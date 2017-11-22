namespace grain_growth
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PB = new System.Windows.Forms.PictureBox();
            this.gridGroupBox = new System.Windows.Forms.GroupBox();
            this.gridWidthLabel = new System.Windows.Forms.Label();
            this.gridWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridHeightLabel = new System.Windows.Forms.Label();
            this.gridPeriodicLabel = new System.Windows.Forms.Label();
            this.gridPeriodicCheckBox = new System.Windows.Forms.CheckBox();
            this.inclusionsGroupBox = new System.Windows.Forms.GroupBox();
            this.inclusionCircleButton = new System.Windows.Forms.Button();
            this.inclusionSquareButton = new System.Windows.Forms.Button();
            this.inclusionRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inclusionRadiusLabel = new System.Windows.Forms.Label();
            this.caGroupBox = new System.Windows.Forms.GroupBox();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.caNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.caNeighborhoodLabel = new System.Windows.Forms.Label();
            this.caSimulateButton = new System.Windows.Forms.Button();
            this.caAddRandomGrainsButton = new System.Windows.Forms.Button();
            this.caGrainsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caGrainsLabel = new System.Windows.Forms.Label();
            this.srxHighlightRecrystalizedCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.srxAddTimesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.srxSimulateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.srxStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.srxAddEveryStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.srxNucleationsDiffNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.srxNucleationsAtStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.srxNucleationsAdditionsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.srxEnergyValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.srxEnergyDistributionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exportTXT = new System.Windows.Forms.Button();
            this.exportBMP = new System.Windows.Forms.Button();
            this.importBMP = new System.Windows.Forms.Button();
            this.ImportTXT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.subButton = new System.Windows.Forms.Button();
            this.dpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.gridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeightNumericUpDown)).BeginInit();
            this.inclusionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionRadiusNumericUpDown)).BeginInit();
            this.caGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxAddTimesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxAddEveryStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxNucleationsDiffNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxNucleationsAtStartNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxEnergyValueNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.BackColor = System.Drawing.Color.White;
            this.PB.Location = new System.Drawing.Point(12, 11);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(200, 200);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB.TabIndex = 0;
            this.PB.TabStop = false;
            this.PB.Click += new System.EventHandler(this.PB_Click);
            this.PB.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Paint);
            // 
            // gridGroupBox
            // 
            this.gridGroupBox.Controls.Add(this.gridWidthLabel);
            this.gridGroupBox.Controls.Add(this.gridWidthNumericUpDown);
            this.gridGroupBox.Controls.Add(this.gridHeightNumericUpDown);
            this.gridGroupBox.Controls.Add(this.gridHeightLabel);
            this.gridGroupBox.Location = new System.Drawing.Point(636, 11);
            this.gridGroupBox.Name = "gridGroupBox";
            this.gridGroupBox.Size = new System.Drawing.Size(131, 70);
            this.gridGroupBox.TabIndex = 4;
            this.gridGroupBox.TabStop = false;
            // 
            // gridWidthLabel
            // 
            this.gridWidthLabel.AutoSize = true;
            this.gridWidthLabel.Location = new System.Drawing.Point(6, 47);
            this.gridWidthLabel.Name = "gridWidthLabel";
            this.gridWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.gridWidthLabel.TabIndex = 3;
            this.gridWidthLabel.Text = "Width:";
            // 
            // gridWidthNumericUpDown
            // 
            this.gridWidthNumericUpDown.Location = new System.Drawing.Point(60, 45);
            this.gridWidthNumericUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.gridWidthNumericUpDown.Name = "gridWidthNumericUpDown";
            this.gridWidthNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.gridWidthNumericUpDown.TabIndex = 2;
            this.gridWidthNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.gridWidthNumericUpDown.ValueChanged += new System.EventHandler(this.girdProperties_Changed);
            // 
            // gridHeightNumericUpDown
            // 
            this.gridHeightNumericUpDown.Location = new System.Drawing.Point(60, 19);
            this.gridHeightNumericUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.gridHeightNumericUpDown.Name = "gridHeightNumericUpDown";
            this.gridHeightNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.gridHeightNumericUpDown.TabIndex = 1;
            this.gridHeightNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.gridHeightNumericUpDown.ValueChanged += new System.EventHandler(this.girdProperties_Changed);
            // 
            // gridHeightLabel
            // 
            this.gridHeightLabel.AutoSize = true;
            this.gridHeightLabel.Location = new System.Drawing.Point(6, 21);
            this.gridHeightLabel.Name = "gridHeightLabel";
            this.gridHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.gridHeightLabel.TabIndex = 0;
            this.gridHeightLabel.Text = "Height:";
            // 
            // gridPeriodicLabel
            // 
            this.gridPeriodicLabel.AutoSize = true;
            this.gridPeriodicLabel.Location = new System.Drawing.Point(6, 80);
            this.gridPeriodicLabel.Name = "gridPeriodicLabel";
            this.gridPeriodicLabel.Size = new System.Drawing.Size(62, 13);
            this.gridPeriodicLabel.TabIndex = 5;
            this.gridPeriodicLabel.Text = "Periodic BC";
            this.gridPeriodicLabel.Click += new System.EventHandler(this.gridPeriodicLabel_Click);
            // 
            // gridPeriodicCheckBox
            // 
            this.gridPeriodicCheckBox.AutoSize = true;
            this.gridPeriodicCheckBox.Checked = true;
            this.gridPeriodicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridPeriodicCheckBox.Location = new System.Drawing.Point(129, 80);
            this.gridPeriodicCheckBox.Name = "gridPeriodicCheckBox";
            this.gridPeriodicCheckBox.Size = new System.Drawing.Size(15, 14);
            this.gridPeriodicCheckBox.TabIndex = 4;
            this.gridPeriodicCheckBox.UseVisualStyleBackColor = true;
            // 
            // inclusionsGroupBox
            // 
            this.inclusionsGroupBox.Controls.Add(this.inclusionCircleButton);
            this.inclusionsGroupBox.Controls.Add(this.inclusionSquareButton);
            this.inclusionsGroupBox.Controls.Add(this.inclusionRadiusNumericUpDown);
            this.inclusionsGroupBox.Controls.Add(this.inclusionRadiusLabel);
            this.inclusionsGroupBox.Location = new System.Drawing.Point(636, 87);
            this.inclusionsGroupBox.Name = "inclusionsGroupBox";
            this.inclusionsGroupBox.Size = new System.Drawing.Size(131, 81);
            this.inclusionsGroupBox.TabIndex = 5;
            this.inclusionsGroupBox.TabStop = false;
            this.inclusionsGroupBox.Text = "Inclusions";
            // 
            // inclusionCircleButton
            // 
            this.inclusionCircleButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inclusionCircleButton.Location = new System.Drawing.Point(9, 45);
            this.inclusionCircleButton.Name = "inclusionCircleButton";
            this.inclusionCircleButton.Size = new System.Drawing.Size(50, 23);
            this.inclusionCircleButton.TabIndex = 10;
            this.inclusionCircleButton.Text = "Circle";
            this.inclusionCircleButton.UseVisualStyleBackColor = false;
            this.inclusionCircleButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // inclusionSquareButton
            // 
            this.inclusionSquareButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inclusionSquareButton.Location = new System.Drawing.Point(70, 45);
            this.inclusionSquareButton.Name = "inclusionSquareButton";
            this.inclusionSquareButton.Size = new System.Drawing.Size(50, 23);
            this.inclusionSquareButton.TabIndex = 9;
            this.inclusionSquareButton.Text = "Square";
            this.inclusionSquareButton.UseVisualStyleBackColor = false;
            this.inclusionSquareButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // inclusionRadiusNumericUpDown
            // 
            this.inclusionRadiusNumericUpDown.Location = new System.Drawing.Point(71, 19);
            this.inclusionRadiusNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.inclusionRadiusNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inclusionRadiusNumericUpDown.Name = "inclusionRadiusNumericUpDown";
            this.inclusionRadiusNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.inclusionRadiusNumericUpDown.TabIndex = 8;
            this.inclusionRadiusNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // inclusionRadiusLabel
            // 
            this.inclusionRadiusLabel.AutoSize = true;
            this.inclusionRadiusLabel.Location = new System.Drawing.Point(6, 21);
            this.inclusionRadiusLabel.Name = "inclusionRadiusLabel";
            this.inclusionRadiusLabel.Size = new System.Drawing.Size(56, 13);
            this.inclusionRadiusLabel.TabIndex = 0;
            this.inclusionRadiusLabel.Text = "Rad/Side:";
            // 
            // caGroupBox
            // 
            this.caGroupBox.Controls.Add(this.Resetbtn);
            this.caGroupBox.Controls.Add(this.caNeighborhoodComboBox);
            this.caGroupBox.Controls.Add(this.caNeighborhoodLabel);
            this.caGroupBox.Controls.Add(this.gridPeriodicCheckBox);
            this.caGroupBox.Controls.Add(this.gridPeriodicLabel);
            this.caGroupBox.Controls.Add(this.caSimulateButton);
            this.caGroupBox.Controls.Add(this.caAddRandomGrainsButton);
            this.caGroupBox.Controls.Add(this.caGrainsNumericUpDown);
            this.caGroupBox.Controls.Add(this.caGrainsLabel);
            this.caGroupBox.Location = new System.Drawing.Point(441, 11);
            this.caGroupBox.Name = "caGroupBox";
            this.caGroupBox.Size = new System.Drawing.Size(189, 130);
            this.caGroupBox.TabIndex = 6;
            this.caGroupBox.TabStop = false;
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Resetbtn.Location = new System.Drawing.Point(98, 100);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(83, 23);
            this.Resetbtn.TabIndex = 6;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // caNeighborhoodComboBox
            // 
            this.caNeighborhoodComboBox.FormattingEnabled = true;
            this.caNeighborhoodComboBox.Items.AddRange(new object[] {
            "Moore",
            "Von Neumann"});
            this.caNeighborhoodComboBox.Location = new System.Drawing.Point(98, 48);
            this.caNeighborhoodComboBox.Name = "caNeighborhoodComboBox";
            this.caNeighborhoodComboBox.Size = new System.Drawing.Size(83, 21);
            this.caNeighborhoodComboBox.TabIndex = 5;
            this.caNeighborhoodComboBox.SelectedIndexChanged += new System.EventHandler(this.caNeighborhoodComboBox_SelectedIndexChanged);
            // 
            // caNeighborhoodLabel
            // 
            this.caNeighborhoodLabel.AutoSize = true;
            this.caNeighborhoodLabel.Location = new System.Drawing.Point(6, 51);
            this.caNeighborhoodLabel.Name = "caNeighborhoodLabel";
            this.caNeighborhoodLabel.Size = new System.Drawing.Size(77, 13);
            this.caNeighborhoodLabel.TabIndex = 4;
            this.caNeighborhoodLabel.Text = "Neighborhood:";
            // 
            // caSimulateButton
            // 
            this.caSimulateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.caSimulateButton.Location = new System.Drawing.Point(9, 100);
            this.caSimulateButton.Name = "caSimulateButton";
            this.caSimulateButton.Size = new System.Drawing.Size(83, 23);
            this.caSimulateButton.TabIndex = 3;
            this.caSimulateButton.Text = "Simulate";
            this.caSimulateButton.UseVisualStyleBackColor = false;
            this.caSimulateButton.Click += new System.EventHandler(this.caSimulateButton_Click);
            // 
            // caAddRandomGrainsButton
            // 
            this.caAddRandomGrainsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.caAddRandomGrainsButton.Location = new System.Drawing.Point(98, 17);
            this.caAddRandomGrainsButton.Name = "caAddRandomGrainsButton";
            this.caAddRandomGrainsButton.Size = new System.Drawing.Size(83, 23);
            this.caAddRandomGrainsButton.TabIndex = 2;
            this.caAddRandomGrainsButton.Text = "Add";
            this.caAddRandomGrainsButton.UseVisualStyleBackColor = false;
            this.caAddRandomGrainsButton.Click += new System.EventHandler(this.caAddRandomGrainsButton_Click);
            // 
            // caGrainsNumericUpDown
            // 
            this.caGrainsNumericUpDown.Location = new System.Drawing.Point(52, 20);
            this.caGrainsNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.caGrainsNumericUpDown.Name = "caGrainsNumericUpDown";
            this.caGrainsNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.caGrainsNumericUpDown.TabIndex = 1;
            this.caGrainsNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.caGrainsNumericUpDown.ValueChanged += new System.EventHandler(this.caGrainsNumericUpDown_ValueChanged);
            // 
            // caGrainsLabel
            // 
            this.caGrainsLabel.AutoSize = true;
            this.caGrainsLabel.Location = new System.Drawing.Point(6, 22);
            this.caGrainsLabel.Name = "caGrainsLabel";
            this.caGrainsLabel.Size = new System.Drawing.Size(40, 13);
            this.caGrainsLabel.TabIndex = 0;
            this.caGrainsLabel.Text = "Grains:";
            // 
            // srxHighlightRecrystalizedCheckBox
            // 
            this.srxHighlightRecrystalizedCheckBox.Location = new System.Drawing.Point(0, 0);
            this.srxHighlightRecrystalizedCheckBox.Name = "srxHighlightRecrystalizedCheckBox";
            this.srxHighlightRecrystalizedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.srxHighlightRecrystalizedCheckBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            // 
            // srxAddTimesNumericUpDown
            // 
            this.srxAddTimesNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.srxAddTimesNumericUpDown.Name = "srxAddTimesNumericUpDown";
            this.srxAddTimesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxAddTimesNumericUpDown.TabIndex = 0;
            // 
            // srxSimulateButton
            // 
            this.srxSimulateButton.Location = new System.Drawing.Point(0, 0);
            this.srxSimulateButton.Name = "srxSimulateButton";
            this.srxSimulateButton.Size = new System.Drawing.Size(75, 23);
            this.srxSimulateButton.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // srxStepsNumericUpDown
            // 
            this.srxStepsNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.srxStepsNumericUpDown.Name = "srxStepsNumericUpDown";
            this.srxStepsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxStepsNumericUpDown.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // srxAddEveryStepsNumericUpDown
            // 
            this.srxAddEveryStepsNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.srxAddEveryStepsNumericUpDown.Name = "srxAddEveryStepsNumericUpDown";
            this.srxAddEveryStepsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxAddEveryStepsNumericUpDown.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // srxNucleationsDiffNumericUpDown
            // 
            this.srxNucleationsDiffNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.srxNucleationsDiffNumericUpDown.Name = "srxNucleationsDiffNumericUpDown";
            this.srxNucleationsDiffNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxNucleationsDiffNumericUpDown.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // srxNucleationsAtStartNumericUpDown
            // 
            this.srxNucleationsAtStartNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.srxNucleationsAtStartNumericUpDown.Name = "srxNucleationsAtStartNumericUpDown";
            this.srxNucleationsAtStartNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxNucleationsAtStartNumericUpDown.TabIndex = 0;
            // 
            // srxNucleationsAdditionsComboBox
            // 
            this.srxNucleationsAdditionsComboBox.Location = new System.Drawing.Point(0, 0);
            this.srxNucleationsAdditionsComboBox.Name = "srxNucleationsAdditionsComboBox";
            this.srxNucleationsAdditionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.srxNucleationsAdditionsComboBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // srxEnergyValueNumericUpDown
            // 
            this.srxEnergyValueNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.srxEnergyValueNumericUpDown.Name = "srxEnergyValueNumericUpDown";
            this.srxEnergyValueNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.srxEnergyValueNumericUpDown.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // srxEnergyDistributionComboBox
            // 
            this.srxEnergyDistributionComboBox.Location = new System.Drawing.Point(0, 0);
            this.srxEnergyDistributionComboBox.Name = "srxEnergyDistributionComboBox";
            this.srxEnergyDistributionComboBox.Size = new System.Drawing.Size(121, 21);
            this.srxEnergyDistributionComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exportTXT);
            this.groupBox1.Controls.Add(this.exportBMP);
            this.groupBox1.Location = new System.Drawing.Point(636, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 46);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // exportTXT
            // 
            this.exportTXT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exportTXT.Location = new System.Drawing.Point(71, 17);
            this.exportTXT.Name = "exportTXT";
            this.exportTXT.Size = new System.Drawing.Size(50, 23);
            this.exportTXT.TabIndex = 1;
            this.exportTXT.Text = "TXT";
            this.exportTXT.UseVisualStyleBackColor = false;
            this.exportTXT.Click += new System.EventHandler(this.exportTXT_Click);
            // 
            // exportBMP
            // 
            this.exportBMP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exportBMP.Location = new System.Drawing.Point(10, 17);
            this.exportBMP.Name = "exportBMP";
            this.exportBMP.Size = new System.Drawing.Size(50, 23);
            this.exportBMP.TabIndex = 0;
            this.exportBMP.Text = "BMP";
            this.exportBMP.UseVisualStyleBackColor = false;
            this.exportBMP.Click += new System.EventHandler(this.exportBMP_Click);
            // 
            // importBMP
            // 
            this.importBMP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.importBMP.Location = new System.Drawing.Point(9, 14);
            this.importBMP.Name = "importBMP";
            this.importBMP.Size = new System.Drawing.Size(50, 23);
            this.importBMP.TabIndex = 2;
            this.importBMP.Text = "BMP";
            this.importBMP.UseVisualStyleBackColor = false;
            this.importBMP.Click += new System.EventHandler(this.importBMP_Click);
            // 
            // ImportTXT
            // 
            this.ImportTXT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImportTXT.Location = new System.Drawing.Point(70, 14);
            this.ImportTXT.Name = "ImportTXT";
            this.ImportTXT.Size = new System.Drawing.Size(50, 23);
            this.ImportTXT.TabIndex = 3;
            this.ImportTXT.Text = "TXT";
            this.ImportTXT.UseVisualStyleBackColor = false;
            this.ImportTXT.Click += new System.EventHandler(this.ImportTXT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.importBMP);
            this.groupBox2.Controls.Add(this.ImportTXT);
            this.groupBox2.Location = new System.Drawing.Point(636, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 43);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.subButton);
            this.groupBox3.Controls.Add(this.dpButton);
            this.groupBox3.Location = new System.Drawing.Point(636, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 79);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CA -> CA";
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(27, 19);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 1;
            this.subButton.Text = "Substructure";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // dpButton
            // 
            this.dpButton.Location = new System.Drawing.Point(27, 48);
            this.dpButton.Name = "dpButton";
            this.dpButton.Size = new System.Drawing.Size(75, 23);
            this.dpButton.TabIndex = 0;
            this.dpButton.Text = "Dual phase";
            this.dpButton.UseVisualStyleBackColor = true;
            this.dpButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(779, 455);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.caGroupBox);
            this.Controls.Add(this.inclusionsGroupBox);
            this.Controls.Add(this.gridGroupBox);
            this.Controls.Add(this.PB);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.gridGroupBox.ResumeLayout(false);
            this.gridGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeightNumericUpDown)).EndInit();
            this.inclusionsGroupBox.ResumeLayout(false);
            this.inclusionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionRadiusNumericUpDown)).EndInit();
            this.caGroupBox.ResumeLayout(false);
            this.caGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxAddTimesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxAddEveryStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxNucleationsDiffNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxNucleationsAtStartNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srxEnergyValueNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gridGroupBox;
        private System.Windows.Forms.Label gridWidthLabel;
        private System.Windows.Forms.NumericUpDown gridWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown gridHeightNumericUpDown;
        private System.Windows.Forms.Label gridHeightLabel;
        private System.Windows.Forms.Label gridPeriodicLabel;
        private System.Windows.Forms.CheckBox gridPeriodicCheckBox;
        private System.Windows.Forms.GroupBox inclusionsGroupBox;
        private System.Windows.Forms.Button inclusionCircleButton;
        private System.Windows.Forms.Button inclusionSquareButton;
        private System.Windows.Forms.NumericUpDown inclusionRadiusNumericUpDown;
        private System.Windows.Forms.Label inclusionRadiusLabel;
        private System.Windows.Forms.GroupBox caGroupBox;
        private System.Windows.Forms.Button caAddRandomGrainsButton;
        private System.Windows.Forms.NumericUpDown caGrainsNumericUpDown;
        private System.Windows.Forms.Label caGrainsLabel;
        private System.Windows.Forms.Button caSimulateButton;
        private System.Windows.Forms.ComboBox caNeighborhoodComboBox;
        private System.Windows.Forms.Label caNeighborhoodLabel;
        private System.Windows.Forms.ComboBox srxEnergyDistributionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox srxNucleationsAdditionsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown srxEnergyValueNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown srxStepsNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown srxAddEveryStepsNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown srxNucleationsDiffNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown srxNucleationsAtStartNumericUpDown;
        private System.Windows.Forms.Button srxSimulateButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown srxAddTimesNumericUpDown;
        private System.Windows.Forms.CheckBox srxHighlightRecrystalizedCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exportTXT;
        private System.Windows.Forms.Button exportBMP;
        private System.Windows.Forms.Button importBMP;
        private System.Windows.Forms.Button ImportTXT;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dpButton;
        private System.Windows.Forms.Button subButton;
    }
}

