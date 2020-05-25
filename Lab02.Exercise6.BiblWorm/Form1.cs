using MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02.Exercise6.BiblWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Author
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Author1
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }

        public string Title
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string Title1
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }

        public string PublishHouse
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public string PublishHouse1
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public int Page
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public int Page1
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }

        public int Year
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }

        public int Year1
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }

        public int InvNumber
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }

        public int InvNumber1
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }

        public bool Existence
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }

        public bool Existence1
        {
            get { return checkBox6.Checked; }
            set { checkBox6.Checked = value; }
        }

       

        public bool ReturnTime
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }

        public bool ReturnTime1
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }


        public bool SortInvNumber
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }

        public bool SortInvNumber1
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }

        public int PeriodUse
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        public int PeriodUse1
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }

        List<Item> its = new List<Item>();
        List<Item> magaz = new List<Item>();


        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);

            if (ReturnTime)
            {
                b.ReturnSrok();
            }

                b.PriceBook(PeriodUse);
                its.Add(b);
                Author = Title = PublishHouse = "";
                Page = InvNumber = PeriodUse = 0;
                Year = 1800;
                Existence = ReturnTime = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
            {
                its.Sort();
            }

                StringBuilder sb = new StringBuilder();
                foreach(Item item in its)
                {
                    sb.Append("\n" + item.ToString());
                    richTextBox1.Text = sb.ToString();
                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Book bMagazine = new Book(Author1, Title1, PublishHouse1, Page1, Year1, InvNumber1, Existence1);

            if (ReturnTime1)
            {
                bMagazine.ReturnSrok();
            }

            bMagazine.PriceBook(PeriodUse1);
            magaz.Add(bMagazine);
            Author1 = Title1 = PublishHouse1 = "";
            Page1 = InvNumber1 = PeriodUse1 = 0;
            Year1 = 1800;
            Existence1 = ReturnTime1 = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SortInvNumber1)
            {
                magaz.Sort();
            }

            StringBuilder sb2 = new StringBuilder();
            foreach (Item item in magaz)
            {
                sb2.Append("\n" + item.ToString());
                richTextBox2.Text = sb2.ToString();
            }
        }
    }
}
