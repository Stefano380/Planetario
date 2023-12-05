namespace Pianeti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtVelocitaX = new System.Windows.Forms.TextBox();
            this.txtMassa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreaPianeta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVelocitaY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPosizioneY = new System.Windows.Forms.TextBox();
            this.txtPosizioneX = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(388, 254);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtVelocitaX
            // 
            this.txtVelocitaX.Location = new System.Drawing.Point(388, 319);
            this.txtVelocitaX.Name = "txtVelocitaX";
            this.txtVelocitaX.Size = new System.Drawing.Size(100, 22);
            this.txtVelocitaX.TabIndex = 3;
            // 
            // txtMassa
            // 
            this.txtMassa.Location = new System.Drawing.Point(388, 288);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(100, 22);
            this.txtMassa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Velocità X:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Massa (consigliata 5000):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CreaPianeta
            // 
            this.CreaPianeta.Location = new System.Drawing.Point(583, 193);
            this.CreaPianeta.Name = "CreaPianeta";
            this.CreaPianeta.Size = new System.Drawing.Size(104, 80);
            this.CreaPianeta.TabIndex = 9;
            this.CreaPianeta.Text = "Crea pianeta";
            this.CreaPianeta.UseVisualStyleBackColor = true;
            this.CreaPianeta.Click += new System.EventHandler(this.CreaPianeta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Velocità Y:";
            // 
            // txtVelocitaY
            // 
            this.txtVelocitaY.Location = new System.Drawing.Point(583, 321);
            this.txtVelocitaY.Name = "txtVelocitaY";
            this.txtVelocitaY.Size = new System.Drawing.Size(100, 22);
            this.txtVelocitaY.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Posizione Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Posizione X:";
            // 
            // txtPosizioneY
            // 
            this.txtPosizioneY.Location = new System.Drawing.Point(583, 363);
            this.txtPosizioneY.Name = "txtPosizioneY";
            this.txtPosizioneY.Size = new System.Drawing.Size(100, 22);
            this.txtPosizioneY.TabIndex = 14;
            // 
            // txtPosizioneX
            // 
            this.txtPosizioneX.Location = new System.Drawing.Point(388, 363);
            this.txtPosizioneX.Name = "txtPosizioneX";
            this.txtPosizioneX.Size = new System.Drawing.Size(100, 22);
            this.txtPosizioneX.TabIndex = 15;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(75, 257);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 90);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "INIZIA";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(368, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 17;
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pianeti.Properties.Resources.sfondo_stelle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPosizioneX);
            this.Controls.Add(this.txtPosizioneY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVelocitaY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreaPianeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMassa);
            this.Controls.Add(this.txtVelocitaX);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtVelocitaX;
        private System.Windows.Forms.TextBox txtMassa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreaPianeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVelocitaY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPosizioneY;
        private System.Windows.Forms.TextBox txtPosizioneX;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

