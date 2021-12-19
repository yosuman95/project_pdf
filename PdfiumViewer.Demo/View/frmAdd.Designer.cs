
namespace PdfiumViewer.Demo.View
{
    partial class frmAdd
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbKafedra = new System.Windows.Forms.ListBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.pWork = new System.Windows.Forms.Panel();
            this.lbWork = new System.Windows.Forms.ListBox();
            this.pRazdel = new System.Windows.Forms.Panel();
            this.lbRazdel = new System.Windows.Forms.ListBox();
            this.pSubject = new System.Windows.Forms.Panel();
            this.lbSubject = new System.Windows.Forms.ListBox();
            this.pKafedra = new System.Windows.Forms.Panel();
            this.pControlls = new System.Windows.Forms.Panel();
            this.pWorkAdd = new System.Windows.Forms.Panel();
            this.cbWork = new System.Windows.Forms.ComboBox();
            this.cbRazdel = new System.Windows.Forms.ComboBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.tbFileNameBrowser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pRazdelAdd = new System.Windows.Forms.Panel();
            this.tbidSubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRazdelName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveRazdel = new System.Windows.Forms.Button();
            this.pAddSubject = new System.Windows.Forms.Panel();
            this.tbidKafedra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.pAddKafedra = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbKafedra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddKafedra = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pMain.SuspendLayout();
            this.pWork.SuspendLayout();
            this.pRazdel.SuspendLayout();
            this.pSubject.SuspendLayout();
            this.pKafedra.SuspendLayout();
            this.pControlls.SuspendLayout();
            this.pWorkAdd.SuspendLayout();
            this.pRazdelAdd.SuspendLayout();
            this.pAddSubject.SuspendLayout();
            this.pAddKafedra.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lbKafedra
            // 
            this.lbKafedra.DisplayMember = "KafName";
            this.lbKafedra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbKafedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKafedra.FormattingEnabled = true;
            this.lbKafedra.ItemHeight = 20;
            this.lbKafedra.Location = new System.Drawing.Point(0, 0);
            this.lbKafedra.Name = "lbKafedra";
            this.lbKafedra.Size = new System.Drawing.Size(231, 329);
            this.lbKafedra.TabIndex = 1;
            this.lbKafedra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbKafedra_MouseClick);
            this.lbKafedra.SelectedIndexChanged += new System.EventHandler(this.lbKafedra_SelectedIndexChanged);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.PowderBlue;
            this.pMain.Controls.Add(this.pWork);
            this.pMain.Controls.Add(this.pRazdel);
            this.pMain.Controls.Add(this.pSubject);
            this.pMain.Controls.Add(this.pKafedra);
            this.pMain.Controls.Add(this.pControlls);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 24);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(927, 594);
            this.pMain.TabIndex = 1;
            // 
            // pWork
            // 
            this.pWork.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pWork.Controls.Add(this.lbWork);
            this.pWork.Dock = System.Windows.Forms.DockStyle.Left;
            this.pWork.Location = new System.Drawing.Point(693, 0);
            this.pWork.Name = "pWork";
            this.pWork.Size = new System.Drawing.Size(231, 329);
            this.pWork.TabIndex = 5;
            // 
            // lbWork
            // 
            this.lbWork.DisplayMember = "WorkName";
            this.lbWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWork.FormattingEnabled = true;
            this.lbWork.ItemHeight = 20;
            this.lbWork.Location = new System.Drawing.Point(0, 0);
            this.lbWork.Name = "lbWork";
            this.lbWork.Size = new System.Drawing.Size(231, 329);
            this.lbWork.TabIndex = 2;
            this.lbWork.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbWork_MouseClick);
            // 
            // pRazdel
            // 
            this.pRazdel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pRazdel.Controls.Add(this.lbRazdel);
            this.pRazdel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pRazdel.Location = new System.Drawing.Point(462, 0);
            this.pRazdel.Name = "pRazdel";
            this.pRazdel.Size = new System.Drawing.Size(231, 329);
            this.pRazdel.TabIndex = 4;
            // 
            // lbRazdel
            // 
            this.lbRazdel.DisplayMember = "PartName";
            this.lbRazdel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRazdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRazdel.FormattingEnabled = true;
            this.lbRazdel.ItemHeight = 20;
            this.lbRazdel.Location = new System.Drawing.Point(0, 0);
            this.lbRazdel.Name = "lbRazdel";
            this.lbRazdel.Size = new System.Drawing.Size(231, 329);
            this.lbRazdel.TabIndex = 2;
            this.lbRazdel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbRazdel_MouseClick);
            // 
            // pSubject
            // 
            this.pSubject.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pSubject.Controls.Add(this.lbSubject);
            this.pSubject.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSubject.Location = new System.Drawing.Point(231, 0);
            this.pSubject.Name = "pSubject";
            this.pSubject.Size = new System.Drawing.Size(231, 329);
            this.pSubject.TabIndex = 3;
            // 
            // lbSubject
            // 
            this.lbSubject.DisplayMember = "SubjectName";
            this.lbSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.FormattingEnabled = true;
            this.lbSubject.ItemHeight = 20;
            this.lbSubject.Location = new System.Drawing.Point(0, 0);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(231, 329);
            this.lbSubject.TabIndex = 2;
            this.lbSubject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbSubject_MouseClick);
            // 
            // pKafedra
            // 
            this.pKafedra.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pKafedra.Controls.Add(this.lbKafedra);
            this.pKafedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.pKafedra.Location = new System.Drawing.Point(0, 0);
            this.pKafedra.Name = "pKafedra";
            this.pKafedra.Size = new System.Drawing.Size(231, 329);
            this.pKafedra.TabIndex = 2;
            // 
            // pControlls
            // 
            this.pControlls.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pControlls.Controls.Add(this.pWorkAdd);
            this.pControlls.Controls.Add(this.pRazdelAdd);
            this.pControlls.Controls.Add(this.pAddSubject);
            this.pControlls.Controls.Add(this.pAddKafedra);
            this.pControlls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pControlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pControlls.Location = new System.Drawing.Point(0, 329);
            this.pControlls.Name = "pControlls";
            this.pControlls.Size = new System.Drawing.Size(927, 265);
            this.pControlls.TabIndex = 0;
            // 
            // pWorkAdd
            // 
            this.pWorkAdd.Controls.Add(this.cbWork);
            this.pWorkAdd.Controls.Add(this.cbRazdel);
            this.pWorkAdd.Controls.Add(this.btnBrowser);
            this.pWorkAdd.Controls.Add(this.tbFileNameBrowser);
            this.pWorkAdd.Controls.Add(this.label7);
            this.pWorkAdd.Controls.Add(this.label8);
            this.pWorkAdd.Controls.Add(this.label6);
            this.pWorkAdd.Controls.Add(this.button2);
            this.pWorkAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pWorkAdd.Location = new System.Drawing.Point(693, 0);
            this.pWorkAdd.Margin = new System.Windows.Forms.Padding(8);
            this.pWorkAdd.Name = "pWorkAdd";
            this.pWorkAdd.Padding = new System.Windows.Forms.Padding(8);
            this.pWorkAdd.Size = new System.Drawing.Size(231, 265);
            this.pWorkAdd.TabIndex = 3;
            // 
            // cbWork
            // 
            this.cbWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWork.DisplayMember = "WorkName";
            this.cbWork.FormattingEnabled = true;
            this.cbWork.Location = new System.Drawing.Point(11, 98);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(209, 32);
            this.cbWork.TabIndex = 14;
            // 
            // cbRazdel
            // 
            this.cbRazdel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRazdel.DisplayMember = "PartName";
            this.cbRazdel.FormattingEnabled = true;
            this.cbRazdel.Location = new System.Drawing.Point(9, 30);
            this.cbRazdel.Name = "cbRazdel";
            this.cbRazdel.Size = new System.Drawing.Size(211, 32);
            this.cbRazdel.TabIndex = 13;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(192, 172);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(39, 29);
            this.btnBrowser.TabIndex = 12;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click_1);
            // 
            // tbFileNameBrowser
            // 
            this.tbFileNameBrowser.Location = new System.Drawing.Point(9, 172);
            this.tbFileNameBrowser.Margin = new System.Windows.Forms.Padding(6);
            this.tbFileNameBrowser.Name = "tbFileNameBrowser";
            this.tbFileNameBrowser.Size = new System.Drawing.Size(184, 29);
            this.tbFileNameBrowser.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select file";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "idWork";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "idRazdel";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 213);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pRazdelAdd
            // 
            this.pRazdelAdd.Controls.Add(this.tbidSubject);
            this.pRazdelAdd.Controls.Add(this.label4);
            this.pRazdelAdd.Controls.Add(this.tbRazdelName);
            this.pRazdelAdd.Controls.Add(this.label5);
            this.pRazdelAdd.Controls.Add(this.btnSaveRazdel);
            this.pRazdelAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pRazdelAdd.Location = new System.Drawing.Point(462, 0);
            this.pRazdelAdd.Margin = new System.Windows.Forms.Padding(8);
            this.pRazdelAdd.Name = "pRazdelAdd";
            this.pRazdelAdd.Padding = new System.Windows.Forms.Padding(8);
            this.pRazdelAdd.Size = new System.Drawing.Size(231, 265);
            this.pRazdelAdd.TabIndex = 2;
            // 
            // tbidSubject
            // 
            this.tbidSubject.Location = new System.Drawing.Point(9, 56);
            this.tbidSubject.Margin = new System.Windows.Forms.Padding(6);
            this.tbidSubject.Name = "tbidSubject";
            this.tbidSubject.Size = new System.Drawing.Size(219, 29);
            this.tbidSubject.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "idSubject";
            // 
            // tbRazdelName
            // 
            this.tbRazdelName.Location = new System.Drawing.Point(9, 142);
            this.tbRazdelName.Margin = new System.Windows.Forms.Padding(6);
            this.tbRazdelName.Name = "tbRazdelName";
            this.tbRazdelName.Size = new System.Drawing.Size(219, 29);
            this.tbRazdelName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "RazdelName";
            // 
            // btnSaveRazdel
            // 
            this.btnSaveRazdel.Location = new System.Drawing.Point(9, 177);
            this.btnSaveRazdel.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveRazdel.Name = "btnSaveRazdel";
            this.btnSaveRazdel.Size = new System.Drawing.Size(219, 38);
            this.btnSaveRazdel.TabIndex = 3;
            this.btnSaveRazdel.Text = "Save";
            this.btnSaveRazdel.UseVisualStyleBackColor = true;
            this.btnSaveRazdel.Click += new System.EventHandler(this.btnSaveRazdel_Click);
            // 
            // pAddSubject
            // 
            this.pAddSubject.Controls.Add(this.tbidKafedra);
            this.pAddSubject.Controls.Add(this.label3);
            this.pAddSubject.Controls.Add(this.tbSubject);
            this.pAddSubject.Controls.Add(this.label2);
            this.pAddSubject.Controls.Add(this.btnSaveSubject);
            this.pAddSubject.Dock = System.Windows.Forms.DockStyle.Left;
            this.pAddSubject.Location = new System.Drawing.Point(231, 0);
            this.pAddSubject.Margin = new System.Windows.Forms.Padding(8);
            this.pAddSubject.Name = "pAddSubject";
            this.pAddSubject.Padding = new System.Windows.Forms.Padding(8);
            this.pAddSubject.Size = new System.Drawing.Size(231, 265);
            this.pAddSubject.TabIndex = 1;
            // 
            // tbidKafedra
            // 
            this.tbidKafedra.Location = new System.Drawing.Point(6, 56);
            this.tbidKafedra.Margin = new System.Windows.Forms.Padding(6);
            this.tbidKafedra.Name = "tbidKafedra";
            this.tbidKafedra.Size = new System.Drawing.Size(211, 29);
            this.tbidKafedra.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "idKafedra";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(6, 141);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(6);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(211, 29);
            this.tbSubject.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "SubjectName";
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Location = new System.Drawing.Point(6, 177);
            this.btnSaveSubject.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(211, 38);
            this.btnSaveSubject.TabIndex = 3;
            this.btnSaveSubject.Text = "Save";
            this.btnSaveSubject.UseVisualStyleBackColor = true;
            this.btnSaveSubject.Click += new System.EventHandler(this.btnSaveSubject_Click_1);
            // 
            // pAddKafedra
            // 
            this.pAddKafedra.Controls.Add(this.btnDelete);
            this.pAddKafedra.Controls.Add(this.tbKafedra);
            this.pAddKafedra.Controls.Add(this.label1);
            this.pAddKafedra.Controls.Add(this.btnAddKafedra);
            this.pAddKafedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.pAddKafedra.Location = new System.Drawing.Point(0, 0);
            this.pAddKafedra.Margin = new System.Windows.Forms.Padding(8);
            this.pAddKafedra.Name = "pAddKafedra";
            this.pAddKafedra.Padding = new System.Windows.Forms.Padding(8);
            this.pAddKafedra.Size = new System.Drawing.Size(231, 265);
            this.pAddKafedra.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 151);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbKafedra
            // 
            this.tbKafedra.Location = new System.Drawing.Point(6, 56);
            this.tbKafedra.Margin = new System.Windows.Forms.Padding(6);
            this.tbKafedra.Name = "tbKafedra";
            this.tbKafedra.Size = new System.Drawing.Size(211, 29);
            this.tbKafedra.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kafedra name";
            // 
            // btnAddKafedra
            // 
            this.btnAddKafedra.Location = new System.Drawing.Point(6, 91);
            this.btnAddKafedra.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddKafedra.Name = "btnAddKafedra";
            this.btnAddKafedra.Size = new System.Drawing.Size(211, 38);
            this.btnAddKafedra.TabIndex = 3;
            this.btnAddKafedra.Text = "Save";
            this.btnAddKafedra.UseVisualStyleBackColor = true;
            this.btnAddKafedra.Click += new System.EventHandler(this.btnAddKafedra_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 618);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pWork.ResumeLayout(false);
            this.pRazdel.ResumeLayout(false);
            this.pSubject.ResumeLayout(false);
            this.pKafedra.ResumeLayout(false);
            this.pControlls.ResumeLayout(false);
            this.pWorkAdd.ResumeLayout(false);
            this.pWorkAdd.PerformLayout();
            this.pRazdelAdd.ResumeLayout(false);
            this.pRazdelAdd.PerformLayout();
            this.pAddSubject.ResumeLayout(false);
            this.pAddSubject.PerformLayout();
            this.pAddKafedra.ResumeLayout(false);
            this.pAddKafedra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lbKafedra;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pWork;
        private System.Windows.Forms.ListBox lbWork;
        private System.Windows.Forms.Panel pRazdel;
        private System.Windows.Forms.ListBox lbRazdel;
        private System.Windows.Forms.Panel pSubject;
        private System.Windows.Forms.ListBox lbSubject;
        private System.Windows.Forms.Panel pKafedra;
        private System.Windows.Forms.Panel pControlls;
        private System.Windows.Forms.Panel pAddSubject;
        private System.Windows.Forms.TextBox tbidKafedra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.Panel pAddKafedra;
        private System.Windows.Forms.TextBox tbKafedra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddKafedra;
        private System.Windows.Forms.Panel pWorkAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pRazdelAdd;
        private System.Windows.Forms.TextBox tbidSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRazdelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveRazdel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox tbFileNameBrowser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbWork;
        private System.Windows.Forms.ComboBox cbRazdel;
        private System.Windows.Forms.Button btnDelete;
    }
}