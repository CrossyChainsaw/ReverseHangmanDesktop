﻿
namespace ReverseHangmanForms
{
    partial class FRM_Menu
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
            this.BTN_Play = new System.Windows.Forms.Button();
            this.BTN_Rules = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Reverse = new System.Windows.Forms.Label();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Play
            // 
            this.BTN_Play.BackColor = System.Drawing.Color.Black;
            this.BTN_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.BTN_Play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Play.Location = new System.Drawing.Point(12, 225);
            this.BTN_Play.Name = "BTN_Play";
            this.BTN_Play.Size = new System.Drawing.Size(776, 89);
            this.BTN_Play.TabIndex = 2;
            this.BTN_Play.Text = "Play";
            this.BTN_Play.UseVisualStyleBackColor = false;
            this.BTN_Play.Click += new System.EventHandler(this.BTN_Play_Click);
            // 
            // BTN_Rules
            // 
            this.BTN_Rules.BackColor = System.Drawing.Color.Black;
            this.BTN_Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.BTN_Rules.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Rules.Location = new System.Drawing.Point(12, 322);
            this.BTN_Rules.Name = "BTN_Rules";
            this.BTN_Rules.Size = new System.Drawing.Size(776, 89);
            this.BTN_Rules.TabIndex = 3;
            this.BTN_Rules.Text = "Rules";
            this.BTN_Rules.UseVisualStyleBackColor = false;
            this.BTN_Rules.Click += new System.EventHandler(this.BTN_Rules_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 83);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hangman";
            this.label1.Visible = false;
            // 
            // LBL_Reverse
            // 
            this.LBL_Reverse.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.LBL_Reverse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Reverse.Location = new System.Drawing.Point(162, 9);
            this.LBL_Reverse.Name = "LBL_Reverse";
            this.LBL_Reverse.Size = new System.Drawing.Size(277, 83);
            this.LBL_Reverse.TabIndex = 5;
            this.LBL_Reverse.Text = "Reverse";
            this.LBL_Reverse.Visible = false;
            // 
            // LBL_Title
            // 
            this.LBL_Title.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.LBL_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Title.Location = new System.Drawing.Point(12, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(776, 83);
            this.LBL_Title.TabIndex = 6;
            this.LBL_Title.Text = "Reverse Hangman";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_Title.Click += new System.EventHandler(this.LBL_Title_Click);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Reverse);
            this.Controls.Add(this.BTN_Rules);
            this.Controls.Add(this.BTN_Play);
            this.Name = "FRM_Menu";
            this.Text = "Reverse Hangman";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_Play;
        private System.Windows.Forms.Button BTN_Rules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Reverse;
        private System.Windows.Forms.Label LBL_Title;
    }
}

