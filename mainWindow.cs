using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace JustAvpn
{
    public partial class mainWindow : Form
    {
        string[] args = Environment.GetCommandLineArgs();

        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated && value)
            {
                base.CreateHandle();
                value = false;
            }
            base.SetVisibleCore(value);
        }
        public string protocol = "undefined";
        string edition = "Home";
        public mainWindow()
        {
            InitializeComponent();
            
            if (File.Exists(@"C:\Program Files\TAP-Windows\driver\tap0901.sys").Equals(false))
            {
                new ToastContentBuilder().AddText("Instalando o driver TAP").AddText("É necessário que o TAP seja instalado usar o JustAvpn").Show();
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"OpenVPN\tap-windows.exe";
                startInfo.Arguments = "/S";
                //startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
            }

            /*RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            rk.SetValue("JustAvpn", Application.ExecutablePath);

            rk.Close();*/

            this.titleLabel.Text = "JustAvpn - " + edition + " Edition";


            this.disconnectedPic.Visible = true;
            this.statusLabel.Location = new System.Drawing.Point(38, 125);
            this.statusLabel.Text = "Desconectado";
            if (args.Contains("\\b") || args.Contains("\\background"))
            {
                SetVisibleCore(false);
                this.trayIcon.Visible = true;
            }
            else
            {
                SetVisibleCore(true);
            }
            //em manutenção
            /*if (args.Contains("\\autoconnect") || args.Contains("\\c"))
            {
                
                this.connectionSwitch.Checked = true;
            }*/

        }

        private bool mouseDown;
        private Point lastLocation;
        private void movePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void movePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void movePanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.trayIcon.Visible = true;
            new ToastContentBuilder()
                .AddText("JustAvpn Service").AddText("JustAvpn continua em execução background")
                .Show();
        }

        private void trayIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.trayIcon.Visible = false;
        }

        private void connectionSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Connect();
        }

        public async Task Connect()
        {
            if (this.connectionSwitch.Checked)
            {
                protocol = File.ReadAllText("protocol.data");
                h = 0;
                m = 0;
                s = 0;
                this.timerConnection.Text = "00:00:00";
                this.statusLabel.Location = new System.Drawing.Point(40, 125);
                this.statusLabel.Text = "Conectando";
                this.disconnectedPic.Visible = false;
                this.connectingPic.Visible = true;
                await Task.Delay(140);
                this.connectionSwitch.Enabled = false;
                //connection
                await Task.Delay(7000);

               // await connection();
                this.connectionSwitch.Enabled = true;
                this.disconnectedPic.Visible = false;
                this.connectingPic.Visible = false;
                this.connectedPic.Visible = true;
                this.statusLabel.Location = new System.Drawing.Point(48, 125);
                this.statusLabel.Text = "Conectado";
                this.timerConnection.Visible = true;
                t.Start();

                new ToastContentBuilder()
                    .AddText("Conectado!")
                    .AddText("Aproveite sua conexão criptografada!")
                    .Show();
            }
            else
            {
                this.statusLabel.Location = new System.Drawing.Point(29, 125);
                this.statusLabel.Text = "Desconectando";
                t.Stop();
                this.timerConnection.Visible = false;
                this.disconnectedPic.Visible = false;
                this.connectedPic.Visible = false;
                this.connectingPic.Visible = true;
                await Task.Delay(140);
                this.connectionSwitch.Enabled = false;
                await Task.Delay(3000);
                this.connectionSwitch.Enabled = true;
                this.disconnectedPic.Visible = true;
                this.connectingPic.Visible = false;
                this.connectedPic.Visible = false;
                this.statusLabel.Location = new System.Drawing.Point(38, 125);
                this.statusLabel.Text = "Desconectado";
                h = 0;
                m = 0;
                s = 0;
                this.timerConnection.Text = "00:00:00";

            }
        }
        
        //VPN Connection
        public async Task connection()
        {
            if (File.Exists(@"C:\Program Files\TAP-Windows\driver\tap0901.sys"))
            {
                if (this.protocol.Equals("tcp"))
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = @"OpenVPN\bin\openvpn.exe";
                    startInfo.Arguments = "--config br3.vpnjantit-tcp-992.ovpn";
                    startInfo.Verb = "runas";
                    process.StartInfo = startInfo;
                    process.Start();


                }
                else if (this.protocol.Equals("udp"))
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = @"OpenVPN\bin\openvpn.exe";
                    startInfo.Arguments = "--config br3.vpnjantit-udp-992.ovpn";
                    startInfo.Verb = "runas";
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
            else
            {
                new ToastContentBuilder().AddText("Instalando o driver TAP").AddText("É necessário que o TAP seja instalado usar o JustAvpn").Show();
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"OpenVPN\tap-windows.exe";
                startInfo.Arguments = "/S";
                //startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
            }
            
        }


        System.Timers.Timer t;
        int h, m, s;

        private void mainWindow_Load(object sender, EventArgs e)
        {


            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeUC uc = new homeUC();
            this.ucPanel.Controls.Clear();
            this.ucPanel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            configUC uc = new configUC();
            this.ucPanel.Controls.Clear();
            this.ucPanel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown
        || e.CloseReason == CloseReason.ApplicationExitCall
        || e.CloseReason == CloseReason.TaskManagerClosing)
            {
                return;
            }
            e.Cancel = true;

            this.Hide();
            this.trayIcon.Visible = true;
            new ToastContentBuilder()
                .AddText("JustAvpn Service").AddText("JustAvpn continua em execução background")
                .Show();
        }

        public void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            string file = File.ReadAllText("count.data");
            int count = Convert.ToInt32(file);

            Invoke(new Action(() =>
            {
                s += 1;

                if (s == 60)
                {
                    s = 0;
                    m += 1;

                }
                if (s == 60)
                {
                    m = 0;
                    h += 1;
                    count += 1;
                    string hour = count.ToString();
                    File.WriteAllText("count.data", hour);

                }
                this.timerConnection.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

            }));


        }
        public int exportAllHours()
        {
            int fileRead = Convert.ToInt32(File.ReadAllText("count.data"));
            return fileRead;
        }
    }
}
