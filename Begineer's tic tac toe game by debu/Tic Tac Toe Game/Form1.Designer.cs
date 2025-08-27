namespace Tic_Tac_Toe_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.CpuTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(322, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU wins:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 115);
            this.button1.TabIndex = 2;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Playerclickbutton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 115);
            this.button2.TabIndex = 3;
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Playerclickbutton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 115);
            this.button3.TabIndex = 4;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Playerclickbutton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 115);
            this.button4.TabIndex = 5;
            this.button4.Text = ".";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Playerclickbutton);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(170, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 115);
            this.button5.TabIndex = 6;
            this.button5.Text = ".";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Playerclickbutton);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(287, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 115);
            this.button6.TabIndex = 7;
            this.button6.Text = ".";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Playerclickbutton);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(53, 287);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 117);
            this.button7.TabIndex = 8;
            this.button7.Text = ".";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Playerclickbutton);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(170, 287);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 117);
            this.button8.TabIndex = 9;
            this.button8.Text = ".";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Playerclickbutton);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(287, 287);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 117);
            this.button9.TabIndex = 10;
            this.button9.Text = ".";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Playerclickbutton);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Cyan;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(179, 421);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 34);
            this.button10.TabIndex = 11;
            this.button10.Text = "Restart ";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.RestartGame);
            // 
            // CpuTimer
            // 
            this.CpuTimer.Interval = 1000;
            this.CpuTimer.Tick += new System.EventHandler(this.CPUmove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 467);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer CpuTimer;
    }
}

