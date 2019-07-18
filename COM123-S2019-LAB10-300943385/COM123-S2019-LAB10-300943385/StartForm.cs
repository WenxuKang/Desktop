using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM123_S2019_LAB10_300943385
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private Timer time;
        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
            time = new Timer();
            time.Interval = 3 * 1000;
            time.Tick += new EventHandler(SplashTimer_Tick);
            time.Start();
                


        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            time.Stop();
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
