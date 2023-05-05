
namespace AtividadeGeral
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rdopapel = new System.Windows.Forms.RadioButton();
            this.rdoPedra = new System.Windows.Forms.RadioButton();
            this.rdotesoura = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lbplayer = new System.Windows.Forms.Label();
            this.lbcpu = new System.Windows.Forms.Label();
            this.imgplayer = new System.Windows.Forms.PictureBox();
            this.imgcpu = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.randomlb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcpu)).BeginInit();
            this.SuspendLayout();
            // 
            // rdopapel
            // 
            this.rdopapel.AutoSize = true;
            this.rdopapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdopapel.Location = new System.Drawing.Point(60, 202);
            this.rdopapel.Name = "rdopapel";
            this.rdopapel.Size = new System.Drawing.Size(85, 29);
            this.rdopapel.TabIndex = 0;
            this.rdopapel.TabStop = true;
            this.rdopapel.Text = "Papel";
            this.rdopapel.UseVisualStyleBackColor = true;
            this.rdopapel.CheckedChanged += new System.EventHandler(this.rdopapel_CheckedChanged);
            // 
            // rdoPedra
            // 
            this.rdoPedra.AutoSize = true;
            this.rdoPedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPedra.Location = new System.Drawing.Point(60, 261);
            this.rdoPedra.Name = "rdoPedra";
            this.rdoPedra.Size = new System.Drawing.Size(87, 29);
            this.rdoPedra.TabIndex = 0;
            this.rdoPedra.TabStop = true;
            this.rdoPedra.Text = "Pedra";
            this.rdoPedra.UseVisualStyleBackColor = true;
            this.rdoPedra.CheckedChanged += new System.EventHandler(this.rdoPedra_CheckedChanged);
            // 
            // rdotesoura
            // 
            this.rdotesoura.AutoSize = true;
            this.rdotesoura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdotesoura.Location = new System.Drawing.Point(60, 332);
            this.rdotesoura.Name = "rdotesoura";
            this.rdotesoura.Size = new System.Drawing.Size(109, 29);
            this.rdotesoura.TabIndex = 1;
            this.rdotesoura.TabStop = true;
            this.rdotesoura.Text = "Tesoura";
            this.rdotesoura.UseVisualStyleBackColor = true;
            this.rdotesoura.CheckedChanged += new System.EventHandler(this.rdotesoura_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(638, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Jogar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbplayer
            // 
            this.lbplayer.AutoSize = true;
            this.lbplayer.Location = new System.Drawing.Point(443, 44);
            this.lbplayer.Name = "lbplayer";
            this.lbplayer.Size = new System.Drawing.Size(13, 13);
            this.lbplayer.TabIndex = 3;
            this.lbplayer.Text = "0";
            this.lbplayer.Click += new System.EventHandler(this.lbplayer_Click);
            // 
            // lbcpu
            // 
            this.lbcpu.AutoSize = true;
            this.lbcpu.Location = new System.Drawing.Point(963, 44);
            this.lbcpu.Name = "lbcpu";
            this.lbcpu.Size = new System.Drawing.Size(13, 13);
            this.lbcpu.TabIndex = 4;
            this.lbcpu.Text = "0";
            // 
            // imgplayer
            // 
            this.imgplayer.BackColor = System.Drawing.Color.Transparent;
            this.imgplayer.Image = global::AtividadeGeral.Properties.Resources.papel;
            this.imgplayer.Location = new System.Drawing.Point(248, 85);
            this.imgplayer.Name = "imgplayer";
            this.imgplayer.Size = new System.Drawing.Size(484, 467);
            this.imgplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgplayer.TabIndex = 5;
            this.imgplayer.TabStop = false;
            // 
            // imgcpu
            // 
            this.imgcpu.BackColor = System.Drawing.Color.Transparent;
            this.imgcpu.Image = global::AtividadeGeral.Properties.Resources.papel;
            this.imgcpu.Location = new System.Drawing.Point(723, 85);
            this.imgcpu.Name = "imgcpu";
            this.imgcpu.Size = new System.Drawing.Size(484, 467);
            this.imgcpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgcpu.TabIndex = 6;
            this.imgcpu.TabStop = false;
            this.imgcpu.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // randomlb
            // 
            this.randomlb.AutoSize = true;
            this.randomlb.Location = new System.Drawing.Point(60, 486);
            this.randomlb.Name = "randomlb";
            this.randomlb.Size = new System.Drawing.Size(35, 13);
            this.randomlb.TabIndex = 7;
            this.randomlb.Text = "label1";
            this.randomlb.Click += new System.EventHandler(this.randomlb_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1258, 789);
            this.Controls.Add(this.randomlb);
            this.Controls.Add(this.imgcpu);
            this.Controls.Add(this.imgplayer);
            this.Controls.Add(this.lbcpu);
            this.Controls.Add(this.lbplayer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdotesoura);
            this.Controls.Add(this.rdoPedra);
            this.Controls.Add(this.rdopapel);
            this.Name = "Panel";
            this.Text = "Vamos Jogar JoKenPô!";
            ((System.ComponentModel.ISupportInitialize)(this.imgplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdopapel;
        private System.Windows.Forms.RadioButton rdoPedra;
        private System.Windows.Forms.RadioButton rdotesoura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbplayer;
        private System.Windows.Forms.Label lbcpu;
        private System.Windows.Forms.PictureBox imgplayer;
        private System.Windows.Forms.PictureBox imgcpu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label randomlb;
    }
}

