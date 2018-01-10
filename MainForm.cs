using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;

namespace grain_growth
{
    public partial class MainForm : Form
    {

        private int GridWidth
        {
            get { return (int)this.gridWidthNumericUpDown.Value; }
        }

        private int GridHeight
        {
            get { return (int)this.gridHeightNumericUpDown.Value; }
        }

        private bool GridPeriodic
        {
            get { return this.gridPeriodicCheckBox.Checked; }
        }

        private int InclusionRadius
        {
            get { return (int)this.inclusionRadiusNumericUpDown.Value; }
        }


        private int CAGrians
        {
            get { return (int)this.caGrainsNumericUpDown.Value; }
        }

        private int MCGrians
        {
            get { return (int)this.numericUpDown1.Value; }
        }

        private int MCSteps
        {
            get { return (int)this.numericUpDown2.Value; }
        }

        private double SrxEnergyValue
        {
            get { return (double)this.srxEnergyUpDown.Value; }
        }

        private int SrxNucleationsAtStart
        {
            get { return (int)this.srxNucleationsAtStartUpDown.Value; }
        }

        private int addEveryStep
        {
            get { return (int)this.aesUpDown.Value; }
        }

        private int SrxAddTimes
        {
            get
            {
                    return (int)this.srxAddTimesUpDown.Value;
               
            }
        }

        private int SrxSteps
        {
            get { return (int)this.srxStepsUpDown.Value; }
        }

        private bool SrxHighlightRecrystalized
        {
            get { return this.srxHighlightRecrystalizedCB.Checked; }
        }

        private bool SrxHighlightEnergy
        {
            get { return this.EnergycheckBox.Checked; }
        }

        private bool HighlightBound
        {
            get { return this.checkBox1.Checked; }
        }



        private Grid grid;
        private CA ca;
        private MC mc;
        private SRX srx;

        private List<Brush> brushes;
        private Dictionary<Button, ButtonEvts> stateButtons;
        private Button activeStateButton = null;

        public MainForm()
        {
            this.ca = new CA();
            this.mc = new MC();
            this.srx = new SRX();

            InitializeComponent();
            this.SetupUI();
            this.SetupBrushes();
            this.SetupGrid();
            this.SetupStateButtons();
        }

        public void SetupUI()
        {
            this.caNeighborhoodComboBox.SelectedIndex = 0;
            this.mcNeighborhoodComboBox.SelectedIndex = 0;
            this.edComboBox.SelectedIndex = 0;
            this.srxNucleationsAdditionsCB.SelectedIndex = 0;
        }

        private void girdProperties_Changed(object sender, EventArgs e)
        {
            this.SetupGrid();
            this.SetupPB();

        }

        private void SetupGrid()
        {
            this.grid = new Grid(this.GridWidth, this.GridHeight, this.GridPeriodic);
            this.ca.Grid = this.grid;
            this.mc.Grid = this.grid;
            this.srx.Grid = this.grid;
            this.SetupPB();
        }

        private void SetupPB()
        {
            this.PB.Width = this.GridWidth;
            this.PB.Height = this.GridHeight;

            this.PB.Refresh();
        }

        private void SetupBrushes()
        {
            this.brushes = new List<Brush>();
            this.brushes.Add(Brushes.Black);

            this.brushes.AddRange(typeof(Brushes).GetProperties().Where(p => p.Name != "Black").Select(p => p.GetValue(null, null) as Brush).OrderBy(p => Rand.Next()));

            this.brushes.Insert(0, Brushes.Black);


        }

        private void SetupStateButtons()
        {
            this.stateButtons = new Dictionary<Button, ButtonEvts>();

            this.stateButtons.Add(this.inclusionCircleButton, new ButtonEvts { PBClick = AddCircleInclusion });
            this.stateButtons.Add(this.inclusionSquareButton, new ButtonEvts { PBClick = AddSquareInclusion });
            this.stateButtons.Add(this.dpButton, new ButtonEvts { PBClick = SelectGrain, On = SelectGrain_Start_DP, Off = SelectGrain_End });
            this.stateButtons.Add(this.subButton, new ButtonEvts { PBClick = SelectGrain, On = SelectGrain_Start_SUB, Off = SelectGrain_End });
           
        }

        private void PB_Paint(object sender, PaintEventArgs e)
        {

            for (int y = 0; y < this.grid.Height; ++y)
            {
                for (int x = 0; x < this.grid.Width; ++x)
                {
                    Cell c = this.grid.GetCell(x, y);

                    if (c.ID != 0)
                    {

                        e.Graphics.FillRectangle((c.Recrystalized && this.SrxHighlightRecrystalized) ? Brushes.Red : this.brushes[c.ID], x, y, 1, 1);
                    }
                    if (c.ID > 1 && c.MoorNeighborhood.Count(i => i.ID != c.ID) > 0)
                    {
                        e.Graphics.FillRectangle((c.Recrystalized && this.SrxHighlightRecrystalized) ? Brushes.Black : this.brushes[c.ID], x, y, 1, 1);
                    }
                    if (c.ID > 1 && c.MoorNeighborhood.Count(i => i.ID != c.ID) > 0) {
                        e.Graphics.FillRectangle((this.HighlightBound) ? Brushes.Black : this.brushes[c.ID], x, y, 1, 1);
                    }


                    if (EnergycheckBox.Checked )
                    {
                        if (c.Energy == (int)this.srxEnergyUpDown.Value && c.Energy > 0 && this.edComboBox.SelectedIndex == 0)
                        {
                            e.Graphics.FillRectangle((this.SrxHighlightEnergy) ? Brushes.Blue : this.brushes[c.ID], x, y, 1, 1);
                        }

                        if (c.ID > 1 && c.MoorNeighborhood.Count(i => i.ID != c.ID) > 0 && c.Energy == (int)this.srxEnergyUpDown.Value && this.edComboBox.SelectedIndex == 1)
                        {
                            e.Graphics.FillRectangle((this.SrxHighlightEnergy) ? Brushes.GreenYellow : this.brushes[c.ID], x, y, 1, 1);

                        }
                        else if (c.Energy < (int)this.srxEnergyUpDown.Value)
                        {
                            e.Graphics.FillRectangle((this.SrxHighlightEnergy) ? Brushes.Blue : this.brushes[c.ID], x, y, 1, 1);
                        }
                         if (c.Energy == 0)
                        {
                            e.Graphics.FillRectangle((this.SrxHighlightEnergy) ? Brushes.Red : this.brushes[c.ID], x, y, 1, 1);
                        }
                    }
                
                }
            }
        }

        //################################################################
        private void PB_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            int x = me.X;
            int y = me.Y;


            if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].PBClick != null)
            {
                this.stateButtons[this.activeStateButton].PBClick(x, y);
                this.PB.Refresh();
            }
        }

        private void stateButton_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.stateButtons.Keys)
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = SystemColors.ControlText;
            }

            Button clickedButton = sender as Button;

            if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].Off != null)
            {
                this.stateButtons[this.activeStateButton].Off();
            }

            if (this.activeStateButton != clickedButton)
            {
                this.activeStateButton = clickedButton;
                clickedButton.BackColor = Color.Green;
                clickedButton.ForeColor = SystemColors.HighlightText;

                if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].On != null)
                {
                    this.stateButtons[this.activeStateButton].On();
                }
            }
            else
            {
                this.activeStateButton = null;
            }
        }

        private void AddCircleInclusion(int x, int y)
        {
         
            this.ca.AddCircleInclusion(x, y, this.InclusionRadius);
        }

        private void AddSquareInclusion(int x, int y)
        {
            this.ca.AddSquareInclusion(x, y, this.InclusionRadius); ;
        }


        private void SelectGrain_Start_DP()
        {
            this.ca.StartSelectGrains(true);
        }

        private void SelectGrain_Start_SUB()
        {
            this.ca.StartSelectGrains(false);
        }

        private void SelectGrain(int x, int y)
        {
            this.ca.SelectGrain(x, y);
            this.PB.Refresh();
        }


        private void SelectGrain_End()
        {
            this.ca.EndSelectGrains();
            this.PB.Refresh();
        }


        //###############################################################

        private void caAddRandomGrainsButton_Click(object sender, EventArgs e)
        {
            this.ca.AddRandomGrains(this.CAGrians);
            this.PB.Refresh();
        }

        private void caSimulateButton_Click(object sender, EventArgs e)
        {
            while (this.ca.Step())
            {
                this.PB.Refresh();
            }
        }


        private void caNeighborhoodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void caGrainsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PB.Image = null;
            this.PB.Invalidate();
            this.SetupGrid();
            this.SetupPB();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void exportBMP_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Save Dialog";
                dlg.Filter = "Bitmap Images (*.bmp)|*.bmp";
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(PB.Width, PB.Height))
                    {
                        PB.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        PB.Image = new Bitmap(PB.Width, PB.Height);

                        bmp.Save(dlg.FileName);
                        MessageBox.Show("Saved Successfully");

                    }
                }
            }
        }

        private void importBMP_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    PB.Image = new Bitmap(dlg.FileName);

                    this.Controls.Add(PB);


                }
            }
        }

        private void exportTXT_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Save Dialog";
                dlg.Filter = "Text File (*.txt)|*.txt";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(dlg.OpenFile());
                    writer.WriteLine(this.GridWidth);
                    writer.WriteLine(this.GridHeight);
                    for (int y = 0; y < this.grid.Height; ++y)
                    {
                        for (int x = 0; x < this.grid.Width; ++x)
                        {
                            writer.WriteLine(this.grid.GetCell(x, y).ID);
                        }
                    }
                    writer.Dispose();
                    writer.Close();
                    MessageBox.Show("Saved Successfully");
                }
            }

        }



        private void ImportTXT_Click(object sender, EventArgs e)
        {
            Graphics g = this.PB.CreateGraphics();
            int i = 0;
            int j = 2;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Import Dialog";
                dlg.Filter = "Text File (*.txt)|*.txt";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(dlg.OpenFile()))
                    {
                        string name = dlg.FileName;

                        while (sr.ReadLine() != null)
                        {
                            i++;
                        }
                        string[] lines = File.ReadAllLines(name);

                        this.PB.Height = Convert.ToInt32(lines[1]);
                        this.PB.Width = Convert.ToInt32(lines[0]);
                        gridHeightNumericUpDown.Value = this.PB.Height;
                        gridWidthNumericUpDown.Value = this.PB.Width;
                        this.SetupPB();




                        for (int y = 0; y < this.PB.Height; ++y)
                        {
                            for (int x = 0; x < this.PB.Width; ++x)
                            {
                                Cell c = this.grid.GetCell(x, y);

                                if (Convert.ToInt32(lines[j]) != 0)
                                {
                                    g.FillRectangle((c.Selected) ? Brushes.Red : this.brushes[Convert.ToInt32(lines[j])], x, y, 1, 1);
                                }
                                j++;
                            }
                        }

                    }
                }

            }
        }

        private void gridPeriodicLabel_Click(object sender, EventArgs e)
        {

        }

        private void mcInitRandomGrainsButton_Click(object sender, EventArgs e)
        {
            this.mc.Init(this.MCGrians);
            this.PB.Refresh();
        }

        private void MCSimulateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MCSteps; ++i)
            {
                this.mc.Step();
                this.PB.Refresh();
            }
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            if (this.edComboBox.SelectedIndex == 0)
            {
              //  this.srx.AddEnergy(this.SrxEnergyValue);

                int nucleationsToAdd = this.SrxNucleationsAtStart;
                int addCount = 0;

                for (int i = 0; i < this.SrxSteps; ++i)
                {
                    if (i % this.addEveryStep == 0 && addCount++ < this.SrxAddTimes) 
                    {
                        this.srx.AddNucleations(nucleationsToAdd);
                        this.PB.Refresh();

                        if (this.srxNucleationsAdditionsCB.SelectedIndex == 2)
                        {
                            nucleationsToAdd += 2; //diff = 2
                        }

                        else if (this.srxNucleationsAdditionsCB.SelectedIndex == 3)
                        {
                            nucleationsToAdd -= 2; //diff=2
                        }
                    }

                    this.srx.Step();
                    this.PB.Refresh();
                }
            }

            else
            {
              //  this.srx.AddEnergyBound(this.SrxEnergyValue);

                int nucleationsToAdd = this.SrxNucleationsAtStart;
                int addCount = 0;

                for (int i = 0; i < this.SrxSteps; ++i)
                {
                    if (i % this.addEveryStep == 0 && addCount++ < this.SrxAddTimes) 
                    {
                        this.srx.AddNucleationsOnBound(nucleationsToAdd);
                        this.PB.Refresh();

                        if (this.srxNucleationsAdditionsCB.SelectedIndex == 2)
                        {
                            nucleationsToAdd += 2; //diff = 2
                            
                        }

                        else if (this.srxNucleationsAdditionsCB.SelectedIndex == 3)
                        {
                            nucleationsToAdd -= 2; //diff=2
                        }
                    }

                    this.srx.Step();
                    this.PB.Refresh();
                }
            }

        }


        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }


        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void srxHighlightRecrystalizedCB_CheckedChanged_1(object sender, EventArgs e)
        {
            this.PB.Refresh();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void EnergycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.PB.Refresh();
        }

        private void addEnergyButton_Click(object sender, EventArgs e)
        {
            if (this.edComboBox.SelectedIndex == 0)
            {
                 this.srx.AddEnergy(this.SrxEnergyValue);
                this.PB.Refresh();

            }
            else {
                this.srx.AddEnergyBound(this.SrxEnergyValue);
                this.PB.Refresh();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
            this.PB.Refresh();
        }
    }
}
