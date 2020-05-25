using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5.Task2.UsingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath romb = new System.Drawing.Drawing2D.GraphicsPath();
            romb.AddPolygon(new Point[] { new Point(50, 500), 
                            new Point(550, 100), 
                            new Point(1100, 500), 
                            new Point(550, 900)  });
            Region myRegion = new Region(romb);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
           
            this.Close();

        }
    }
}
