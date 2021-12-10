
namespace PlariumArcade
{
    partial class MenuScreen
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(654, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(67, 27);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StartButton.Location = new System.Drawing.Point(258, 288);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(210, 30);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "START GAME";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.MVtStat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(197, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 76);
            this.label1.TabIndex = 10;
            this.label1.Text = "S P A C E";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlariumArcade.Properties.Resources.backgroundMenu;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
    }
}