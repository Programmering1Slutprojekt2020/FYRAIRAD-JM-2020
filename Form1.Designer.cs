namespace Fyra_i_rad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox11wins = new System.Windows.Forms.PictureBox();
            this.pictureBox22wins = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11wins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22wins)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // pictureBox11wins
            // 
            this.pictureBox11wins.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11wins.Image")));
            this.pictureBox11wins.Location = new System.Drawing.Point(171, 50);
            this.pictureBox11wins.Name = "pictureBox11wins";
            this.pictureBox11wins.Size = new System.Drawing.Size(800, 800);
            this.pictureBox11wins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11wins.TabIndex = 0;
            this.pictureBox11wins.TabStop = false;
            this.pictureBox11wins.Visible = false;
            // 
            // pictureBox22wins
            // 
            this.pictureBox22wins.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22wins.Image")));
            this.pictureBox22wins.Location = new System.Drawing.Point(12, 29);
            this.pictureBox22wins.Name = "pictureBox22wins";
            this.pictureBox22wins.Size = new System.Drawing.Size(428, 423);
            this.pictureBox22wins.TabIndex = 1;
            this.pictureBox22wins.TabStop = false;
            this.pictureBox22wins.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1 = Blue\r\nPlayer 2 = Grey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox11wins);
            this.Controls.Add(this.pictureBox22wins);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11wins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22wins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox11wins;
        private System.Windows.Forms.PictureBox pictureBox22wins;
        private System.Windows.Forms.Label label1;
    }
}

