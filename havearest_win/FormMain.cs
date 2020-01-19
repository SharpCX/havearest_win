using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace havearest_win
{
    public partial class FormMain : Form
    {

        [DllImport("user32 ")]
        public static extern bool LockWorkStation();
        
        private int time_long_init = 30;
        private int time_long = 30;
        private string time_show = "30:00";

        public FormMain()
        {
            InitializeComponent();
            this.reinit(this.loadTimeFromFile());
            timer_release.Start();
            timer_release.Tick += Timer_release_Tick;
        }

        private void Timer_release_Tick(object sender, EventArgs e)
        {
            if (time_long > 0)
            {
                this.time_long--;
                refreshLabel();
            } else {
                LockWorkStation();
                timer_release.Stop();
                this.reinit(this.time_long_init);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void restart() {
            this.timer_release.Start();
        }

        private void reinit(int time_long) {
            this.time_long_init = time_long;
            this.time_long = time_long;
            this.refreshLabel();
        }

        private void refreshLabel()
        {
            int minit_num = this.time_long / 60;
            int second_num = this.time_long % 60;
            this.lab_release.Text = minit_num.ToString("D2") + ":" + second_num.ToString("D2");

        }

        private void txt_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
            if ((e.KeyChar != '.') && ((sender as TextBox).Text.IndexOf('.')>-1))
            {
                e.Handled = true;
            }
        }
        
        private void btn_ok_Click(object sender, EventArgs e)
        {
            int tmp_long_init = int.Parse(this.txt_time.Text);
            if (tmp_long_init < 0 || tmp_long_init>100)
            {
                MessageBox.Show("数字范围1-99");
                return;
            }
            this.reinit(tmp_long_init*60);
            this.writeFile(tmp_long_init*60);
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            this.timer_release.Stop();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.timer_release.Start();
        }

        private void writeFile(int time_long) {
            string text = time_long.ToString();
            string base_path = Environment.CurrentDirectory;
            System.IO.File.WriteAllText(this.getConfigFilePath(), text);
        }

        private int loadTimeFromFile()
        {
            String txt = System.IO.File.ReadAllText(this.getConfigFilePath());
            try
            {
                return int.Parse(txt);
            }
            catch {
                return 30 * 60;
            }
        }

        private string getConfigFilePath() {
            string base_path = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(base_path, "time_config.conf");
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            return path;
        }
    }
}
