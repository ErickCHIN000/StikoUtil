
namespace Installer
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
            this.Uninstall = new System.Windows.Forms.Button();
            this.Install = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Uninstall
            // 
            this.Uninstall.BackColor = System.Drawing.Color.IndianRed;
            this.Uninstall.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Uninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uninstall.Location = new System.Drawing.Point(12, 97);
            this.Uninstall.Name = "Uninstall";
            this.Uninstall.Size = new System.Drawing.Size(348, 64);
            this.Uninstall.TabIndex = 1;
            this.Uninstall.Text = "Uninstall";
            this.Uninstall.UseVisualStyleBackColor = false;
            this.Uninstall.Click += new System.EventHandler(this.Uninstall_Click);
            // 
            // Install
            // 
            this.Install.BackColor = System.Drawing.Color.LimeGreen;
            this.Install.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Install.Location = new System.Drawing.Point(12, 12);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(348, 64);
            this.Install.TabIndex = 2;
            this.Install.Text = "Install";
            this.Install.UseVisualStyleBackColor = false;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(372, 173);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.Uninstall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "STIKOSEKUTILITIES Installer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Uninstall;
        private System.Windows.Forms.Button Install;
    }
}

