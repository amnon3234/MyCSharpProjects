namespace Amnon_sProjects.Sudoku
{
    partial class SudokuFrame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solve = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(400, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 368);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Play Sudoku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "Generate a game board and try to solve\r\nit within the time limit. Or insert your\r" +
    "\nown board and we will solve it for you.";
            // 
            // solve
            // 
            this.solve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solve.ForeColor = System.Drawing.Color.White;
            this.solve.Location = new System.Drawing.Point(246, 383);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(148, 32);
            this.solve.TabIndex = 4;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = false;
            this.solve.Click += new System.EventHandler(this.GameButtons_Click);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.Color.White;
            this.generate.Location = new System.Drawing.Point(246, 345);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(148, 32);
            this.generate.TabIndex = 4;
            this.generate.Text = "Generate Board";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.GameButtons_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(246, 307);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(148, 32);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear Board";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.GameButtons_Click);
            // 
            // difficulty
            // 
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Items.AddRange(new object[] {
            "Hard",
            "Advanced",
            "Easy"});
            this.difficulty.Location = new System.Drawing.Point(246, 280);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(148, 21);
            this.difficulty.TabIndex = 5;
            // 
            // SudokuFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "SudokuFrame";
            this.Size = new System.Drawing.Size(840, 439);
            this.Load += new System.EventHandler(this.SudokuFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox difficulty;
    }
}
