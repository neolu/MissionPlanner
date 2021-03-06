﻿namespace ArdupilotMega.Controls
{
    partial class ThemeColors
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TXT_bg = new System.Windows.Forms.TextBox();
            this.TXT_ctlbg = new System.Windows.Forms.TextBox();
            this.TXT_text = new System.Windows.Forms.TextBox();
            this.TXT_butbg = new System.Windows.Forms.TextBox();
            this.TXT_butbord = new System.Windows.Forms.TextBox();
            this.BUT_butbord = new ArdupilotMega.Controls.MyButton();
            this.BUT_butbg = new ArdupilotMega.Controls.MyButton();
            this.BUT_text = new ArdupilotMega.Controls.MyButton();
            this.BUT_ctlbg = new ArdupilotMega.Controls.MyButton();
            this.BUT_bg = new ArdupilotMega.Controls.MyButton();
            this.BUT_done = new ArdupilotMega.Controls.MyButton();
            this.SuspendLayout();
            // 
            // TXT_bg
            // 
            this.TXT_bg.Location = new System.Drawing.Point(93, 14);
            this.TXT_bg.Name = "TXT_bg";
            this.TXT_bg.Size = new System.Drawing.Size(100, 20);
            this.TXT_bg.TabIndex = 4;
            // 
            // TXT_ctlbg
            // 
            this.TXT_ctlbg.Location = new System.Drawing.Point(93, 43);
            this.TXT_ctlbg.Name = "TXT_ctlbg";
            this.TXT_ctlbg.Size = new System.Drawing.Size(100, 20);
            this.TXT_ctlbg.TabIndex = 5;
            // 
            // TXT_text
            // 
            this.TXT_text.Location = new System.Drawing.Point(93, 72);
            this.TXT_text.Name = "TXT_text";
            this.TXT_text.Size = new System.Drawing.Size(100, 20);
            this.TXT_text.TabIndex = 6;
            // 
            // TXT_butbg
            // 
            this.TXT_butbg.Location = new System.Drawing.Point(93, 101);
            this.TXT_butbg.Name = "TXT_butbg";
            this.TXT_butbg.Size = new System.Drawing.Size(100, 20);
            this.TXT_butbg.TabIndex = 7;
            // 
            // TXT_butbord
            // 
            this.TXT_butbord.Location = new System.Drawing.Point(93, 130);
            this.TXT_butbord.Name = "TXT_butbord";
            this.TXT_butbord.Size = new System.Drawing.Size(100, 20);
            this.TXT_butbord.TabIndex = 9;
            // 
            // BUT_butbord
            // 
            this.BUT_butbord.Location = new System.Drawing.Point(12, 128);
            this.BUT_butbord.Name = "BUT_butbord";
            this.BUT_butbord.Size = new System.Drawing.Size(75, 23);
            this.BUT_butbord.TabIndex = 8;
            this.BUT_butbord.Text = "Button Border";
            this.BUT_butbord.UseVisualStyleBackColor = true;
            this.BUT_butbord.Click += new System.EventHandler(this.BUT_butbord_Click);
            // 
            // BUT_butbg
            // 
            this.BUT_butbg.Location = new System.Drawing.Point(12, 99);
            this.BUT_butbg.Name = "BUT_butbg";
            this.BUT_butbg.Size = new System.Drawing.Size(75, 23);
            this.BUT_butbg.TabIndex = 3;
            this.BUT_butbg.Text = "Button BG";
            this.BUT_butbg.UseVisualStyleBackColor = true;
            this.BUT_butbg.Click += new System.EventHandler(this.BUT_butbg_Click);
            // 
            // BUT_text
            // 
            this.BUT_text.Location = new System.Drawing.Point(12, 70);
            this.BUT_text.Name = "BUT_text";
            this.BUT_text.Size = new System.Drawing.Size(75, 23);
            this.BUT_text.TabIndex = 2;
            this.BUT_text.Text = "Text";
            this.BUT_text.UseVisualStyleBackColor = true;
            this.BUT_text.Click += new System.EventHandler(this.BUT_text_Click);
            // 
            // BUT_ctlbg
            // 
            this.BUT_ctlbg.Location = new System.Drawing.Point(12, 41);
            this.BUT_ctlbg.Name = "BUT_ctlbg";
            this.BUT_ctlbg.Size = new System.Drawing.Size(75, 23);
            this.BUT_ctlbg.TabIndex = 1;
            this.BUT_ctlbg.Text = "Control BG";
            this.BUT_ctlbg.UseVisualStyleBackColor = true;
            this.BUT_ctlbg.Click += new System.EventHandler(this.BUT_ctlbg_Click);
            // 
            // BUT_bg
            // 
            this.BUT_bg.Location = new System.Drawing.Point(12, 12);
            this.BUT_bg.Name = "BUT_bg";
            this.BUT_bg.Size = new System.Drawing.Size(75, 23);
            this.BUT_bg.TabIndex = 0;
            this.BUT_bg.Text = "Background";
            this.BUT_bg.UseVisualStyleBackColor = true;
            this.BUT_bg.Click += new System.EventHandler(this.BUT_bg_Click);
            // 
            // BUT_done
            // 
            this.BUT_done.Location = new System.Drawing.Point(63, 154);
            this.BUT_done.Name = "BUT_done";
            this.BUT_done.Size = new System.Drawing.Size(75, 23);
            this.BUT_done.TabIndex = 10;
            this.BUT_done.Text = "Done";
            this.BUT_done.UseVisualStyleBackColor = true;
            this.BUT_done.Click += new System.EventHandler(this.BUT_done_Click);
            // 
            // ThemeColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 189);
            this.Controls.Add(this.BUT_done);
            this.Controls.Add(this.TXT_butbord);
            this.Controls.Add(this.BUT_butbord);
            this.Controls.Add(this.TXT_butbg);
            this.Controls.Add(this.TXT_text);
            this.Controls.Add(this.TXT_ctlbg);
            this.Controls.Add(this.TXT_bg);
            this.Controls.Add(this.BUT_butbg);
            this.Controls.Add(this.BUT_text);
            this.Controls.Add(this.BUT_ctlbg);
            this.Controls.Add(this.BUT_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemeColors";
            this.Text = "ThemeColors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private MyButton BUT_bg;
        private MyButton BUT_ctlbg;
        private MyButton BUT_text;
        private MyButton BUT_butbg;
        private System.Windows.Forms.TextBox TXT_bg;
        private System.Windows.Forms.TextBox TXT_ctlbg;
        private System.Windows.Forms.TextBox TXT_text;
        private System.Windows.Forms.TextBox TXT_butbg;
        private System.Windows.Forms.TextBox TXT_butbord;
        private MyButton BUT_butbord;
        private MyButton BUT_done;
    }
}