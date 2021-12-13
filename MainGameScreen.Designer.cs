
using PlariumArcade.ViewModel.Initialization;

namespace PlariumArcade
{
    partial class MainGameScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.moneyStat = new System.Windows.Forms.Button();
            this.mVtStat = new System.Windows.Forms.Button();
            this.oreStat = new System.Windows.Forms.Button();
            this.damageStat = new System.Windows.Forms.Button();
            this.strengthStat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainMapPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(651, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(67, 27);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // moneyStat
            // 
            this.moneyStat.BackColor = System.Drawing.Color.Transparent;
            this.moneyStat.Enabled = false;
            this.moneyStat.FlatAppearance.BorderSize = 0;
            this.moneyStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moneyStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyStat.ForeColor = System.Drawing.SystemColors.Control;
            this.moneyStat.Location = new System.Drawing.Point(3, 2);
            this.moneyStat.Name = "moneyStat";
            this.moneyStat.Size = new System.Drawing.Size(210, 27);
            this.moneyStat.TabIndex = 7;
            this.moneyStat.Text = "$ : 10000000";
            this.moneyStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyStat.UseVisualStyleBackColor = false;
            // 
            // mVtStat
            // 
            this.mVtStat.BackColor = System.Drawing.Color.Transparent;
            this.mVtStat.Enabled = false;
            this.mVtStat.FlatAppearance.BorderSize = 0;
            this.mVtStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mVtStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mVtStat.ForeColor = System.Drawing.SystemColors.Control;
            this.mVtStat.Location = new System.Drawing.Point(3, 408);
            this.mVtStat.Name = "mVtStat";
            this.mVtStat.Size = new System.Drawing.Size(210, 27);
            this.mVtStat.TabIndex = 8;
            this.mVtStat.Text = "MVt : 100000";
            this.mVtStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mVtStat.UseVisualStyleBackColor = false;
            // 
            // oreStat
            // 
            this.oreStat.BackColor = System.Drawing.Color.Transparent;
            this.oreStat.Enabled = false;
            this.oreStat.FlatAppearance.BorderSize = 0;
            this.oreStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oreStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oreStat.ForeColor = System.Drawing.SystemColors.Control;
            this.oreStat.Location = new System.Drawing.Point(3, 24);
            this.oreStat.Name = "oreStat";
            this.oreStat.Size = new System.Drawing.Size(210, 27);
            this.oreStat.TabIndex = 9;
            this.oreStat.Text = "Ore : 10000000";
            this.oreStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oreStat.UseVisualStyleBackColor = false;
            // 
            // damageStat
            // 
            this.damageStat.BackColor = System.Drawing.Color.Transparent;
            this.damageStat.Enabled = false;
            this.damageStat.FlatAppearance.BorderSize = 0;
            this.damageStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.damageStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.damageStat.ForeColor = System.Drawing.SystemColors.Control;
            this.damageStat.Location = new System.Drawing.Point(3, 430);
            this.damageStat.Name = "damageStat";
            this.damageStat.Size = new System.Drawing.Size(210, 27);
            this.damageStat.TabIndex = 10;
            this.damageStat.Text = "Damage : 100000";
            this.damageStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.damageStat.UseVisualStyleBackColor = false;
            // 
            // strengthStat
            // 
            this.strengthStat.BackColor = System.Drawing.Color.Transparent;
            this.strengthStat.Enabled = false;
            this.strengthStat.FlatAppearance.BorderSize = 0;
            this.strengthStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strengthStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strengthStat.ForeColor = System.Drawing.SystemColors.Control;
            this.strengthStat.Location = new System.Drawing.Point(3, 454);
            this.strengthStat.Name = "strengthStat";
            this.strengthStat.Size = new System.Drawing.Size(210, 27);
            this.strengthStat.TabIndex = 12;
            this.strengthStat.Text = "Strength: 100000";
            this.strengthStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.strengthStat.UseVisualStyleBackColor = false;
            // 
            // MainMapPanel
            // 
            this.MainMapPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainMapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMapPanel.Enabled = false;
            this.MainMapPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMapPanel.Name = "MainMapPanel";
            this.MainMapPanel.Size = new System.Drawing.Size(720, 480);
            this.MainMapPanel.TabIndex = 13;
            // 
            // MainGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlariumArcade.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.strengthStat);
            this.Controls.Add(this.damageStat);
            this.Controls.Add(this.oreStat);
            this.Controls.Add(this.mVtStat);
            this.Controls.Add(this.moneyStat);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.MainMapPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGameScreen_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button moneyStat;
        private System.Windows.Forms.Button mVtStat;
        private System.Windows.Forms.Button oreStat;
        private System.Windows.Forms.Button damageStat;
        private System.Windows.Forms.Button strengthStat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel MainMapPanel;
    }
}

