using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrMenuload : Form
    {
        public FrMenuload()
        {
            InitializeComponent();
            label1.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrMenuload_Paint(object sender, PaintEventArgs e)
        {
           
        }
        int x;
        private void timeLoad_Tick_1(object sender, EventArgs e)
        {
            x = label2.Location.X;
            x--;
            label2.Location= new Point(x, label2.Location.Y);
            if (x == 0)
            {
                FrMenuload f = new FrMenuload();
                x = f.Size.Width;
                label2.Location = new Point(f.Size.Width, label2.Location.Y);
            }
        }
    }

}
