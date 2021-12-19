
namespace PdfiumViewer.Demo.View
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addKafedraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRazdelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kafedraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addKafedraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateKafedraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteKafedraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lsttypework = new System.Windows.Forms.ListBox();
            this.lstSubjects = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lstRazdel = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lstKafedra = new System.Windows.Forms.ListBox();
            this.razdelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRazdelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRazdelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRazdelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.kafedraToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.razdelToolStripMenuItem,
            this.workToolStripMenuItem,
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1167, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addKafedraToolStripMenuItem,
            this.addSubjectToolStripMenuItem,
            this.addRazdelToolStripMenuItem,
            this.addWorkToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addKafedraToolStripMenuItem
            // 
            this.addKafedraToolStripMenuItem.Name = "addKafedraToolStripMenuItem";
            this.addKafedraToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addKafedraToolStripMenuItem.Text = "AddKafedra";
            this.addKafedraToolStripMenuItem.Click += new System.EventHandler(this.addKafedraToolStripMenuItem_Click);
            // 
            // addSubjectToolStripMenuItem
            // 
            this.addSubjectToolStripMenuItem.Name = "addSubjectToolStripMenuItem";
            this.addSubjectToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addSubjectToolStripMenuItem.Text = "Edit";
            this.addSubjectToolStripMenuItem.Click += new System.EventHandler(this.addSubjectToolStripMenuItem_Click);
            // 
            // addRazdelToolStripMenuItem
            // 
            this.addRazdelToolStripMenuItem.Name = "addRazdelToolStripMenuItem";
            this.addRazdelToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addRazdelToolStripMenuItem.Text = "EditWork";
            this.addRazdelToolStripMenuItem.Click += new System.EventHandler(this.addRazdelToolStripMenuItem_Click);
            // 
            // addWorkToolStripMenuItem
            // 
            this.addWorkToolStripMenuItem.Name = "addWorkToolStripMenuItem";
            this.addWorkToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addWorkToolStripMenuItem.Text = "AddWork";
            this.addWorkToolStripMenuItem.Click += new System.EventHandler(this.addWorkToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // kafedraToolStripMenuItem
            // 
            this.kafedraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addKafedraToolStripMenuItem1,
            this.updateKafedraToolStripMenuItem,
            this.deleteKafedraToolStripMenuItem});
            this.kafedraToolStripMenuItem.Name = "kafedraToolStripMenuItem";
            this.kafedraToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.kafedraToolStripMenuItem.Text = "Kafedra";
            // 
            // addKafedraToolStripMenuItem1
            // 
            this.addKafedraToolStripMenuItem1.Name = "addKafedraToolStripMenuItem1";
            this.addKafedraToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.addKafedraToolStripMenuItem1.Text = "New Kafedra";
            this.addKafedraToolStripMenuItem1.Click += new System.EventHandler(this.addKafedraToolStripMenuItem1_Click);
            // 
            // updateKafedraToolStripMenuItem
            // 
            this.updateKafedraToolStripMenuItem.Name = "updateKafedraToolStripMenuItem";
            this.updateKafedraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateKafedraToolStripMenuItem.Text = "Update Kafedra";
            this.updateKafedraToolStripMenuItem.Click += new System.EventHandler(this.updateKafedraToolStripMenuItem_Click);
            // 
            // deleteKafedraToolStripMenuItem
            // 
            this.deleteKafedraToolStripMenuItem.Name = "deleteKafedraToolStripMenuItem";
            this.deleteKafedraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteKafedraToolStripMenuItem.Text = "Delete Kafedra";
            this.deleteKafedraToolStripMenuItem.Click += new System.EventHandler(this.deleteKafedraToolStripMenuItem_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSubjectToolStripMenuItem,
            this.updateSubjectToolStripMenuItem,
            this.deleteSubjectToolStripMenuItem});
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.subjectToolStripMenuItem.Text = "Subject";
            // 
            // newSubjectToolStripMenuItem
            // 
            this.newSubjectToolStripMenuItem.Name = "newSubjectToolStripMenuItem";
            this.newSubjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newSubjectToolStripMenuItem.Text = "New Subject";
            this.newSubjectToolStripMenuItem.Click += new System.EventHandler(this.newSubjectToolStripMenuItem_Click);
            // 
            // updateSubjectToolStripMenuItem
            // 
            this.updateSubjectToolStripMenuItem.Name = "updateSubjectToolStripMenuItem";
            this.updateSubjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSubjectToolStripMenuItem.Text = "Update Subject";
            this.updateSubjectToolStripMenuItem.Click += new System.EventHandler(this.updateSubjectToolStripMenuItem_Click);
            // 
            // deleteSubjectToolStripMenuItem
            // 
            this.deleteSubjectToolStripMenuItem.Name = "deleteSubjectToolStripMenuItem";
            this.deleteSubjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSubjectToolStripMenuItem.Text = "Delete Subject";
            this.deleteSubjectToolStripMenuItem.Click += new System.EventHandler(this.deleteSubjectToolStripMenuItem_Click);
            // 
            // workToolStripMenuItem
            // 
            this.workToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorkToolStripMenuItem,
            this.updateWorkToolStripMenuItem,
            this.deleteWorkToolStripMenuItem});
            this.workToolStripMenuItem.Name = "workToolStripMenuItem";
            this.workToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.workToolStripMenuItem.Text = "Work";
            // 
            // newWorkToolStripMenuItem
            // 
            this.newWorkToolStripMenuItem.Name = "newWorkToolStripMenuItem";
            this.newWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newWorkToolStripMenuItem.Text = "New Work";
            this.newWorkToolStripMenuItem.Click += new System.EventHandler(this.newWorkToolStripMenuItem_Click);
            // 
            // updateWorkToolStripMenuItem
            // 
            this.updateWorkToolStripMenuItem.Name = "updateWorkToolStripMenuItem";
            this.updateWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateWorkToolStripMenuItem.Text = "Update Work";
            this.updateWorkToolStripMenuItem.Click += new System.EventHandler(this.updateWorkToolStripMenuItem_Click);
            // 
            // deleteWorkToolStripMenuItem
            // 
            this.deleteWorkToolStripMenuItem.Name = "deleteWorkToolStripMenuItem";
            this.deleteWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteWorkToolStripMenuItem.Text = "Delete Work";
            this.deleteWorkToolStripMenuItem.Click += new System.EventHandler(this.deleteWorkToolStripMenuItem_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lsttypework);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(833, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(247, 709);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // lsttypework
            // 
            this.lsttypework.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsttypework.DisplayMember = "WorkName";
            this.lsttypework.FormattingEnabled = true;
            this.lsttypework.ItemHeight = 25;
            this.lsttypework.Location = new System.Drawing.Point(6, 6);
            this.lsttypework.Margin = new System.Windows.Forms.Padding(6);
            this.lsttypework.Name = "lsttypework";
            this.lsttypework.Size = new System.Drawing.Size(265, 804);
            this.lsttypework.TabIndex = 4;
            this.lsttypework.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsttypework_MouseClick);
            this.lsttypework.SelectedIndexChanged += new System.EventHandler(this.lsttypework_SelectedIndexChanged_1);
            // 
            // lstSubjects
            // 
            this.lstSubjects.DisplayMember = "SubjectName";
            this.lstSubjects.FormattingEnabled = true;
            this.lstSubjects.ItemHeight = 25;
            this.lstSubjects.Location = new System.Drawing.Point(6, 6);
            this.lstSubjects.Margin = new System.Windows.Forms.Padding(6);
            this.lstSubjects.Name = "lstSubjects";
            this.lstSubjects.Size = new System.Drawing.Size(284, 904);
            this.lstSubjects.TabIndex = 1;
            this.lstSubjects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSubjects_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lstRazdel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(567, 24);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 709);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lstRazdel
            // 
            this.lstRazdel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRazdel.DisplayMember = "PartName";
            this.lstRazdel.FormattingEnabled = true;
            this.lstRazdel.ItemHeight = 25;
            this.lstRazdel.Location = new System.Drawing.Point(6, 6);
            this.lstRazdel.Margin = new System.Windows.Forms.Padding(6);
            this.lstRazdel.Name = "lstRazdel";
            this.lstRazdel.Size = new System.Drawing.Size(254, 854);
            this.lstRazdel.TabIndex = 2;
            this.lstRazdel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstRazdel_MouseClick);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lstSubjects);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(271, 24);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(296, 709);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lstKafedra);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(271, 709);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // lstKafedra
            // 
            this.lstKafedra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKafedra.DisplayMember = "KafName";
            this.lstKafedra.FormattingEnabled = true;
            this.lstKafedra.ItemHeight = 25;
            this.lstKafedra.Location = new System.Drawing.Point(6, 6);
            this.lstKafedra.Margin = new System.Windows.Forms.Padding(6);
            this.lstKafedra.Name = "lstKafedra";
            this.lstKafedra.Size = new System.Drawing.Size(254, 904);
            this.lstKafedra.TabIndex = 1;
            this.lstKafedra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstKafedra_MouseClick);
            this.lstKafedra.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstKafedra_MouseDoubleClick);
            // 
            // razdelToolStripMenuItem
            // 
            this.razdelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRazdelToolStripMenuItem,
            this.updateRazdelToolStripMenuItem,
            this.deleteRazdelToolStripMenuItem});
            this.razdelToolStripMenuItem.Name = "razdelToolStripMenuItem";
            this.razdelToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.razdelToolStripMenuItem.Text = "Razdel";
            // 
            // newRazdelToolStripMenuItem
            // 
            this.newRazdelToolStripMenuItem.Name = "newRazdelToolStripMenuItem";
            this.newRazdelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newRazdelToolStripMenuItem.Text = "New Razdel";
            this.newRazdelToolStripMenuItem.Click += new System.EventHandler(this.newRazdelToolStripMenuItem_Click);
            // 
            // updateRazdelToolStripMenuItem
            // 
            this.updateRazdelToolStripMenuItem.Name = "updateRazdelToolStripMenuItem";
            this.updateRazdelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateRazdelToolStripMenuItem.Text = "Update Razdel";
            this.updateRazdelToolStripMenuItem.Click += new System.EventHandler(this.updateRazdelToolStripMenuItem_Click);
            // 
            // deleteRazdelToolStripMenuItem
            // 
            this.deleteRazdelToolStripMenuItem.Name = "deleteRazdelToolStripMenuItem";
            this.deleteRazdelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteRazdelToolStripMenuItem.Text = "Delete Razdel";
            this.deleteRazdelToolStripMenuItem.Click += new System.EventHandler(this.deleteRazdelToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 733);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ListBox lstSubjects;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ListBox lstRazdel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ListBox lsttypework;
        private System.Windows.Forms.ToolStripMenuItem addKafedraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRazdelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lstKafedra;
        private System.Windows.Forms.ToolStripMenuItem kafedraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addKafedraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateKafedraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteKafedraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razdelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRazdelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRazdelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRazdelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
    }
}