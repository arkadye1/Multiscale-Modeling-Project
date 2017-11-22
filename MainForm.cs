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

      



        private Grid grid;
        private CA ca;

        private List<Brush> brushes;
        private Dictionary<Button, ButtonEvts> stateButtons;
        private Button activeStateButton = null;

        public MainForm()
        {
            this.ca = new CA();

            InitializeComponent();
            this.SetupUI();
            this.SetupBrushes();
            this.SetupGrid();
            this.SetupStateButtons();

   
        }

        private void SetupUI()
        {
            this.caNeighborhoodComboBox.SelectedIndex = 0;

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
            this.stateButtons.Add(this.dpButton, new ButtonEvts { PBClick = SelectGrain, On = SelectGrain_Start_DP, Off = SelectGrain_End } );
            this.stateButtons.Add(this.subButton, new ButtonEvts { PBClick = SelectGrain, On = SelectGrain_Start_SUB, Off = SelectGrain_End });
          //  this.stateButtons.Add(this.OGBound, new ButtonEvts { PBClick = SelectGrain_Bound, On = SelectGrain_Start_DP, Off = SelectGrain_End });
        }

        private void PB_Paint(object sender, PaintEventArgs e)
        {
            // e.Graphics.Clear(Color.White);

            for (int y = 0; y < this.grid.Height; ++y)
            {
                for (int x = 0; x < this.grid.Width; ++x)
                {
                    Cell c = this.grid.GetCell(x, y);

                    if (c.ID != 0)
                    {

                       e.Graphics.FillRectangle((c.Filled) ? Brushes.Magenta : this.brushes[c.ID], x, y, 1, 1);
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

            // Off logic for prevoius button 
            if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].Off != null)
            {
                this.stateButtons[this.activeStateButton].Off();
            }

            // Click in different button
            if (this.activeStateButton != clickedButton)
            {
                this.activeStateButton = clickedButton;
                clickedButton.BackColor = Color.Green;
                clickedButton.ForeColor = SystemColors.HighlightText;

                // On logic
                if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].On != null)
                {
                    this.stateButtons[this.activeStateButton].On();
                }
            }

            // Unclick active button
            else
            {
                this.activeStateButton = null;
            }
        }

        private void AddCircleInclusion(int x, int y)
        {
            // Method from AlgorithmBase
            this.ca.AddCircleInclusion(x, y, this.InclusionRadius);
        }

        private void AddSquareInclusion(int x, int y)
        {
            // Method from AlgorithmBase
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
        private void SelectGrain_Bound(int x, int y)
        {
            this.ca.SelectGrainBoundary(x, y);
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

    }
}
