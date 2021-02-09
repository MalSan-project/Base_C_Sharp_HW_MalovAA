
namespace BC_HW_L7_Malov_Task2
{
    partial class HotAndCold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotAndCold));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRightAnswerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ColdPicBox = new System.Windows.Forms.PictureBox();
            this.HotPixBox = new System.Windows.Forms.PictureBox();
            this.WinnerPicBox = new System.Windows.Forms.PictureBox();
            this.TitleBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ColdLabel = new System.Windows.Forms.Label();
            this.HotLabel = new System.Windows.Forms.Label();
            this.mistakeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColdPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotPixBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameToolStripMenuItem,
            this.showRightAnswerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.startNewGameToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.startNewGameToolStripMenuItem.Text = "Start new game";
            this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
            // 
            // showRightAnswerToolStripMenuItem
            // 
            this.showRightAnswerToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.showRightAnswerToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRightAnswerToolStripMenuItem.Name = "showRightAnswerToolStripMenuItem";
            this.showRightAnswerToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.showRightAnswerToolStripMenuItem.Text = "Show right answer";
            this.showRightAnswerToolStripMenuItem.Click += new System.EventHandler(this.showRightAnswerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.CountLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 96);
            this.panel1.TabIndex = 1;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.Location = new System.Drawing.Point(795, 37);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(156, 30);
            this.CountLabel.TabIndex = 3;
            this.CountLabel.Text = "your try=>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "your choice:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(196, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GetMyAnswer);
            // 
            // ColdPicBox
            // 
            this.ColdPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColdPicBox.Location = new System.Drawing.Point(26, 121);
            this.ColdPicBox.Name = "ColdPicBox";
            this.ColdPicBox.Size = new System.Drawing.Size(300, 300);
            this.ColdPicBox.TabIndex = 2;
            this.ColdPicBox.TabStop = false;
            // 
            // HotPixBox
            // 
            this.HotPixBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HotPixBox.ImageLocation = "";
            this.HotPixBox.InitialImage = null;
            this.HotPixBox.Location = new System.Drawing.Point(845, 121);
            this.HotPixBox.Name = "HotPixBox";
            this.HotPixBox.Size = new System.Drawing.Size(300, 300);
            this.HotPixBox.TabIndex = 3;
            this.HotPixBox.TabStop = false;
            // 
            // WinnerPicBox
            // 
            this.WinnerPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WinnerPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WinnerPicBox.Location = new System.Drawing.Point(335, 31);
            this.WinnerPicBox.Name = "WinnerPicBox";
            this.WinnerPicBox.Size = new System.Drawing.Size(501, 503);
            this.WinnerPicBox.TabIndex = 4;
            this.WinnerPicBox.TabStop = false;
            // 
            // TitleBox
            // 
            this.TitleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TitleBox.Location = new System.Drawing.Point(336, 134);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(500, 400);
            this.TitleBox.TabIndex = 5;
            this.TitleBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.TitleLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(41, 31);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(470, 30);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Доброго времени суток, пользователь!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColdLabel
            // 
            this.ColdLabel.AutoSize = true;
            this.ColdLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.ColdLabel.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColdLabel.Location = new System.Drawing.Point(108, 445);
            this.ColdLabel.Name = "ColdLabel";
            this.ColdLabel.Size = new System.Drawing.Size(123, 50);
            this.ColdLabel.TabIndex = 7;
            this.ColdLabel.Text = "COLD";
            this.ColdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HotLabel
            // 
            this.HotLabel.AutoSize = true;
            this.HotLabel.BackColor = System.Drawing.Color.DarkSalmon;
            this.HotLabel.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotLabel.Location = new System.Drawing.Point(942, 445);
            this.HotLabel.Name = "HotLabel";
            this.HotLabel.Size = new System.Drawing.Size(107, 50);
            this.HotLabel.TabIndex = 8;
            this.HotLabel.Text = "HOT";
            this.HotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mistakeLabel
            // 
            this.mistakeLabel.AutoSize = true;
            this.mistakeLabel.BackColor = System.Drawing.Color.MistyRose;
            this.mistakeLabel.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mistakeLabel.Location = new System.Drawing.Point(478, 252);
            this.mistakeLabel.Name = "mistakeLabel";
            this.mistakeLabel.Size = new System.Drawing.Size(168, 40);
            this.mistakeLabel.TabIndex = 9;
            this.mistakeLabel.Text = "mistake!";
            this.mistakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HotAndCold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1180, 632);
            this.Controls.Add(this.mistakeLabel);
            this.Controls.Add(this.HotLabel);
            this.Controls.Add(this.ColdLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.WinnerPicBox);
            this.Controls.Add(this.HotPixBox);
            this.Controls.Add(this.ColdPicBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 675);
            this.MinimumSize = new System.Drawing.Size(1200, 675);
            this.Name = "HotAndCold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hot or Cold";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColdPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotPixBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRightAnswerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.PictureBox ColdPicBox;
        public System.Windows.Forms.PictureBox HotPixBox;
        public System.Windows.Forms.PictureBox WinnerPicBox;
        private System.Windows.Forms.Label CountLabel;
        public System.Windows.Forms.PictureBox TitleBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ColdLabel;
        private System.Windows.Forms.Label HotLabel;
        private System.Windows.Forms.Label mistakeLabel;
    }
}

