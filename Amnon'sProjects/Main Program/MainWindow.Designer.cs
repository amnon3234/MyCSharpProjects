namespace Amnon_sProjects.Main_Program
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.leftDockedPanel = new System.Windows.Forms.Panel();
            this.toSudoku = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.toHomeFrame = new System.Windows.Forms.Button();
            this.topDockedPanel = new System.Windows.Forms.Panel();
            this.pictuerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkedin = new System.Windows.Forms.PictureBox();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.instagram = new System.Windows.Forms.PictureBox();
            this.gitHub = new System.Windows.Forms.PictureBox();
            this.gmail = new System.Windows.Forms.PictureBox();
            this.shutDown = new System.Windows.Forms.PictureBox();
            this.toShortestPath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sudokuFrame1 = new Amnon_sProjects.Sudoku.SudokuFrame();
            this.homeFrame1 = new Amnon_sProjects.HomeFrame();
            this.sudokuFrame2 = new Amnon_sProjects.Sudoku.SudokuFrame();
            this.LightestPathFrame1 = new Amnon_sProjects.LightestPath.LightestPathFrame();
            this.leftDockedPanel.SuspendLayout();
            this.pictuerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutDown)).BeginInit();
            this.SuspendLayout();
            // 
            // leftDockedPanel
            // 
            this.leftDockedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.leftDockedPanel.Controls.Add(this.panel1);
            this.leftDockedPanel.Controls.Add(this.sudokuFrame2);
            this.leftDockedPanel.Controls.Add(this.toShortestPath);
            this.leftDockedPanel.Controls.Add(this.toSudoku);
            this.leftDockedPanel.Controls.Add(this.sidePanel);
            this.leftDockedPanel.Controls.Add(this.toHomeFrame);
            this.leftDockedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftDockedPanel.Location = new System.Drawing.Point(0, 0);
            this.leftDockedPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftDockedPanel.Name = "leftDockedPanel";
            this.leftDockedPanel.Size = new System.Drawing.Size(255, 713);
            this.leftDockedPanel.TabIndex = 0;
            // 
            // toSudoku
            // 
            this.toSudoku.FlatAppearance.BorderSize = 0;
            this.toSudoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toSudoku.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSudoku.ForeColor = System.Drawing.Color.White;
            this.toSudoku.Image = ((System.Drawing.Image)(resources.GetObject("toSudoku.Image")));
            this.toSudoku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toSudoku.Location = new System.Drawing.Point(16, 172);
            this.toSudoku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toSudoku.Name = "toSudoku";
            this.toSudoku.Size = new System.Drawing.Size(235, 66);
            this.toSudoku.TabIndex = 12;
            this.toSudoku.Text = "Sudoku";
            this.toSudoku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toSudoku.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toSudoku.UseVisualStyleBackColor = true;
            this.toSudoku.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 98);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(13, 66);
            this.sidePanel.TabIndex = 11;
            // 
            // toHomeFrame
            // 
            this.toHomeFrame.FlatAppearance.BorderSize = 0;
            this.toHomeFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toHomeFrame.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toHomeFrame.ForeColor = System.Drawing.Color.White;
            this.toHomeFrame.Image = ((System.Drawing.Image)(resources.GetObject("toHomeFrame.Image")));
            this.toHomeFrame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toHomeFrame.Location = new System.Drawing.Point(16, 98);
            this.toHomeFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toHomeFrame.Name = "toHomeFrame";
            this.toHomeFrame.Size = new System.Drawing.Size(235, 66);
            this.toHomeFrame.TabIndex = 0;
            this.toHomeFrame.Text = "Home";
            this.toHomeFrame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toHomeFrame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toHomeFrame.UseVisualStyleBackColor = true;
            this.toHomeFrame.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // topDockedPanel
            // 
            this.topDockedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.topDockedPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topDockedPanel.Location = new System.Drawing.Point(255, 0);
            this.topDockedPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topDockedPanel.Name = "topDockedPanel";
            this.topDockedPanel.Size = new System.Drawing.Size(1021, 21);
            this.topDockedPanel.TabIndex = 1;
            // 
            // pictuerPanel
            // 
            this.pictuerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pictuerPanel.Controls.Add(this.label2);
            this.pictuerPanel.Controls.Add(this.pictureBox1);
            this.pictuerPanel.Controls.Add(this.NameLabel);
            this.pictuerPanel.Location = new System.Drawing.Point(355, -1);
            this.pictuerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictuerPanel.Name = "pictuerPanel";
            this.pictuerPanel.Size = new System.Drawing.Size(129, 166);
            this.pictuerPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "projects";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(13, 114);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(94, 23);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Amnon\'s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(492, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contact Info:";
            // 
            // linkedin
            // 
            this.linkedin.Image = ((System.Drawing.Image)(resources.GetObject("linkedin.Image")));
            this.linkedin.Location = new System.Drawing.Point(695, 28);
            this.linkedin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linkedin.Name = "linkedin";
            this.linkedin.Size = new System.Drawing.Size(40, 36);
            this.linkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.linkedin.TabIndex = 4;
            this.linkedin.TabStop = false;
            this.linkedin.Click += new System.EventHandler(this.Contacts_Click);
            this.linkedin.MouseEnter += new System.EventHandler(this.Contacts_MouseEnter);
            this.linkedin.MouseLeave += new System.EventHandler(this.Contacts_MouseLeave);
            // 
            // facebook
            // 
            this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
            this.facebook.Location = new System.Drawing.Point(744, 28);
            this.facebook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(40, 36);
            this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facebook.TabIndex = 5;
            this.facebook.TabStop = false;
            this.facebook.Click += new System.EventHandler(this.Contacts_Click);
            this.facebook.MouseEnter += new System.EventHandler(this.Contacts_MouseEnter);
            this.facebook.MouseLeave += new System.EventHandler(this.Contacts_MouseLeave);
            // 
            // instagram
            // 
            this.instagram.Image = ((System.Drawing.Image)(resources.GetObject("instagram.Image")));
            this.instagram.Location = new System.Drawing.Point(793, 28);
            this.instagram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instagram.Name = "instagram";
            this.instagram.Size = new System.Drawing.Size(40, 36);
            this.instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.instagram.TabIndex = 6;
            this.instagram.TabStop = false;
            this.instagram.Click += new System.EventHandler(this.Contacts_Click);
            this.instagram.MouseEnter += new System.EventHandler(this.Contacts_MouseEnter);
            this.instagram.MouseLeave += new System.EventHandler(this.Contacts_MouseLeave);
            // 
            // gitHub
            // 
            this.gitHub.Image = ((System.Drawing.Image)(resources.GetObject("gitHub.Image")));
            this.gitHub.Location = new System.Drawing.Point(843, 28);
            this.gitHub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gitHub.Name = "gitHub";
            this.gitHub.Size = new System.Drawing.Size(40, 36);
            this.gitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gitHub.TabIndex = 7;
            this.gitHub.TabStop = false;
            this.gitHub.Click += new System.EventHandler(this.Contacts_Click);
            this.gitHub.MouseEnter += new System.EventHandler(this.Contacts_MouseEnter);
            this.gitHub.MouseLeave += new System.EventHandler(this.Contacts_MouseLeave);
            // 
            // gmail
            // 
            this.gmail.Image = ((System.Drawing.Image)(resources.GetObject("gmail.Image")));
            this.gmail.Location = new System.Drawing.Point(892, 28);
            this.gmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(40, 36);
            this.gmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gmail.TabIndex = 8;
            this.gmail.TabStop = false;
            this.gmail.Click += new System.EventHandler(this.Contacts_Click);
            this.gmail.MouseEnter += new System.EventHandler(this.Contacts_MouseEnter);
            this.gmail.MouseLeave += new System.EventHandler(this.Contacts_MouseLeave);
            // 
            // shutDown
            // 
            this.shutDown.Image = ((System.Drawing.Image)(resources.GetObject("shutDown.Image")));
            this.shutDown.Location = new System.Drawing.Point(1220, 28);
            this.shutDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shutDown.Name = "shutDown";
            this.shutDown.Size = new System.Drawing.Size(40, 36);
            this.shutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shutDown.TabIndex = 10;
            this.shutDown.TabStop = false;
            this.shutDown.Click += new System.EventHandler(this.shutDown_Click);
            // 
            // toShortestPath
            // 
            this.toShortestPath.FlatAppearance.BorderSize = 0;
            this.toShortestPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toShortestPath.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toShortestPath.ForeColor = System.Drawing.Color.White;
            this.toShortestPath.Image = ((System.Drawing.Image)(resources.GetObject("toShortestPath.Image")));
            this.toShortestPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toShortestPath.Location = new System.Drawing.Point(16, 246);
            this.toShortestPath.Margin = new System.Windows.Forms.Padding(4);
            this.toShortestPath.Name = "toShortestPath";
            this.toShortestPath.Size = new System.Drawing.Size(235, 66);
            this.toShortestPath.TabIndex = 12;
            this.toShortestPath.Text = "Shortest Path";
            this.toShortestPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toShortestPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toShortestPath.UseVisualStyleBackColor = true;
            this.toShortestPath.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(252, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 521);
            this.panel1.TabIndex = 13;
            // 
            // sudokuFrame1
            // 
            this.sudokuFrame1.Location = new System.Drawing.Point(255, 172);
            this.sudokuFrame1.Margin = new System.Windows.Forms.Padding(5);
            this.sudokuFrame1.Name = "sudokuFrame1";
            this.sudokuFrame1.Size = new System.Drawing.Size(1120, 540);
            this.sudokuFrame1.TabIndex = 12;
            // 
            // homeFrame1
            // 
            this.homeFrame1.Location = new System.Drawing.Point(255, 172);
            this.homeFrame1.Margin = new System.Windows.Forms.Padding(5);
            this.homeFrame1.Name = "homeFrame1";
            this.homeFrame1.Size = new System.Drawing.Size(1120, 540);
            this.homeFrame1.TabIndex = 11;
            // 
            // sudokuFrame2
            // 
            this.sudokuFrame2.Location = new System.Drawing.Point(252, 192);
            this.sudokuFrame2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sudokuFrame2.Name = "sudokuFrame2";
            this.sudokuFrame2.Size = new System.Drawing.Size(1120, 540);
            this.sudokuFrame2.TabIndex = 13;
            // 
            // LightestPathFrame1
            // 
            this.LightestPathFrame1.Location = new System.Drawing.Point(252, 192);
            this.LightestPathFrame1.Name = "LightestPathFrame1";
            this.LightestPathFrame1.Size = new System.Drawing.Size(1024, 521);
            this.LightestPathFrame1.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 713);
            this.Controls.Add(this.LightestPathFrame1);
            this.Controls.Add(this.sudokuFrame1);
            this.Controls.Add(this.homeFrame1);
            this.Controls.Add(this.shutDown);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.gitHub);
            this.Controls.Add(this.instagram);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.linkedin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictuerPanel);
            this.Controls.Add(this.topDockedPanel);
            this.Controls.Add(this.leftDockedPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.leftDockedPanel.ResumeLayout(false);
            this.pictuerPanel.ResumeLayout(false);
            this.pictuerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftDockedPanel;
        private System.Windows.Forms.Panel topDockedPanel;
        private System.Windows.Forms.Panel pictuerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox linkedin;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.PictureBox instagram;
        private System.Windows.Forms.PictureBox gitHub;
        private System.Windows.Forms.PictureBox gmail;
        private System.Windows.Forms.PictureBox shutDown;
        private System.Windows.Forms.Button toHomeFrame;
        private System.Windows.Forms.Button toSudoku;
        private System.Windows.Forms.Panel sidePanel;
        private HomeFrame homeFrame1;
        private Sudoku.SudokuFrame sudokuFrame1;
        private System.Windows.Forms.Button toShortestPath;
        private Sudoku.SudokuFrame sudokuFrame2;
        private System.Windows.Forms.Panel panel1;
        private LightestPath.LightestPathFrame LightestPathFrame1;
    }
}

