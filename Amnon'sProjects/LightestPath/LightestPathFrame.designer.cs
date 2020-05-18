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
            this.girdPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girdPanel
            // 
            this.girdPanel.Location = new System.Drawing.Point(439, 3);
            this.girdPanel.Name = "girdPanel";
            this.girdPanel.Size = new System.Drawing.Size(573, 515);
            this.girdPanel.TabIndex = 0;
            this.girdPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.girdPanel_Paint);
            this.girdPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.girdPanel_MouseDown);
            this.girdPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.girdPanel_MouseMove);
            this.girdPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.girdPanel_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 175);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShortestPathFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.girdPanel);
            this.Name = "ShortestPathFrame";
            this.Size = new System.Drawing.Size(1024, 521);
            this.Load += new System.EventHandler(this.ShortestPathFrame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel girdPanel;
        private System.Windows.Forms.Button button1;
    }
}
