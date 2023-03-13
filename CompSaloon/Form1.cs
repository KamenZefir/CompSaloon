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
    public partial class Form1 : Form
    {
        private MakeSupply F2 = new MakeSupply();
        public static int RowCon = 0;
        public static int Summa = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeSupply makeSupply = new MakeSupply();
            RowCon = dataGridViewProduct.RowCount;
            makeSupply.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = dataGridViewProduct.CurrentRow.Index;
            dataGridViewProduct.Rows.Remove(dataGridViewProduct.Rows[a]);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Xschetchik = 0;
            for (int i = 0; i < MakeSupply.RowsMake1-1; i++)
            {
                dataGridViewProduct.Rows.Add();
                dataGridViewProduct[0, i].Value = MakeSupply.Art[i];
                dataGridViewProduct[1, i].Value = MakeSupply.Type1[i];
                dataGridViewProduct[2, i].Value = MakeSupply.Model1[i];
                dataGridViewProduct[3, i].Value = MakeSupply.Manuf[i];
                dataGridViewProduct[5, i].Value = MakeSupply.Amount1[i];

            }
            dataGridViewBuy[0, Xschetchik].Value = MakeSupply.Supplier;
            dataGridViewBuy[1, Xschetchik].Value = MakeSupply.NDoc;
            dataGridViewBuy[2, Xschetchik].Value = MakeSupply.SupDate;
            dataGridViewBuy[3, Xschetchik].Value = MakeSupply.Summ;
            Xschetchik++;


        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewProduct.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            dataGridViewBuy.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Hide();
            dataGridView1.Hide();
            label2.Hide();
            label3.Hide();

            dataGridViewProduct.Size = new Size(776, 318);
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewBuy.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            dataGridViewProduct.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            button7.Hide();
            dataGridView1.Hide();
            label2.Hide();
            label3.Hide();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewBuy.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            dataGridViewProduct.Show();
            dataGridView1.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button7.Show();
            label2.Show();
            label3.Show();

            dataGridViewProduct.Size = new Size(776, 150);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            foreach (DataGridViewRow r in dataGridViewProduct.SelectedRows)
            {
                int index = dataGridView1.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    dataGridView1.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                    
                }
                dataGridView1.Rows[index].Cells[5].Value = 0;
                //    for (int i = 0; i < 5; i++)
                //    {
                //        dataGridView1.Rows[index].Cells[i].Value = dataGridViewProduct.Rows[index].Cells[i].Value;
                //        if (dataGridView1.Rows[index].Cells[5].Value == null)
                //            dataGridView1.Rows[index].Cells[5].Value = 0;
                //    }

                //}


            }



            }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Summa = 0;
                int Col = Convert.ToInt32(dataGridView1.RowCount);
                for (int i = 0; i < Col; i++)
                {
                    Summa += Convert.ToInt32(dataGridView1[4, i].Value) * Convert.ToInt32(dataGridView1[5, i].Value);
                }
            label3.Text = Summa.ToString() + " Руб.";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //int Col = Convert.ToInt32(dataGridViewProduct.RowCount);
            //for (int i = 0; i < Col-1; i++)
            //{
            //    dataGridViewProduct[5, Col].Value = Convert.ToInt32(dataGridViewProduct[5, Col].Value) - 1;
            //}

            MessageBox.Show("Успешная продажа!");
        }
    }
}
