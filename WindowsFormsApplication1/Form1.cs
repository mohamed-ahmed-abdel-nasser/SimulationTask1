using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public SimulationValues S = new SimulationValues();
        public ArrayList Arrive = new ArrayList();
        public ArrayList Timebegin = new ArrayList();
        public ArrayList Timeends = new ArrayList();
        public ArrayList Queue = new ArrayList();
        public QueueSize Q ;
        public TotalDelay T = new TotalDelay();
        public GraphResult G1 = new GraphResult();
        public GraphResult G2 = new GraphResult();
        public GraphResult G3 = new GraphResult();
        public SelectedServer server;
        public BusyServer[] Busy;

        public Form1()
        {
            InitializeComponent();
        }

        private void SetValues_Click(object sender, EventArgs e)
        {
            S.Show();
        }

        private void Simulate_Click(object sender, EventArgs e)
        {
            Busy = new BusyServer[S.ServersNumber];
            for (int i = 0; i < S.ServersNumber; ++i)
            {
                Busy[i] = new BusyServer();
            }
            Random r = new Random();
            double number;
            double percision = S.table[0].precision;
            Q = new QueueSize(S.UsersNumber);
            double timeBegin;
            double ServiceEnd;
            int Index;
            double Arrival;
            server = new SelectedServer(S.ServersNumber);
            number = r.Next() % percision;
            S.I.SetRandoms(S.UsersNumber * 100);
            DataGridViewRow row;
            row = (DataGridViewRow)SimulationTable.Rows[0].Clone();
            row.Cells[0].Value = "1";
            row.Cells[1].Value = S.I.Rand[0];
            row.Cells[2].Value = "0";
            row.Cells[3].Value = "1";
            row.Cells[4].Value = "0";
            row.Cells[5].Value = S.table[0].FindService(number).ToString();
            row.Cells[7].Value = "0";
            Arrive.Add(0);
            row.Cells[6].Value = (Convert.ToDouble(Arrive[0]) + S.table[0].FindService(number)).ToString();
            server.future_End(0, S.table[0].FindService(number));
            Busy[0].Set_Busy(0);
            Timebegin.Add(0);
            SimulationTable.Rows.Add(row);

            for (int i = 1; i < S.UsersNumber; ++i)
            {
                Index = server.Select_server();
                number = r.Next() % percision;
                row = (DataGridViewRow)SimulationTable.Rows[i].Clone();
                row.Cells[0].Value = (i+1).ToString();
                row.Cells[1].Value = S.I.Rand[i];
                Arrival = Convert.ToDouble(S.I.Rand[i]) + Convert.ToDouble(Arrive[i - 1]);
                Arrive.Add(Arrival);
                row.Cells[2].Value = Arrival.ToString();
                row.Cells[3].Value = (Index + 1).ToString();
                timeBegin = (Arrival > server.arr[Index]) ? Arrival : server.arr[Index];
                ServiceEnd = timeBegin + S.table[Index].FindService(number);
                row.Cells[4].Value = timeBegin.ToString();
                row.Cells[5].Value = S.table[Index].FindService(number);
                row.Cells[6].Value = ServiceEnd.ToString();
                row.Cells[7].Value = (timeBegin - Arrival).ToString();
                T.Set_Delay((int)(timeBegin - Arrival));
                Timebegin.Add(timeBegin);
                Timeends.Add(ServiceEnd);
                server.future_End(Index, ServiceEnd);
                Busy[Index].Set_Busy(timeBegin);

                if (Arrival < server.max)
                {
                    Queue.Add(1);
                    Q.Set_Size(Arrival, 1);
                }
                else
                {
                    Queue.Clear();
                    Q.Set_Size(Arrival, 1);
                }
                SimulationTable.Rows.Add(row);
            }
        }

        private void Graph1_Click(object sender, EventArgs e)
        {
            G1.Show();
            G1.PlotData(S.UsersNumber, Q.Time, Q.Size);
            G1.PlotChart(S.UsersNumber, Q.Time, Q.Size);
        }

        private void Graph2_Click(object sender, EventArgs e)
        {
            G2.Show();
            G2.PlotChart(T.groups);
        }

        private void Graph3_Click(object sender, EventArgs e)
        {
            G3.Show();
            for (int i = 0; i < S.ServersNumber; ++i)
            {
                G3.PlotChart(Busy[i].Count, Busy[i].Busy);
                MessageBox.Show(i.ToString() + " Done ");
            }
        }

    }
}
