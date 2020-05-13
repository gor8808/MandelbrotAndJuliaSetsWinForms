using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelbrotSetWinForms
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler StartBtnClickedEvent;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItemName = string.Empty;
            if (comboBox1.SelectedItem == null)
            {
                selectedItemName = "Mandelbrot";
            }
            else
            {
                selectedItemName = comboBox1.SelectedItem.ToString();
            }
            StartBtnClickedEvent?.Invoke(selectedItemName, e);
            Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
