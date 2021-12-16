
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(654, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(67, 27);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Control;
            this.startButton.Location = new System.Drawing.Point(258, 288);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(210, 30);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "START GAME";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.MVtStat_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold);
            this.mainLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.mainLabel.Location = new System.Drawing.Point(201, 162);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(402, 91);
            this.mainLabel.TabIndex = 10;
            this.mainLabel.Text = "S P A C E";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlariumArcade.Properties.Resources.backgroundMenu;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label mainLabel;
    }
}