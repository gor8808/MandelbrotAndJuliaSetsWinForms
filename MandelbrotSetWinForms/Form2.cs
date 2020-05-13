using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelbrotSetWinForms
{
    public partial class Form2 : Form
    {
        public List<Color> DefaultColors = new List<Color>();
        public static List<Color> Colors = new List<Color>();
        public event EventHandler<List<Color>> ColorPickedEvent;
        Color noColor;
        public Form2()
        {
            InitializeComponent();
            DefaultColors.Add(Color.Black);
            DefaultColors.Add(Color.Red);
            DefaultColors.Add(Color.Green);
            DefaultColors.Add(Color.PaleGoldenrod);
            DefaultColors.Add(Color.AntiqueWhite);
            DefaultColors.Add(Color.Yellow);
            DefaultColors.Add(Color.White);
            DefaultColors.Add(Color.Purple);
            DefaultColors.Add(Color.YellowGreen);
            DefaultColors.Add(Color.Blue);
            DefaultColors.Add(Color.HotPink);
            noColor = pictureBox1.BackColor;
        }
        private void AddColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            UpdateColor(colorDialog1.Color);
        }

        private void UpdateColor(Color color)
        {
            int changetItemsCount = 0;
            for (int i = 1; i <= 49; i++)
            {
                var matches = Controls.Find("pictureBox" + i, true);
                if (matches[0].BackColor == noColor)
                {
                    changetItemsCount++;
                    matches[0].BackColor = color;
                    break;
                }
            }
            if (changetItemsCount == 0)
            {
                MessageBox.Show("It is full, please delete colors if you want to add new ones");
            }
        }

        private void DeleteColor_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = noColor;
        }

        private void Default_click(object sender, EventArgs e)
        {
            for (int i = 0; i < DefaultColors.Count; i++)
            {
                var matches = Controls.Find("pictureBox" + (i + 1), true);
                matches[0].BackColor = DefaultColors[i];
            }
            for (int i = DefaultColors.Count + 1; i <= 49; i++)
            {
                var matches = Controls.Find("pictureBox" + i, true);
                DeleteColor_Click(matches[0], null);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 49; i++)
            {
                var matches = Controls.Find("pictureBox" + i, true);
                if(matches[0].BackColor != noColor)
                {
                    Colors.Add(matches[0].BackColor);
                }
            }
            if(Colors.Count == 0)
            {
                Colors.Add(Color.Black);
                Colors.Add(Color.White);
            }
            ColorPickedEvent?.Invoke(this, Colors);
            Close();
        }
    }
}
