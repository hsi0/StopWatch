namespace WindowsFormsApplication4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblore = new System.Windows.Forms.Label();
            this.lblminute = new System.Windows.Forms.Label();
            this.lblsecunde = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblore
            // 
            this.lblore.AutoSize = true;
            this.lblore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblore.Location = new System.Drawing.Point(12, 21);
            this.lblore.Name = "lblore";
            this.lblore.Size = new System.Drawing.Size(151, 108);
            this.lblore.TabIndex = 0;
            this.lblore.Text = "00";
            // 
            // lblminute
            // 
            this.lblminute.AutoSize = true;
            this.lblminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminute.Location = new System.Drawing.Point(201, 21);
            this.lblminute.Name = "lblminute";
            this.lblminute.Size = new System.Drawing.Size(151, 108);
            this.lblminute.TabIndex = 1;
            this.lblminute.Text = "00";
            // 
            // lblsecunde
            // 
            this.lblsecunde.AutoSize = true;
            this.lblsecunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecunde.Location = new System.Drawing.Point(396, 21);
            this.lblsecunde.Name = "lblsecunde";
            this.lblsecunde.Size = new System.Drawing.Size(151, 108);
            this.lblsecunde.TabIndex = 2;
            this.lblsecunde.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 108);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 108);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // btnstart
            // 
            this.btnstart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstart.BackgroundImage")));
            this.btnstart.Image = ((System.Drawing.Image)(resources.GetObject("btnstart.Image")));
            this.btnstart.Location = new System.Drawing.Point(12, 132);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(151, 155);
            this.btnstart.TabIndex = 5;
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click_1);
            // 
            // btnstop
            // 
            this.btnstop.Image = ((System.Drawing.Image)(resources.GetObject("btnstop.Image")));
            this.btnstop.Location = new System.Drawing.Point(205, 132);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(158, 155);
            this.btnstop.TabIndex = 6;
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnreset
            // 
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.Location = new System.Drawing.Point(401, 132);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(146, 155);
            this.btnreset.TabIndex = 7;
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 312);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsecunde);
            this.Controls.Add(this.lblminute);
            this.Controls.Add(this.lblore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblore;
        private System.Windows.Forms.Label lblminute;
        private System.Windows.Forms.Label lblsecunde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Timer timer1;
    }
}

