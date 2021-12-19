using PdfiumViewer.Demo.Controller;
using PdfiumViewer.Demo.DTO.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfiumViewer.Demo.View.File
{
    public partial class frmFile : Form
    {
        public frmFile()
        {
            InitializeComponent();
        }

        private void frmFile_Load(object sender, EventArgs e)
        {
            cbSubjectName.SelectedIndexChanged -= cbSubjectName_SelectedIndexChanged;
            cbPartName.SelectedIndexChanged -= cbPartName_SelectedIndexChanged;
            cbWorkType.SelectedIndexChanged -= cbWorkType_SelectedIndexChanged;

            RazdelController razdelController = new RazdelController();
            var razdel = razdelController.GetAllRazdel();
            if (razdel.Code == "1")
                MessageBox.Show(razdel.Description);
            else
            {
                var response = (SuccessResponseRazdel)razdel;
                cbPartName.DataSource = response.Razdeltables.ToList();
            }
            SubjectController subjectController = new SubjectController();
            var subject = subjectController.GetAllSubjects();
            if (subject.Code == "1")
                MessageBox.Show(subject.Description);
            else
            {
                var response = (SuccessResponseSubject)subject;
                cbSubjectName.DataSource = response.Subjecttables.ToList();
            }
            WorkController workController = new WorkController();
            var work = workController.GetAllWorks();
            if (work.Code == "1")
                MessageBox.Show(work.Description);
            else
            {
                var response = (SuccessResponseWork)work;
                cbWorkType.DataSource = response.WorkTables.ToList();
            }
            cbSubjectName.Text = "";
            cbPartName.Text = "";
            cbWorkType.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbPartName.Text.Length <= 0)
            {
                MessageBox.Show("Please select Razdel");
            }
            else if (cbWorkType.Text.Length < 1)
            {
                MessageBox.Show(" Please Select Work");
            }
            else if ((cbPartName.Text.Length > 0) && (cbWorkType.Text.Length > 0))
            {               
                String subject = cbSubjectName.GetItemText(cbSubjectName.SelectedValue);
                String razdel = cbPartName.GetItemText(cbPartName.SelectedValue);
                String typework = cbWorkType.GetItemText(cbWorkType.SelectedValue);
                String filename = subject + "\\" + razdel + "_" + typework + ".pdf";
                string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\PDFFiles\\";
                if (!Directory.Exists(wanted_path + "\\" + subject))
                    Directory.CreateDirectory(wanted_path + "\\" + subject);

                String curfileName = wanted_path + filename;

                String sourceFile = tbFileName.Text;

                if (!System.IO.File.Exists(curfileName))
                    System.IO.File.Move(sourceFile, curfileName);
                else
                    MessageBox.Show("File is exists");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
               // InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog1.FileName;

            }
        }

        private void cbSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}