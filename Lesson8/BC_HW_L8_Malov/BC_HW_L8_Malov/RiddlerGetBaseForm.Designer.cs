
namespace BC_HW_L8_Malov
{
    partial class RiddlerGetBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiddlerGetBaseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditRiddleBut = new System.Windows.Forms.Button();
            this.SaveRiddleInFile = new System.Windows.Forms.Button();
            this.DeleteRiddle = new System.Windows.Forms.Button();
            this.AddRiddleBut = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.strToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRiddlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRiddlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.NumberOfRiddle = new System.Windows.Forms.NumericUpDown();
            this.TitleForQuestions = new System.Windows.Forms.Label();
            this.TitleForAnswer = new System.Windows.Forms.Label();
            this.TextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.CommentBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRiddle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.NumberOfRiddle);
            this.panel1.Controls.Add(this.EditRiddleBut);
            this.panel1.Controls.Add(this.SaveRiddleInFile);
            this.panel1.Controls.Add(this.DeleteRiddle);
            this.panel1.Controls.Add(this.AddRiddleBut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 82);
            this.panel1.TabIndex = 0;
            // 
            // EditRiddleBut
            // 
            this.EditRiddleBut.BackColor = System.Drawing.Color.White;
            this.EditRiddleBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EditRiddleBut.FlatAppearance.BorderSize = 3;
            this.EditRiddleBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.EditRiddleBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRiddleBut.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRiddleBut.Location = new System.Drawing.Point(136, 26);
            this.EditRiddleBut.Name = "EditRiddleBut";
            this.EditRiddleBut.Size = new System.Drawing.Size(124, 35);
            this.EditRiddleBut.TabIndex = 3;
            this.EditRiddleBut.Text = "Edit Riddle";
            this.EditRiddleBut.UseVisualStyleBackColor = false;
            this.EditRiddleBut.Click += new System.EventHandler(this.EditRiddleBut_Click);
            // 
            // SaveRiddleInFile
            // 
            this.SaveRiddleInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveRiddleInFile.BackColor = System.Drawing.Color.Green;
            this.SaveRiddleInFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveRiddleInFile.FlatAppearance.BorderSize = 3;
            this.SaveRiddleInFile.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.SaveRiddleInFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveRiddleInFile.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRiddleInFile.Location = new System.Drawing.Point(480, 24);
            this.SaveRiddleInFile.Name = "SaveRiddleInFile";
            this.SaveRiddleInFile.Size = new System.Drawing.Size(136, 35);
            this.SaveRiddleInFile.TabIndex = 2;
            this.SaveRiddleInFile.Text = "Save Riddle\'s";
            this.SaveRiddleInFile.UseVisualStyleBackColor = false;
            // 
            // DeleteRiddle
            // 
            this.DeleteRiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteRiddle.BackColor = System.Drawing.Color.Red;
            this.DeleteRiddle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteRiddle.FlatAppearance.BorderSize = 3;
            this.DeleteRiddle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.DeleteRiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRiddle.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRiddle.Location = new System.Drawing.Point(343, 24);
            this.DeleteRiddle.Name = "DeleteRiddle";
            this.DeleteRiddle.Size = new System.Drawing.Size(136, 35);
            this.DeleteRiddle.TabIndex = 1;
            this.DeleteRiddle.Text = "Delete Riddle";
            this.DeleteRiddle.UseVisualStyleBackColor = false;
            this.DeleteRiddle.Click += new System.EventHandler(this.DeleteRiddle_Click);
            // 
            // AddRiddleBut
            // 
            this.AddRiddleBut.BackColor = System.Drawing.Color.White;
            this.AddRiddleBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddRiddleBut.FlatAppearance.BorderSize = 3;
            this.AddRiddleBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.AddRiddleBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRiddleBut.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRiddleBut.Location = new System.Drawing.Point(6, 26);
            this.AddRiddleBut.Name = "AddRiddleBut";
            this.AddRiddleBut.Size = new System.Drawing.Size(124, 35);
            this.AddRiddleBut.TabIndex = 0;
            this.AddRiddleBut.Text = "Add Riddle";
            this.AddRiddleBut.UseVisualStyleBackColor = false;
            this.AddRiddleBut.Click += new System.EventHandler(this.AddRiddleBut_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTool});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(624, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuTool
            // 
            this.MenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strToolStripMenuItem,
            this.openRiddlerToolStripMenuItem,
            this.saveRiddlerToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.MenuTool.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTool.Name = "MenuTool";
            this.MenuTool.Size = new System.Drawing.Size(71, 26);
            this.MenuTool.Text = "Menu";
            // 
            // strToolStripMenuItem
            // 
            this.strToolStripMenuItem.Name = "strToolStripMenuItem";
            this.strToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.strToolStripMenuItem.Text = "New Riddler";
            this.strToolStripMenuItem.Click += new System.EventHandler(this.strToolStripMenuItem_Click);
            // 
            // openRiddlerToolStripMenuItem
            // 
            this.openRiddlerToolStripMenuItem.Name = "openRiddlerToolStripMenuItem";
            this.openRiddlerToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.openRiddlerToolStripMenuItem.Text = "Open Riddler";
            this.openRiddlerToolStripMenuItem.Click += new System.EventHandler(this.openRiddlerToolStripMenuItem_Click);
            // 
            // saveRiddlerToolStripMenuItem
            // 
            this.saveRiddlerToolStripMenuItem.Name = "saveRiddlerToolStripMenuItem";
            this.saveRiddlerToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.saveRiddlerToolStripMenuItem.Text = "Save Riddler";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // TextBoxQuestion
            // 
            this.TextBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxQuestion.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxQuestion.Location = new System.Drawing.Point(10, 75);
            this.TextBoxQuestion.Name = "TextBoxQuestion";
            this.TextBoxQuestion.Size = new System.Drawing.Size(606, 62);
            this.TextBoxQuestion.TabIndex = 2;
            this.TextBoxQuestion.Text = "";
            // 
            // NumberOfRiddle
            // 
            this.NumberOfRiddle.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRiddle.Location = new System.Drawing.Point(266, 26);
            this.NumberOfRiddle.Name = "NumberOfRiddle";
            this.NumberOfRiddle.Size = new System.Drawing.Size(67, 33);
            this.NumberOfRiddle.TabIndex = 4;
            this.NumberOfRiddle.ValueChanged += new System.EventHandler(this.NumberOfRiddle_ValueChanged);
            // 
            // TitleForQuestions
            // 
            this.TitleForQuestions.AutoSize = true;
            this.TitleForQuestions.BackColor = System.Drawing.Color.LightGreen;
            this.TitleForQuestions.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleForQuestions.Location = new System.Drawing.Point(6, 41);
            this.TitleForQuestions.Name = "TitleForQuestions";
            this.TitleForQuestions.Size = new System.Drawing.Size(230, 31);
            this.TitleForQuestions.TabIndex = 6;
            this.TitleForQuestions.Text = "Write question:";
            this.TitleForQuestions.Visible = false;
            // 
            // TitleForAnswer
            // 
            this.TitleForAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TitleForAnswer.AutoSize = true;
            this.TitleForAnswer.BackColor = System.Drawing.Color.LightGreen;
            this.TitleForAnswer.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleForAnswer.Location = new System.Drawing.Point(6, 140);
            this.TitleForAnswer.Name = "TitleForAnswer";
            this.TitleForAnswer.Size = new System.Drawing.Size(211, 31);
            this.TitleForAnswer.TabIndex = 8;
            this.TitleForAnswer.Text = "Write answer:";
            this.TitleForAnswer.Visible = false;
            // 
            // TextBoxAnswer
            // 
            this.TextBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAnswer.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAnswer.Location = new System.Drawing.Point(6, 174);
            this.TextBoxAnswer.Name = "TextBoxAnswer";
            this.TextBoxAnswer.Size = new System.Drawing.Size(610, 49);
            this.TextBoxAnswer.TabIndex = 7;
            this.TextBoxAnswer.Text = "";
            // 
            // CommentLabel
            // 
            this.CommentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.BackColor = System.Drawing.Color.LightGreen;
            this.CommentLabel.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLabel.Location = new System.Drawing.Point(6, 226);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(375, 31);
            this.CommentLabel.TabIndex = 10;
            this.CommentLabel.Text = "Write comment to answer:";
            this.CommentLabel.Visible = false;
            // 
            // CommentBox
            // 
            this.CommentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentBox.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentBox.Location = new System.Drawing.Point(6, 260);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(610, 70);
            this.CommentBox.TabIndex = 9;
            this.CommentBox.Text = "";
            // 
            // RiddlerGetBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 411);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.TitleForAnswer);
            this.Controls.Add(this.TextBoxAnswer);
            this.Controls.Add(this.TitleForQuestions);
            this.Controls.Add(this.TextBoxQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.MinimumSize = new System.Drawing.Size(640, 450);
            this.Name = "RiddlerGetBaseForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRiddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveRiddleInFile;
        private System.Windows.Forms.Button DeleteRiddle;
        private System.Windows.Forms.Button AddRiddleBut;
        private System.Windows.Forms.Button EditRiddleBut;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuTool;
        private System.Windows.Forms.ToolStripMenuItem strToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRiddlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRiddlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox TextBoxQuestion;
        private System.Windows.Forms.Label TitleForQuestions;
        private System.Windows.Forms.Label TitleForAnswer;
        private System.Windows.Forms.RichTextBox TextBoxAnswer;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.RichTextBox CommentBox;
        public System.Windows.Forms.NumericUpDown NumberOfRiddle;
    }
}

