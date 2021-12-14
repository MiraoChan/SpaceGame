
namespace PlariumArcade
{
    partial class FightScreen
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
            this.shipPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shipStrength = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.shipAttack = new System.Windows.Forms.PictureBox();
            this.pirateAttack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.shipPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirateAttack)).BeginInit();
            this.SuspendLayout();
            // 
            // shipPicture
            // 
            this.shipPicture.BackColor = System.Drawing.Color.Transparent;
            this.shipPicture.Image = global::PlariumArcade.Properties.Resources.SpaceShip;
            this.shipPicture.Location = new System.Drawing.Point(40, 68);
            this.shipPicture.Name = "shipPicture";
            this.shipPicture.Size = new System.Drawing.Size(80, 80);
            this.shipPicture.TabIndex = 0;
            this.shipPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PlariumArcade.Properties.Resources.Pirates;
            this.pictureBox1.InitialImage = global::PlariumArcade.Properties.Resources.Pirates;
            this.pictureBox1.Location = new System.Drawing.Point(323, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // shipStrength
            // 
            this.shipStrength.BackColor = System.Drawing.Color.Black;
            this.shipStrength.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.shipStrength.Location = new System.Drawing.Point(40, 184);
            this.shipStrength.Name = "shipStrength";
            this.shipStrength.Size = new System.Drawing.Size(80, 23);
            this.shipStrength.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Black;
            this.progressBar2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.progressBar2.Location = new System.Drawing.Point(323, 184);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(80, 23);
            this.progressBar2.TabIndex = 3;
            // 
            // shipAttack
            // 
            this.shipAttack.BackColor = System.Drawing.Color.Transparent;
            this.shipAttack.Image = global::PlariumArcade.Properties.Resources.Attack;
            this.shipAttack.Location = new System.Drawing.Point(126, 68);
            this.shipAttack.Name = "shipAttack";
            this.shipAttack.Size = new System.Drawing.Size(80, 80);
            this.shipAttack.TabIndex = 4;
            this.shipAttack.TabStop = false;
            // 
            // pirateAttack
            // 
            this.pirateAttack.BackColor = System.Drawing.Color.Transparent;
            this.pirateAttack.Image = global::PlariumArcade.Properties.Resources.Attack;
            this.pirateAttack.Location = new System.Drawing.Point(237, 68);
            this.pirateAttack.Name = "pirateAttack";
            this.pirateAttack.Size = new System.Drawing.Size(80, 80);
            this.pirateAttack.TabIndex = 5;
            this.pirateAttack.TabStop = false;
            // 
            // FightScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlariumArcade.Properties.Resources.backgroundMenu;
            this.ClientSize = new System.Drawing.Size(444, 241);
            this.Controls.Add(this.pirateAttack);
            this.Controls.Add(this.shipAttack);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.shipStrength);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shipPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FightScreen";
            this.Text = "FightScreen";
            ((System.ComponentModel.ISupportInitialize)(this.shipPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirateAttack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox shipPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar shipStrength;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox shipAttack;
        private System.Windows.Forms.PictureBox pirateAttack;
    }
}