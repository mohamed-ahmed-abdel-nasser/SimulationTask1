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
    public partial class GraphResult : Form
    {
        public GraphResult()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void PlotData(int users , double[] Time , double[] size)
        {
            DataGridViewRow row;
            for (int i = 0; i < users; ++i)
            {
                row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                row.Cells[0].Value = Time[i].ToString();
                row.Cells[1].Value = size[i].ToString();
                dataGridView1.Rows.Add(row);
            }
        }
        public void PlotChart(int users, double[] Time, double[] size)
        {
            for (int i = 0; i < users; ++i)
            {
                this.chart1.Series["Queue"].Points.AddXY(Time[i], size[i]);
            }
        }
        public void PlotChart(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                this.chart1.Series["Queue"].Points.AddXY(i, arr[i]);
                 
            }
        }
        public void PlotChart(int count, double[] arr)
        {
            for (int i = 0; i < 500; ++i)
            {
                this.chart1.Series["Queue"].Points.AddXY(arr[i], 1);
            }
        }
    }
}
