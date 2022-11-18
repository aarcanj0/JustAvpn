namespace JustAvpn
{
    partial class configUC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.protocolSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.protocolSwitch);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(724, 508);
            this.mainPanel.TabIndex = 0;
            // 
            // protocolSwitch
            // 
            this.protocolSwitch.Animated = true;
            this.protocolSwitch.AutoRoundedCorners = true;
            this.protocolSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(107)))), ((int)(((byte)(150)))));
            this.protocolSwitch.CheckedState.BorderRadius = 15;
            this.protocolSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(107)))), ((int)(((byte)(150)))));
            this.protocolSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.protocolSwitch.CheckedState.InnerBorderRadius = 11;
            this.protocolSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.protocolSwitch.CheckedState.Parent = this.protocolSwitch;
            this.protocolSwitch.Location = new System.Drawing.Point(336, 92);
            this.protocolSwitch.Name = "protocolSwitch";
            this.protocolSwitch.ShadowDecoration.Parent = this.protocolSwitch;
            this.protocolSwitch.Size = new System.Drawing.Size(55, 33);
            this.protocolSwitch.TabIndex = 0;
            this.protocolSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.protocolSwitch.UncheckedState.BorderRadius = 15;
            this.protocolSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.protocolSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.protocolSwitch.UncheckedState.InnerBorderRadius = 11;
            this.protocolSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.protocolSwitch.UncheckedState.Parent = this.protocolSwitch;
            this.protocolSwitch.CheckedChanged += new System.EventHandler(this.protocolSwitch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Protocolo de Conexão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "UDP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(397, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "TCP";
            // 
            // configUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.MaximumSize = new System.Drawing.Size(724, 508);
            this.MinimumSize = new System.Drawing.Size(724, 508);
            this.Name = "configUC";
            this.Size = new System.Drawing.Size(724, 508);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ToggleSwitch protocolSwitch;
    }
}
