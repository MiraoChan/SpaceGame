
namespace PlariumArcade
{
    partial class OrbitalStationMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrbitalStationMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.energyAmount = new System.Windows.Forms.TextBox();
            this.oreAmount = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(43, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENERGY";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(269, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "ORE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // energyAmount
            // 
            this.energyAmount.Location = new System.Drawing.Point(43, 122);
            this.energyAmount.Name = "energyAmount";
            this.energyAmount.Size = new System.Drawing.Size(141, 20);
            this.energyAmount.TabIndex = 4;
            this.energyAmount.Text = "Amount";
            this.energyAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oreAmount
            // 
            this.oreAmount.Location = new System.Drawing.Point(269, 122);
            this.oreAmount.Name = "oreAmount";
            this.oreAmount.Size = new System.Drawing.Size(144, 20);
            this.oreAmount.TabIndex = 5;
            this.oreAmount.Text = "Amount";
            this.oreAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(151, 236);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 33);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit station";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sellButton.Font = new System.Drawing.Font("Consolas", 12F);
            this.sellButton.ForeColor = System.Drawing.SystemColors.Control;
            this.sellButton.Location = new System.Drawing.Point(269, 173);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(144, 33);
            this.sellButton.TabIndex = 7;
            this.sellButton.Text = "S E L L";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyButton.Font = new System.Drawing.Font("Consolas", 12F);
            this.buyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.buyButton.Location = new System.Drawing.Point(43, 173);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(144, 33);
            this.buyButton.TabIndex = 8;
            this.buyButton.Text = "B U Y";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // OrbitalStationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlariumArcade.Properties.Resources.backgroundMenu;
            this.ClientSize = new System.Drawing.Size(460, 280);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.oreAmount);
            this.Controls.Add(this.energyAmount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrbitalStationMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrbitalStationMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox energyAmount;
        private System.Windows.Forms.TextBox oreAmount;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button buyButton;
    }
}