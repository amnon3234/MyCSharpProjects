namespace Amnon_sProjects.ShortestPath
{
    partial class ShortestPathFrame
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
            // ShortestPathFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.girdPanel);
            this.Name = "ShortestPathFrame";
            this.Size = new System.Drawing.Size(1024, 521);
            this.Load += new System.EventHandler(this.ShortestPathFrame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel girdPanel;
    }
}
