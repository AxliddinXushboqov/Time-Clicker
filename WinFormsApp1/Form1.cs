using System.Diagnostics;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private long adjustmentMilliseconds = 0;
        private DateTime targetTime;
        private int remainingClicks;
        private int clickInterval;
        private Timer clickTimer;
        private int clickCount;
        private Timer timer;
        private Stopwatch stopwatch;
        private TimeSpan adjustment;
        private DateTime initialServerTime;

        public Form1()
        {
            InitializeComponent();

            clickTimer = new Timer();
            clickTimer.Tick += ClickTimer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hour = int.Parse(textBox1.Text);
            int minute = int.Parse(textBox2.Text);
            int second = int.Parse(textBox3.Text);
            int millisecond = int.Parse(textBox4.Text);

            DateTime currentTimeInUTC5 = DateTime.UtcNow.AddHours(5);

            targetTime = new DateTime(
                currentTimeInUTC5.Year,
                currentTimeInUTC5.Month,
                currentTimeInUTC5.Day,
                hour, minute, second, millisecond
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickTimer.Stop();
            MessageBox.Show("Timer Stoped..!!");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime serverTime = initialServerTime + stopwatch.Elapsed + adjustment;

            if (serverTime.Hour == targetTime.Hour &&
                serverTime.Minute == targetTime.Minute &&
                serverTime.Second == targetTime.Second &&
                serverTime.Millisecond >= targetTime.Millisecond)
            {
                clickCount = int.Parse(textBox5.Text);
                clickInterval = int.Parse(textBox6.Text);
                remainingClicks = clickCount;

                clickTimer.Interval = clickInterval;
                clickTimer.Start();
                label6.Text = "Started!";
            }

            label3.Text = serverTime.ToString("HH:mm:ss.fff");
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            if (remainingClicks > 0)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                remainingClicks--;
            }
            else
            {
                clickTimer.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                adjustmentMilliseconds = long.Parse(textBox7.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Iltimos, to'g'ri raqam kiriting!", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            initialServerTime = DateTime.UtcNow.AddHours(5);
            adjustment = TimeSpan.FromMilliseconds(adjustmentMilliseconds);

            stopwatch = Stopwatch.StartNew();

            timer = new Timer();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }
}