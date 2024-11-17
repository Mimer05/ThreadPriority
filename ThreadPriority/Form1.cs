using System;
using System.Threading;
namespace ThreadPriorityTo
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }
        //making 4 threads
        Thread threadA = new Thread(MyThreadClass.Thread1);
        Thread threadB = new Thread(MyThreadClass.Thread1);
        Thread threadC = new Thread(MyThreadClass.Thread2);
        Thread threadD = new Thread(MyThreadClass.Thread2);

        private void frmTrackThread_Load(object sender, EventArgs e)
        {
            //setting priority for each thread
            threadA.Name = "ThreadA";
            threadA.Priority = ThreadPriority.Highest;
            threadB.Name = "ThreadB";
            threadB.Priority = ThreadPriority.Normal;
            threadC.Name = "ThreadC";
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Name = "ThreadD";
            threadD.Priority = ThreadPriority.BelowNormal;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");
            //starting the thread
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            //stopping calling the thread until a thread terminates
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            //it will change the label when the thread ends
            lblThread.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-");
        }
    }
    public class MyThreadClass //this class declare a two static method which are Thread1 and Thread2
    {
        public static void Thread1() //creating method that loop 2 times and has sleep of 0.5 seconds 
        {
            for (int i = 0; i <= 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                Thread.Sleep(500);
            }
        }
        public static void Thread2() //creating method that loop 6 times and has sleep of 1.5 seconds 
        {
            for (int i = 0; i < 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                Thread.Sleep(1500);
            }
        }
    }
}
