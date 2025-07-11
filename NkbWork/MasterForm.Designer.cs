namespace NkbWork
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeleteShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sPCurdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfoReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.tutorToolStripMenuItem,
            this.sPCurdToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editDeleteShowToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.studentToolStripMenuItem.Text = "Visitors";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editDeleteShowToolStripMenuItem
            // 
            this.editDeleteShowToolStripMenuItem.Name = "editDeleteShowToolStripMenuItem";
            this.editDeleteShowToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editDeleteShowToolStripMenuItem.Text = "Edit/Delete/Show";
            this.editDeleteShowToolStripMenuItem.Click += new System.EventHandler(this.editDeleteShowToolStripMenuItem_Click);
            // 
            // tutorToolStripMenuItem
            // 
            this.tutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editDeleteToolStripMenuItem});
            this.tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            this.tutorToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.tutorToolStripMenuItem.Text = "Candidates";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editDeleteToolStripMenuItem
            // 
            this.editDeleteToolStripMenuItem.Name = "editDeleteToolStripMenuItem";
            this.editDeleteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.editDeleteToolStripMenuItem.Text = "Edit/Delete";
            this.editDeleteToolStripMenuItem.Click += new System.EventHandler(this.editDeleteToolStripMenuItem_Click);
            // 
            // sPCurdToolStripMenuItem
            // 
            this.sPCurdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEditDeleteToolStripMenuItem});
            this.sPCurdToolStripMenuItem.Name = "sPCurdToolStripMenuItem";
            this.sPCurdToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sPCurdToolStripMenuItem.Text = "SP_Curd";
            // 
            // showEditDeleteToolStripMenuItem
            // 
            this.showEditDeleteToolStripMenuItem.Name = "showEditDeleteToolStripMenuItem";
            this.showEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.showEditDeleteToolStripMenuItem.Text = "Show/Edit/Delete";
            this.showEditDeleteToolStripMenuItem.Click += new System.EventHandler(this.showEditDeleteToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInfoReportToolStripMenuItem,
            this.tutorInformationReportToolStripMenuItem,
            this.subReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // studentInfoReportToolStripMenuItem
            // 
            this.studentInfoReportToolStripMenuItem.Name = "studentInfoReportToolStripMenuItem";
            this.studentInfoReportToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.studentInfoReportToolStripMenuItem.Text = "Tourist Info Report";
            this.studentInfoReportToolStripMenuItem.Click += new System.EventHandler(this.studentInfoReportToolStripMenuItem_Click);
            // 
            // tutorInformationReportToolStripMenuItem
            // 
            this.tutorInformationReportToolStripMenuItem.Name = "tutorInformationReportToolStripMenuItem";
            this.tutorInformationReportToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.tutorInformationReportToolStripMenuItem.Text = "Candidate Information Report";
            this.tutorInformationReportToolStripMenuItem.Click += new System.EventHandler(this.tutorInformationReportToolStripMenuItem_Click);
            // 
            // subReportToolStripMenuItem
            // 
            this.subReportToolStripMenuItem.Name = "subReportToolStripMenuItem";
            this.subReportToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.subReportToolStripMenuItem.Text = "SubReport";
            this.subReportToolStripMenuItem.Click += new System.EventHandler(this.subReportToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterForm";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDeleteShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInfoReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorInformationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editDeleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem sPCurdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEditDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subReportToolStripMenuItem;
    }
}