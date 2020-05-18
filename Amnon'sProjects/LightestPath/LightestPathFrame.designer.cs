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
            this.header = new System.Windows.Forms.Label();
            this.discription = new System.Windows.Forms.Label();
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
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(21, 27);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(363, 42);
            this.header.TabIndex = 1;
            this.header.Text = "Lightest Path Finder";
            // 
            // discription
            // 
            this.discription.AutoSize = true;
            this.discription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discription.Location = new System.Drawing.Point(24, 87);
            this.discription.Name = "discription";
            this.discription.Size = new System.Drawing.Size(60, 21);
            this.discription.TabIndex = 2;
            this.discription.Text = "label2";
            // 
            // LightestPathFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.discription);
            this.Controls.Add(this.header);
            this.Controls.Add(this.girdPanel);
            this.Name = "LightestPathFrame";
            this.Size = new System.Drawing.Size(1024, 521);
            this.Load += new System.EventHandler(this.ShortestPathFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel girdPanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label discription;
    }
}
