
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.MoneyStat = new System.Windows.Forms.Button();
            this.MVtStat = new System.Windows.Forms.Button();
            this.OreStat = new System.Windows.Forms.Button();
            this.DamageStat = new System.Windows.Forms.Button();
            this.StrengthStat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainMapPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(651, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(67, 27);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MoneyStat
            // 
            this.MoneyStat.BackColor = System.Drawing.Color.Transparent;
            this.MoneyStat.Enabled = false;
            this.MoneyStat.FlatAppearance.BorderSize = 0;
            this.MoneyStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoneyStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyStat.ForeColor = System.Drawing.SystemColors.Control;
            this.MoneyStat.Location = new System.Drawing.Point(3, 2);
            this.MoneyStat.Name = "MoneyStat";
            this.MoneyStat.Size = new System.Drawing.Size(210, 27);
            this.MoneyStat.TabIndex = 7;
            this.MoneyStat.Text = "$ : 10000000";
            this.MoneyStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoneyStat.UseVisualStyleBackColor = false;
            // 
            // MVtStat
            // 
            this.MVtStat.BackColor = System.Drawing.Color.Transparent;
            this.MVtStat.Enabled = false;
            this.MVtStat.FlatAppearance.BorderSize = 0;
            this.MVtStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MVtStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MVtStat.ForeColor = System.Drawing.SystemColors.Control;
            this.MVtStat.Location = new System.Drawing.Point(3, 408);
            this.MVtStat.Name = "MVtStat";
            this.MVtStat.Size = new System.Drawing.Size(210, 27);
            this.MVtStat.TabIndex = 8;
            this.MVtStat.Text = "МВт : 100000";
            this.MVtStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MVtStat.UseVisualStyleBackColor = false;
            // 
            // OreStat
            // 
            this.OreStat.BackColor = System.Drawing.Color.Transparent;
            this.OreStat.Enabled = false;
            this.OreStat.FlatAppearance.BorderSize = 0;
            this.OreStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OreStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OreStat.ForeColor = System.Drawing.SystemColors.Control;
            this.OreStat.Location = new System.Drawing.Point(3, 24);
            this.OreStat.Name = "OreStat";
            this.OreStat.Size = new System.Drawing.Size(210, 27);
            this.OreStat.TabIndex = 9;
            this.OreStat.Text = "Ore : 10000000";
            this.OreStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OreStat.UseVisualStyleBackColor = false;
            // 
            // DamageStat
            // 
            this.DamageStat.BackColor = System.Drawing.Color.Transparent;
            this.DamageStat.Enabled = false;
            this.DamageStat.FlatAppearance.BorderSize = 0;
            this.DamageStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DamageStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DamageStat.ForeColor = System.Drawing.SystemColors.Control;
            this.DamageStat.Location = new System.Drawing.Point(3, 430);
            this.DamageStat.Name = "DamageStat";
            this.DamageStat.Size = new System.Drawing.Size(210, 27);
            this.DamageStat.TabIndex = 10;
            this.DamageStat.Text = "Damage : 100000";
            this.DamageStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DamageStat.UseVisualStyleBackColor = false;
            // 
            // StrengthStat
            // 
            this.StrengthStat.BackColor = System.Drawing.Color.Transparent;
            this.StrengthStat.Enabled = false;
            this.StrengthStat.FlatAppearance.BorderSize = 0;
            this.StrengthStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StrengthStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StrengthStat.ForeColor = System.Drawing.SystemColors.Control;
            this.StrengthStat.Location = new System.Drawing.Point(3, 454);
            this.StrengthStat.Name = "StrengthStat";
            this.StrengthStat.Size = new System.Drawing.Size(210, 27);
            this.StrengthStat.TabIndex = 12;
            this.StrengthStat.Text = "Strength: 100000";
            this.StrengthStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StrengthStat.UseVisualStyleBackColor = false;
            // 
            // MainMapPanel
            // 
            this.MainMapPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainMapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.Controls.Add(this.StrengthStat);
            this.Controls.Add(this.DamageStat);
            this.Controls.Add(this.OreStat);
            this.Controls.Add(this.MVtStat);
            this.Controls.Add(this.MoneyStat);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainMapPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoveControl);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MoneyStat;
        private System.Windows.Forms.Button MVtStat;
        private System.Windows.Forms.Button OreStat;
        private System.Windows.Forms.Button DamageStat;
        private System.Windows.Forms.Button StrengthStat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel MainMapPanel;
    }
}

