﻿
namespace Digital_Clock
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.calLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.amPmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("DS-Digital", 144F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(118, 94);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(498, 190);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "03:06";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.ForeColor = System.Drawing.Color.White;
            this.secondsLabel.Location = new System.Drawing.Point(571, 199);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(89, 63);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "55";
            // 
            // calLabel
            // 
            this.calLabel.AutoSize = true;
            this.calLabel.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calLabel.ForeColor = System.Drawing.Color.White;
            this.calLabel.Location = new System.Drawing.Point(51, 317);
            this.calLabel.Name = "calLabel";
            this.calLabel.Size = new System.Drawing.Size(327, 47);
            this.calLabel.TabIndex = 2;
            this.calLabel.Text = "March 3rd, 2021";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.White;
            this.dayLabel.Location = new System.Drawing.Point(481, 317);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(236, 47);
            this.dayLabel.TabIndex = 3;
            this.dayLabel.Text = "Wednesday";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Lime;
            this.titleLabel.Location = new System.Drawing.Point(48, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(707, 63);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Jordan\'s C# Digital Clock";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // amPmLabel
            // 
            this.amPmLabel.AutoSize = true;
            this.amPmLabel.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amPmLabel.ForeColor = System.Drawing.Color.White;
            this.amPmLabel.Location = new System.Drawing.Point(571, 123);
            this.amPmLabel.Name = "amPmLabel";
            this.amPmLabel.Size = new System.Drawing.Size(89, 63);
            this.amPmLabel.TabIndex = 5;
            this.amPmLabel.Text = "PM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.amPmLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.calLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label calLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label amPmLabel;
    }
}

