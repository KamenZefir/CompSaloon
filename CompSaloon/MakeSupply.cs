using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompSaloon
{
    public partial class MakeSupply : Form
    {
        public static string[] Art = new string[100];
        public static string[] Type1 = new string[100];
        public static string[] Model1 = new string[100];
        public static string[] Manuf = new string[100];
        public static string[] Amount1 = new string[100];
        public static int RowsMake1;
        public static string NDoc;
        public static string Supplier;
        public static DateTime SupDate;
        public static int Summ = 0;
        private Form1 Form1Instance { get; set; }
        public MakeSupply()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Supplier = textBox1.Text;
            NDoc = textBox2.Text;
            SupDate = dateTimePicker1.Value.Date;

            int RowsMake = dataGridView1.RowCount;
            RowsMake1 = RowsMake;


            for (int i = 0; i < RowsMake-1; i++)
            {
                Art[i] = dataGridView1[0, i].Value.ToString();
                Type1[i] = dataGridView1[1, i].Value.ToString();
                Model1[i] = dataGridView1[2, i].Value.ToString();
                Manuf[i] = dataGridView1[3, i].Value.ToString();
                Amount1[i] = dataGridView1[5, i].Value.ToString();

                Summ += Convert.ToInt32(dataGridView1[4, i].Value) * Convert.ToInt32(dataGridView1[5, i].Value);
            }
            label5.Text = Summ.ToString() + "Руб.";

            this.Close();
        }
    }
}
