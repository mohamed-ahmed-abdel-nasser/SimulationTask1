using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SimulationValues : Form
    {
        public InterArraival I;
        public Server[] table;
        public int ServersNumber;
        public int UsersNumber;
        public int Percision;
        public int count = 0;
        public SimulationValues()
        {
            InitializeComponent();
        }

        private void SimulationValues_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersNumber = int.Parse(textBox1.Text.ToString());
            Percision = int.Parse(textBox3.Text.ToString());
            MessageBox.Show("Done 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServersNumber = int.Parse(textBox2.Text.ToString());
            table = new Server[ServersNumber];
            MessageBox.Show("Done 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            I = new InterArraival(UsersNumber, Percision);
            DataGridViewRow row;
            for (int i = 0; i < this.dataGridView1.RowCount -1; ++i)
            {
                row = this.dataGridView1.Rows[i];
                I.InsertTime(row.Cells["InterArrivalTime"].Value.ToString());
                I.InsertProbability(row.Cells["Probability"].Value.ToString());
            }
            I.SetCumulative();
            MessageBox.Show("Done 3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            if (count == ServersNumber)
            {
                MessageBox.Show("Done 4");
            }
            else
            {
                table[count] = new Server(UsersNumber, int.Parse(textBox4.Text.ToString()));
                for (int i = 0; i < this.dataGridView2.RowCount -1; ++i)
                {
                    row = dataGridView2.Rows[i];
                    table[count].InsertService(row.Cells["ServiceTime"].Value.ToString());
                    table[count].InsertProbability(row.Cells["Probability2"].Value.ToString());
                }
                for (int j = 0; j < dataGridView2.RowCount; j++)
                {
                    if (dataGridView2.Rows[0].IsNewRow == false)
                        dataGridView2.Rows.RemoveAt(0);
                }
                table[count].SetCumulative();
                ++count;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
