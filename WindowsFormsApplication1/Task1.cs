using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace WindowsFormsApplication1
{
    public class Server
    {
        public int precision;
        public int users;
        public ArrayList ServiceTime = new ArrayList();
        public ArrayList Probability = new ArrayList();
        public ArrayList Cumulative = new ArrayList();
        public ArrayList Rand = new ArrayList();

        public Server()
        { }
        public Server(int user , int Percision)
        {
            users = user;
            precision = (int)Math.Pow(10, Percision);
        }
        public void InsertService(string s)
        {
            ServiceTime.Add(s);
        }
        public void InsertProbability(string s)
        {
            Probability.Add(Convert.ToDouble(s));
        }
        public void SetCumulative()
        {
            double sum = 0;
            for (int i = 0; i < Probability.Count; ++i)
            {
                sum += Convert.ToDouble(Probability[i]);
                Cumulative.Add(sum);
            }
        }
        public void SetRandoms(int range)
        {
            Random r = new Random(range);
            double n;
            for (int i = 0; i < users; ++i)
            {
                n = r.Next() % precision;
                for (int j = 0; j < Cumulative.Count; ++j)
                {
                    if (n <= Convert.ToDouble(Cumulative[i]) * precision)
                        Rand.Add(ServiceTime[i]);
                }
            }
        }
        public double FindService(double r)
        {
            for (int i = 0; i < Cumulative.Count; ++i)
            {
                if (r <= Convert.ToDouble(Cumulative[i]) * precision)
                    return Convert.ToDouble(ServiceTime[i]);
            }
            return 0;
        }
    }
    public class InterArraival
    {
        public int users;
        public int precision;
        public ArrayList InterArrivalTime = new ArrayList();
        public ArrayList Probability = new ArrayList();
        public ArrayList Cumulative = new ArrayList();
        public ArrayList Rand = new ArrayList();
        public ArrayList RandomNumbers = new ArrayList();
        public InterArraival() { }
        public InterArraival(int user, int Percision)
        {
            users = user;
            precision =(int) Math.Pow(10,Percision);
        }
        public void InsertTime(string s)
        {
            InterArrivalTime.Add(s);
        }
        public void InsertProbability(string s)
        {
            Probability.Add(Convert.ToDouble(s));
        }
        public void SetCumulative()
        {
            double sum = 0;
            for (int i = 0; i < Probability.Count; ++i)
            {
                sum += Convert.ToDouble(Probability[i]);
                Cumulative.Add(sum);
            }
        }
        public void SetRandoms(int range)
        {
            Random r = new Random(range);
            double n;
            for (int i = 0; i < users; ++i)
            {
                n = r.Next() % precision;
                RandomNumbers.Add(n);
                for (int j = 0; j < Cumulative.Count; ++j)
                {
                    if (n <= Convert.ToDouble(Cumulative[j]) * precision)
                        Rand.Add(InterArrivalTime[j]);
                }
            }

        }
    }
    public class BusyServer
    {
        public int Count = 0;
        public double[] Busy = new double[500];
        public double[] end = new double[500];
        public BusyServer()
        {

        }
        public void Set_Busy(double Time , double e)
        {
            Busy[Count] = Time;
            end[Count] = e;
            Count++;
        }
        public int idle()
        {
            int sum = 0;
            for (int i = 1; i < Count; ++i)
            {
                sum +=(int) (Busy[i] - end[i - 1]);
            }
            return sum;
        }
    }
    public class SelectedServer
    {
        public double max = 0;
        public double[] arr;
        public int number;
        public int maxind = 0;
        public SelectedServer()
        { }
        public SelectedServer(int numofServer)
        {
            arr = new double[numofServer];
            number = numofServer;
            for (int j = 0; j < numofServer; j++)
            {
                arr[j] = 0;
            }
        }
        public int Heighest_Priority(double value)
        {
            for (int i = 0; i < number; ++i )
                if (arr[i] <= value)
                    return i;
            return -1;
        }
        public int Select_server()
        {
            double Max = double.MaxValue;
            for (int j = 0; j < number; j++)
            {
                if (arr[j] < Max)
                {
                    Max = arr[j];
                    maxind = j;
                }
            }
            max = Max;
            return maxind;
        }
        public void future_End(int index, double ServiceDuaration)
        {
            arr[index] = ServiceDuaration;
        }
    }
    public class TotalDelay
    {
        public int[] groups = new int[100];
        public TotalDelay()
        {
            for (int j = 0; j < 100; j++)
            {
                groups[j] = 0;
            }
        }
        public int numberOfWaiters(int users)
        {
            int count = 0;
            for (int i = 0; i < users; ++i)
            {
                if (groups[i] > 0)
                    count++;
            }
            return count;
        }
        
        public void Set_Delay(int Duration)
        {
            groups[Duration]++;
        }
    }
    public class QueueSize
    {
        public double[] Time;
        public double[] Size;
        public int Count = 0;

        public QueueSize(int nUser)
        {
            Time = new double[nUser];
            Size = new double[nUser];
        }
        public void Set_Size(double time, double size)
        {
            Time[Count] = time;
            Size[Count] = size;
            Count++;
        }

    }
}
