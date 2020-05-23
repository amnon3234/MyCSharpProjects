namespace Amnon_sProjects.LightestPath
{
    partial class LightestPathFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightestPathFrame));
            this.girdPanel = new System.Windows.Forms.Panel();
            this.setEnd = new System.Windows.Forms.Button();
            this.setStart = new System.Windows.Forms.Button();
            this.mustGoThrough = new System.Windows.Forms.Button();
            this.slower = new System.Windows.Forms.Button();
            this.buildWall = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.discription = new System.Windows.Forms.Label();
            this.algorithmChooser = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.girdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // girdPanel
            // 
            this.girdPanel.Controls.Add(this.setEnd);
            this.girdPanel.Controls.Add(this.setStart);
            this.girdPanel.Controls.Add(this.mustGoThrough);
            this.girdPanel.Controls.Add(this.slower);
            this.girdPanel.Controls.Add(this.buildWall);
            this.girdPanel.Location = new System.Drawing.Point(439, 2);
            this.girdPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girdPanel.Name = "girdPanel";
            this.girdPanel.Size = new System.Drawing.Size(573, 530);
            this.girdPanel.TabIndex = 0;
            this.girdPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GirdPanel_Paint);
            this.girdPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GirdPanel_MouseDown);
            this.girdPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GirdPanel_MouseMove);
            this.girdPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GirdPanel_MouseUp);
            // 
            // setEnd
            // 
            this.setEnd.BackColor = System.Drawing.Color.Firebrick;
            this.setEnd.FlatAppearance.BorderSize = 0;
            this.setEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setEnd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setEnd.ForeColor = System.Drawing.Color.White;
            this.setEnd.Location = new System.Drawing.Point(460, 487);
            this.setEnd.Margin = new System.Windows.Forms.Padding(4);
            this.setEnd.Name = "setEnd";
            this.setEnd.Size = new System.Drawing.Size(100, 28);
            this.setEnd.TabIndex = 3;
            this.setEnd.Text = "Set End";
            this.setEnd.UseVisualStyleBackColor = false;
            this.setEnd.Click += new System.EventHandler(this.DrawingToolsButtons_click);
            // 
            // setStart
            // 
            this.setStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.setStart.FlatAppearance.BorderSize = 0;
            this.setStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setStart.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setStart.ForeColor = System.Drawing.Color.White;
            this.setStart.Location = new System.Drawing.Point(348, 487);
            this.setStart.Margin = new System.Windows.Forms.Padding(4);
            this.setStart.Name = "setStart";
            this.setStart.Size = new System.Drawing.Size(100, 28);
            this.setStart.TabIndex = 3;
            this.setStart.Text = "Set Start";
            this.setStart.UseVisualStyleBackColor = false;
            this.setStart.Click += new System.EventHandler(this.DrawingToolsButtons_click);
            // 
            // mustGoThrough
            // 
            this.mustGoThrough.BackColor = System.Drawing.Color.Brown;
            this.mustGoThrough.FlatAppearance.BorderSize = 0;
            this.mustGoThrough.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mustGoThrough.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mustGoThrough.ForeColor = System.Drawing.Color.White;
            this.mustGoThrough.Location = new System.Drawing.Point(231, 487);
            this.mustGoThrough.Margin = new System.Windows.Forms.Padding(4);
            this.mustGoThrough.Name = "mustGoThrough";
            this.mustGoThrough.Size = new System.Drawing.Size(105, 28);
            this.mustGoThrough.TabIndex = 3;
            this.mustGoThrough.Text = "Go through";
            this.mustGoThrough.UseVisualStyleBackColor = false;
            this.mustGoThrough.Click += new System.EventHandler(this.DrawingToolsButtons_click);
            // 
            // slower
            // 
            this.slower.BackColor = System.Drawing.Color.DarkKhaki;
            this.slower.FlatAppearance.BorderSize = 0;
            this.slower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slower.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slower.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slower.Location = new System.Drawing.Point(119, 487);
            this.slower.Margin = new System.Windows.Forms.Padding(4);
            this.slower.Name = "slower";
            this.slower.Size = new System.Drawing.Size(100, 28);
            this.slower.TabIndex = 3;
            this.slower.Text = "Slower";
            this.slower.UseVisualStyleBackColor = false;
            this.slower.Click += new System.EventHandler(this.DrawingToolsButtons_click);
            // 
            // buildWall
            // 
            this.buildWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.buildWall.FlatAppearance.BorderSize = 0;
            this.buildWall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildWall.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildWall.ForeColor = System.Drawing.Color.White;
            this.buildWall.Location = new System.Drawing.Point(7, 487);
            this.buildWall.Margin = new System.Windows.Forms.Padding(4);
            this.buildWall.Name = "buildWall";
            this.buildWall.Size = new System.Drawing.Size(100, 28);
            this.buildWall.TabIndex = 3;
            this.buildWall.Text = "Wall";
            this.buildWall.UseVisualStyleBackColor = false;
            this.buildWall.Click += new System.EventHandler(this.DrawingToolsButtons_click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(0, 28);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(363, 42);
            this.header.TabIndex = 1;
            this.header.Text = "Lightest Path Finder";
            // 
            // discription
            // 
            this.discription.AutoSize = true;
            this.discription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discription.Location = new System.Drawing.Point(3, 84);
            this.discription.Name = "discription";
            this.discription.Size = new System.Drawing.Size(407, 210);
            this.discription.TabIndex = 2;
            this.discription.Text = resources.GetString("discription.Text");
            // 
            // algorithmChooser
            // 
            this.algorithmChooser.FormattingEnabled = true;
            this.algorithmChooser.Items.AddRange(new object[] {
            "AStar",
            "Dijkstra",
            "BestFirstSearch"});
            this.algorithmChooser.Location = new System.Drawing.Point(235, 366);
            this.algorithmChooser.Margin = new System.Windows.Forms.Padding(4);
            this.algorithmChooser.Name = "algorithmChooser";
            this.algorithmChooser.Size = new System.Drawing.Size(196, 24);
            this.algorithmChooser.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(235, 399);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(197, 39);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear Grid";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.PathFindingButtons_Click);
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.ForeColor = System.Drawing.Color.White;
            this.runButton.Location = new System.Drawing.Point(235, 446);
            this.runButton.Margin = new System.Windows.Forms.Padding(4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(197, 39);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.PathFindingButtons_Click);
            // 
            // LightestPathFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.algorithmChooser);
            this.Controls.Add(this.discription);
            this.Controls.Add(this.header);
            this.Controls.Add(this.girdPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LightestPathFrame";
            this.Size = new System.Drawing.Size(1024, 521);
            this.Load += new System.EventHandler(this.ShortestPathFrame_Load);
            this.girdPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel girdPanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label discription;
        private System.Windows.Forms.Button buildWall;
        private System.Windows.Forms.Button setEnd;
        private System.Windows.Forms.Button setStart;
        private System.Windows.Forms.Button mustGoThrough;
        private System.Windows.Forms.Button slower;
        private System.Windows.Forms.ComboBox algorithmChooser;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button runButton;
    }
}
