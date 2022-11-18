namespace JustAvpn
{
    partial class mainWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.mainElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ucPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lateralPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.timerConnection = new System.Windows.Forms.Label();
            this.connectingPic = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.connectionSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.statusLabel = new System.Windows.Forms.Label();
            this.disconnectedPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.connectedPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.movePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.exitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.ucPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.lateralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectedPic)).BeginInit();
            this.movePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // mainElipse
            // 
            this.mainElipse.TargetControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.ucPanel);
            this.mainPanel.Controls.Add(this.lateralPanel);
            this.mainPanel.Controls.Add(this.movePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.mainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(910, 543);
            this.mainPanel.TabIndex = 0;
            // 
            // ucPanel
            // 
            this.ucPanel.Controls.Add(this.label10);
            this.ucPanel.Controls.Add(this.label7);
            this.ucPanel.Controls.Add(this.label8);
            this.ucPanel.Controls.Add(this.label9);
            this.ucPanel.Controls.Add(this.guna2PictureBox3);
            this.ucPanel.Controls.Add(this.label4);
            this.ucPanel.Controls.Add(this.label5);
            this.ucPanel.Controls.Add(this.label6);
            this.ucPanel.Controls.Add(this.guna2PictureBox2);
            this.ucPanel.Controls.Add(this.label3);
            this.ucPanel.Controls.Add(this.label2);
            this.ucPanel.Controls.Add(this.label1);
            this.ucPanel.Controls.Add(this.guna2PictureBox1);
            this.ucPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel.Location = new System.Drawing.Point(186, 35);
            this.ucPanel.Name = "ucPanel";
            this.ucPanel.ShadowDecoration.Parent = this.ucPanel;
            this.ucPanel.Size = new System.Drawing.Size(724, 508);
            this.ucPanel.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(125, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(473, 43);
            this.label10.TabIndex = 24;
            this.label10.Text = "Benefícios de usar a JustAvpn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(331, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "A JustAvpn contém protocolos OpenVPN. Seguro, rápido e confiável";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(380, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Quem disse que a pressa é inimiga da perfeição?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 16F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(356, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 30);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sem comprometer a velocidade";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::JustAvpn.Properties.Resources.icons8_wi_fi_router_1024px;
            this.guna2PictureBox3.Location = new System.Drawing.Point(466, 232);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(87, 78);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 20;
            this.guna2PictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "e de ninguém mais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Seus segredos continuam sendo seus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 16F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Criptografia de Ponta";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::JustAvpn.Properties.Resources.lock_1024px;
            this.guna2PictureBox2.Location = new System.Drawing.Point(133, 313);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(87, 78);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 16;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "conforto e segurança que você merece";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Para você poder navegar na internet com todo o";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cuida da sua identidade digital";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::JustAvpn.Properties.Resources.icons8_fingerprint_1024px;
            this.guna2PictureBox1.Location = new System.Drawing.Point(187, 116);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(87, 78);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lateralPanel
            // 
            this.lateralPanel.Controls.Add(this.guna2Button1);
            this.lateralPanel.Controls.Add(this.homeBtn);
            this.lateralPanel.Controls.Add(this.timerConnection);
            this.lateralPanel.Controls.Add(this.connectingPic);
            this.lateralPanel.Controls.Add(this.connectionSwitch);
            this.lateralPanel.Controls.Add(this.statusLabel);
            this.lateralPanel.Controls.Add(this.disconnectedPic);
            this.lateralPanel.Controls.Add(this.connectedPic);
            this.lateralPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lateralPanel.Location = new System.Drawing.Point(0, 35);
            this.lateralPanel.Name = "lateralPanel";
            this.lateralPanel.ShadowDecoration.Parent = this.lateralPanel;
            this.lateralPanel.Size = new System.Drawing.Size(186, 508);
            this.lateralPanel.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(0, 311);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(186, 66);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Configurações";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Animated = true;
            this.homeBtn.CheckedState.Parent = this.homeBtn;
            this.homeBtn.CustomImages.Parent = this.homeBtn;
            this.homeBtn.FillColor = System.Drawing.Color.Transparent;
            this.homeBtn.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.HoverState.Parent = this.homeBtn;
            this.homeBtn.Location = new System.Drawing.Point(0, 244);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.ShadowDecoration.Parent = this.homeBtn;
            this.homeBtn.Size = new System.Drawing.Size(186, 66);
            this.homeBtn.TabIndex = 5;
            this.homeBtn.Text = "Home";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // timerConnection
            // 
            this.timerConnection.AutoSize = true;
            this.timerConnection.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerConnection.ForeColor = System.Drawing.Color.White;
            this.timerConnection.Location = new System.Drawing.Point(66, 147);
            this.timerConnection.Name = "timerConnection";
            this.timerConnection.Size = new System.Drawing.Size(56, 18);
            this.timerConnection.TabIndex = 4;
            this.timerConnection.Text = "00:00:00";
            this.timerConnection.Visible = false;
            // 
            // connectingPic
            // 
            this.connectingPic.AutoStart = true;
            this.connectingPic.CircleSize = 1F;
            this.connectingPic.Location = new System.Drawing.Point(56, 20);
            this.connectingPic.Name = "connectingPic";
            this.connectingPic.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(241)))), ((int)(((byte)(210)))));
            this.connectingPic.Size = new System.Drawing.Size(72, 72);
            this.connectingPic.TabIndex = 2;
            this.connectingPic.Visible = false;
            // 
            // connectionSwitch
            // 
            this.connectionSwitch.Animated = true;
            this.connectionSwitch.AutoRoundedCorners = true;
            this.connectionSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(107)))), ((int)(((byte)(150)))));
            this.connectionSwitch.CheckedState.BorderRadius = 12;
            this.connectionSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(107)))), ((int)(((byte)(150)))));
            this.connectionSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.connectionSwitch.CheckedState.InnerBorderRadius = 8;
            this.connectionSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.connectionSwitch.CheckedState.Parent = this.connectionSwitch;
            this.connectionSwitch.Location = new System.Drawing.Point(69, 184);
            this.connectionSwitch.Name = "connectionSwitch";
            this.connectionSwitch.ShadowDecoration.Parent = this.connectionSwitch;
            this.connectionSwitch.Size = new System.Drawing.Size(43, 27);
            this.connectionSwitch.TabIndex = 3;
            this.connectionSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.connectionSwitch.UncheckedState.BorderRadius = 12;
            this.connectionSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.connectionSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.connectionSwitch.UncheckedState.InnerBorderRadius = 8;
            this.connectionSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.connectionSwitch.UncheckedState.Parent = this.connectionSwitch;
            this.connectionSwitch.CheckedChanged += new System.EventHandler(this.connectionSwitch_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(43, 125);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(98, 22);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "statusLabel";
            // 
            // disconnectedPic
            // 
            this.disconnectedPic.Image = global::JustAvpn.Properties.Resources.icons8_delete_shield_1024px;
            this.disconnectedPic.Location = new System.Drawing.Point(35, 6);
            this.disconnectedPic.Name = "disconnectedPic";
            this.disconnectedPic.ShadowDecoration.Parent = this.disconnectedPic;
            this.disconnectedPic.Size = new System.Drawing.Size(116, 108);
            this.disconnectedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disconnectedPic.TabIndex = 1;
            this.disconnectedPic.TabStop = false;
            this.disconnectedPic.Visible = false;
            // 
            // connectedPic
            // 
            this.connectedPic.Image = global::JustAvpn.Properties.Resources.protect_1024px;
            this.connectedPic.Location = new System.Drawing.Point(35, 6);
            this.connectedPic.Name = "connectedPic";
            this.connectedPic.ShadowDecoration.Parent = this.connectedPic;
            this.connectedPic.Size = new System.Drawing.Size(116, 108);
            this.connectedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.connectedPic.TabIndex = 0;
            this.connectedPic.TabStop = false;
            this.connectedPic.Visible = false;
            // 
            // movePanel
            // 
            this.movePanel.Controls.Add(this.titleLabel);
            this.movePanel.Controls.Add(this.guna2PictureBox4);
            this.movePanel.Controls.Add(this.exitBtn);
            this.movePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel.ForeColor = System.Drawing.Color.White;
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(910, 35);
            this.movePanel.TabIndex = 0;
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseDown);
            this.movePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseMove);
            this.movePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(36, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(128, 19);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "JustAvpn - Edition";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = global::JustAvpn.Properties.Resources._2security_wi_fi_1024px;
            this.guna2PictureBox4.Location = new System.Drawing.Point(10, 7);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.ShadowDecoration.Parent = this.guna2PictureBox4;
            this.guna2PictureBox4.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 25;
            this.guna2PictureBox4.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoverState.Parent = this.exitBtn;
            this.exitBtn.Location = new System.Drawing.Point(881, 10);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(17, 17);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "JustAvpn Service";
            this.trayIcon.Click += new System.EventHandler(this.trayIcon_Click);
            // 
            // timerCount
            // 
            this.timerCount.Interval = 1000;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 543);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JustAvpn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.mainPanel.ResumeLayout(false);
            this.ucPanel.ResumeLayout(false);
            this.ucPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.lateralPanel.ResumeLayout(false);
            this.lateralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectedPic)).EndInit();
            this.movePanel.ResumeLayout(false);
            this.movePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse mainElipse;
        private Guna.UI2.WinForms.Guna2GradientPanel mainPanel;
        private System.Windows.Forms.Panel movePanel;
        private Guna.UI2.WinForms.Guna2CircleButton exitBtn;
        private Guna.UI2.WinForms.Guna2Panel lateralPanel;
        public Guna.UI2.WinForms.Guna2PictureBox disconnectedPic;
        public Guna.UI2.WinForms.Guna2PictureBox connectedPic;
        public System.Windows.Forms.Label statusLabel;
        public Guna.UI2.WinForms.Guna2ToggleSwitch connectionSwitch;
        public Guna.UI2.WinForms.Guna2ProgressIndicator connectingPic;
        public System.Windows.Forms.Label timerConnection;
        private System.Windows.Forms.Timer timerCount;
        public System.Windows.Forms.NotifyIcon trayIcon;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel ucPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label titleLabel;
    }
}

