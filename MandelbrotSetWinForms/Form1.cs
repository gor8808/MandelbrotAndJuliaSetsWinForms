using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelbrotSetWinForms
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        private double _YMax;
        private double _YMin;
        private double _XMax;
        private double _XMin;
        private double _CX;
        private double _CY;
        public static List<Color> ColorsForDrawing = new List<Color>();
        ComplexNumber i = new ComplexNumber();
        const int maxMandelbrotValue = 2;
        public int Deep;

        List<Panel> listPanels = new List<Panel>();
        int index;

        public Form1()
        {
            //ColorsForDrawing.Add(Color.Black);
            //ColorsForDrawing.Add(Color.Red);
            //ColorsForDrawing.Add(Color.Green);
            //ColorsForDrawing.Add(Color.PaleGoldenrod);
            //ColorsForDrawing.Add(Color.AntiqueWhite);
            //ColorsForDrawing.Add(Color.Yellow);
            //ColorsForDrawing.Add(Color.White);
            //ColorsForDrawing.Add(Color.Purple);
            //ColorsForDrawing.Add(Color.YellowGreen);
            //ColorsForDrawing.Add(Color.Blue);
            //ColorsForDrawing.Add(Color.HotPink);
            ColorsForDrawing.Add(Color.FromArgb(1, 1, 1));
            ColorsForDrawing.Add(Color.FromArgb(0, 0, 50));
            ColorsForDrawing.Add(Color.FromArgb(0, 0, 62));
            ColorsForDrawing.Add(Color.FromArgb(0, 0, 71));
            ColorsForDrawing.Add(Color.FromArgb(0, 0, 77));
            ColorsForDrawing.Add(Color.FromArgb(0, 0, 93));
            ColorsForDrawing.Add(Color.FromArgb(0, 0, 105));
            ColorsForDrawing.Add(Color.FromArgb(0, 0, 128));
            ColorsForDrawing.Add(Color.FromArgb(0, 0, 148));
            ColorsForDrawing.Add(Color.FromArgb(0, 0, 168));
            InitializeComponent();
            listPanels.Add(MandelbrotPanel);
            listPanels.Add(JuliaPanel);
            ResetMandelbrot_Click(null, null);
            ResetJulia_Click(null, null);
            Home_Click(null, null);
        }
        #region GeneralBtns
        public void ResetMandelbrot_Click(object sender, EventArgs e)
        {
            RefreshMandelbrotCoordinatesForUI(-2.2, 1.2, -1.2, 1.2, 70);
        }
        private void ShowMadelbrotImage_Click(object sender, EventArgs e)
        {
            RefreshMandelbrotCoordinatesValueFromUI();
            DrawSet(MandelbrotPictureBox, null, null,MandelbrotTimerLabel);

        }
        #endregion
        public void DrawSet(PictureBox pictureBox, double? Cx, double? Cy,Label timer)
        {
            var timer1 = System.Diagnostics.Stopwatch.StartNew();
            image = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = image;
            int imgWidth = pictureBox.Width;
            int imgHeight = pictureBox.Height;
            double xChangeValue = (_XMax - _XMin) / (imgWidth);
            double yChangeValue = (_YMax - _YMin) / (imgHeight);
            double x = _XMin;

            for (int X = 0; X < imgWidth; X++)
            {
                double y = _YMin;
                for (int Y = 0; Y < imgHeight; Y++)
                {
                    int n = 1;
                    //CNumber C = new CNumber(-1.09, 0.252);
                    //CNumber C = new CNumber(-0.8, 0.156);
                    //CNumber C = new CNumber(0.285, 0.01);
                    CNumber C;
                    if (Cx == null || Cy == null)
                    {
                        C = new CNumber(x, y);
                    }
                    else
                    {
                       C = new CNumber((double)Cx, (double)Cy);
                    }
                    ZFunction Z = new ZFunction(new CNumber(x, y));
                    double R = (Math.Sqrt(1 + (4 * Z.Length)) + 1) / 2;
                    while ((n < Deep) && (Z.Length <= R))
                    {
                        Z = Z * Z + C;
                        R = (Math.Sqrt(1 + (4 * Z.Length)) + 1) / 2;
                        n++;
                    }
                    image.SetPixel(X, Y, ColorsForDrawing[n % ColorsForDrawing.Count]);
                    y += yChangeValue;
                }
                x += xChangeValue;
                if (X % 10 == 0)
                {
                    pictureBox.Refresh();
                }
            }
            timer1.Stop();
            timer.Text = $"{(double)timer1.ElapsedMilliseconds / 1000} sec";
        }
        public void RefreshMandelbrotCoordinatesValueFromUI()
        {
            double.TryParse(MandelbrotXMin.Text, out _XMin);
            double.TryParse(MandelbrotXMax.Text, out _XMax);
            double.TryParse(MandelbrotYMin.Text, out _YMin);
            double.TryParse(MandelbrotYMax.Text, out _YMax);
            int.TryParse(MandelbrotIterationsCount.Text, out Deep);
        }
        public void RefreshMandelbrotCoordinatesForUI(double xMin, double xMax, double yMin, double yMax, int deep)
        {
            MandelbrotXMax.Text = xMax.ToString();
            MandelbrotXMin.Text = xMin.ToString();
            MandelbrotYMax.Text = yMax.ToString();
            MandelbrotYMin.Text = yMin.ToString();
            MandelbrotIterationsCount.Text = deep.ToString();
        }
        #region Menu btns
        private void Home_Click(object sender, EventArgs e)
        {
            //splitContainer1.Visible = false;
            UserControl1 userControl = new UserControl1();
            this.Controls.Add(userControl);
            userControl.Visible = true;
            userControl.Dock = DockStyle.Fill;
            menuItem1.Visible = false;
            menuItem2.Visible = false;
            menuItem3.Visible = false;
            menuItem4.Visible = false;
            menuItem12.Visible = false;
            UpdatePanelVizibility();
            FormBorderStyle = FormBorderStyle.None;
            userControl.StartBtnClickedEvent += new EventHandler((pageNameObj, eventArgs) =>
            {
                //splitContainer1.Visible = true;
                string pageName = Convert.ToString(pageNameObj);
                var panel = Controls.Find(pageName + "Panel", true)[0];
                var pictureBox = (PictureBox)Controls.Find(pageName + "PictureBox", true)[0];
                //MessageBox.Show(pageName);
                UpdatePanelVizibility();
                panel.Visible = true;
                menuItem1.Visible = true;
                menuItem2.Visible = true;
                menuItem3.Visible = true;
                menuItem4.Visible = true;
                menuItem12.Visible = true;
                if (pictureBox.Image != null) // Update code 
                {
                    pictureBox.Image = new Bitmap(pictureBox.Image.Width, pictureBox.Image.Height);
                }
                FormBorderStyle = FormBorderStyle.FixedSingle;

            });
        }
        private void SaveImage_Click(object sender, EventArgs e)
        {
            string activePanelName = GetActivePanelName();
            string activePictureBoxName = activePanelName.Replace("Panel", "") + "PictureBox";
            var pictureBox = (PictureBox)(Controls.Find(activePictureBoxName, true)[0]);
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Please press show image button");
                return;
            }
            saveFileDialog1.FileName = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Contains('.'))
                {
                    pictureBox.Image.Save(saveFileDialog1.FileName);
                }
                else
                {
                    pictureBox.Image.Save(saveFileDialog1.FileName + ".png");
                }
            }
        }

        private string GetActivePanelName()
        {
            foreach (var item in listPanels)
            {
                if (item.Visible == true)
                {
                    return item.Name;
                }
            }
            return "Can't find any panel";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Scale_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            string activePanelName = GetActivePanelName().Replace("Panel", "");
            if (menuItem.Text == "Normal")
            {
                _XMax = 1.2;
                _XMin = -2.2;
                _YMax = 1.2;
                _YMin = -1.2;
            }
            else
            {
                int scaleSize = Convert.ToInt32(menuItem.Text.Replace("x", ""));
                if(activePanelName == "Mandelbrot")
                {
                    ResetMandelbrot_Click(null, null);
                }
                else if(activePanelName == "Julia")
                {
                    ResetJulia_Click(null, null);
                }
                //ResetMandelbrot_Click(null, null);
                _XMax /= scaleSize;
                _XMin /= scaleSize;
                _YMax /= scaleSize;
                _YMin /= scaleSize;
            }
            if(activePanelName == "Mandelbrot")
            {
                RefreshMandelbrotCoordinatesForUI(_XMin, _XMax, _YMin, _YMax, Deep);
                Refresh();
                DrawSet(MandelbrotPictureBox, null, null, MandelbrotTimerLabel);
            }
            else if(activePanelName == "Julia")
            {
                RefreshJuliaCoordinatesForUI(_XMin, _XMax, _YMin, _YMax, Deep,_CX,_CY);
                Refresh();
                DrawSet(JuliaPictureBox, _CY, _CY, JuliaTimer);
            }
           

        }
        private void SelectColor_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ColorPickedEvent += new EventHandler<List<Color>>((se, colors) =>
            {
                ColorsForDrawing = colors;
            });
            form2.Show();
        }



        #endregion

        private void SetTypeChange_Click(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            string panelName = item.Text + "Panel";
            var matches = Controls.Find(panelName, true)[0];
            UpdatePanelVizibility();
            matches.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatePanelVizibility();
        }

        private void UpdatePanelVizibility()
        {
            foreach (var item in listPanels)
            {
                item.Visible = false;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            string xString = selectedItem.Substring(selectedItem.IndexOf("X =") + 3, selectedItem.IndexOf(",") - selectedItem.IndexOf("X =") - 3);
            string yString = selectedItem.Substring(selectedItem.IndexOf("Y =") + 3, selectedItem.Length - selectedItem.IndexOf("Y =") - 3);
            JuliaCX.Text = xString;
            JuliaCY.Text = yString;
        }

        private void ResetJulia_Click(object sender, EventArgs e)
        {
            RefreshJuliaCoordinatesForUI(-2.2, 1.2, -1.2, 1.2, 70, -1.09, 0.252);
        }
        public void ShowJuliaImage_Click(object sender, EventArgs e)
        {
            RefreshJulaCoordinatesValueFromUI();
            DrawSet(JuliaPictureBox, _CX, _CY,JuliaTimer);
        }

        private void RefreshJulaCoordinatesValueFromUI()
        {
            double.TryParse(JuliaXMin.Text, out _XMin);
            double.TryParse(JuliaXMax.Text, out _XMax);
            double.TryParse(JuliaYMin.Text, out _YMin);
            double.TryParse(JuliaYMax.Text, out _YMax);
            double.TryParse(JuliaCX.Text, out _CX);
            double.TryParse(JuliaCY.Text, out _CY);
            int.TryParse(JuliaIterationsCount.Text, out Deep);
        }

        private void RefreshJuliaCoordinatesForUI(double xMin, double xMax, double yMin, double yMax, int deep, double cX, double cY)
        {
            JuliaXMin.Text = xMin.ToString();
            JuliaXMax.Text = xMax.ToString();
            JuliaYMin.Text = yMin.ToString();
            JuliaYMax.Text = yMax.ToString();
            JuliaIterationsCount.Text = deep.ToString();
            JuliaCX.Text = cX.ToString();
            JuliaCY.Text = cY.ToString();

        }
    }
}
