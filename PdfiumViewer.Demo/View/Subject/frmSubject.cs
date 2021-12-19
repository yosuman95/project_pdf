using PdfiumViewer.Demo.Controller;
using PdfiumViewer.Demo.DTO.Data;
using Students.DTO.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfiumViewer.Demo.View.Subject
{
    public partial class frmSubject : Form
    {
        private int id;
        public frmSubject()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbSubjectName.Text.Length > 0 && id > 0 && cbAuthor.Text.Length > 0)
            {
                Subjecttable subjecttable = new Subjecttable();
                subjecttable.Author = cbAuthor.Text;
                subjecttable.SubjectName = ((Subjecttable)cbSubjectName.Items[cbKafedraName.SelectedIndex]).SubjectName;
                subjecttable.IdKaf = id;                
                SubjectController subjectController = new SubjectController();
                var subject = subjectController.SubjectAdd(subjecttable);
                if (subject.Code == "1")
                    MessageBox.Show(subject.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please select or insert Informations");
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            cbKafedraName.SelectedIndexChanged -= cbKafedraName_SelectedIndexChanged;
            cbSubjectName.SelectedIndexChanged -= cbSubjectName_SelectedIndexChanged;
            cbAuthor.SelectedIndexChanged -= cbAuthor_SelectedIndexChanged;
            KafedraController kafedraController = new KafedraController();
            var kafedra = kafedraController.GetAllKafedra();
            if (kafedra.Code == "1")
                MessageBox.Show(kafedra.Description);
            else
            {
                var response = (SuccessResponseKafedra)kafedra;
                cbKafedraName.DataSource = response.Kafedratables.ToList();
            }

            SubjectController subjectController = new SubjectController();
            var subject = subjectController.GetAllSubjects();
            if (subject.Code == "1")
                MessageBox.Show(subject.Description);
            else
            {
                var response = (SuccessResponseSubject)subject;
                cbAuthor.DataSource = response.Subjecttables.ToList();
                cbSubjectName.DataSource = response.Subjecttables.ToList();
            }
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbSubjectName.Text.Length > 0 && id > 0 && cbAuthor.Text.Length > 0)
            {
                Subjecttable subjecttable = new Subjecttable();
                subjecttable.Author = ((Subjecttable)cbAuthor.Items[cbAuthor.SelectedIndex]).Author;
                subjecttable.SubjectName = ((Subjecttable)cbSubjectName.Items[cbKafedraName.SelectedIndex]).SubjectName;
                subjecttable.IdKaf = ((Kafedratable)cbKafedraName.Items[cbKafedraName.SelectedIndex]).Id;
                subjecttable.Id = ((Subjecttable)cbSubjectName.Items[cbKafedraName.SelectedIndex]).Id;
                SubjectController subjectController = new SubjectController();
                var subject = subjectController.SubjectAdd(subjecttable);
                if (subject.Code == "1")
                    MessageBox.Show(subject.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please select or insert Informations");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                               "Вы правильно выбрали предмета?",
                               "Сообщение",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                SubjectController subjectController = new SubjectController();
                var subject = subjectController.SubjectDelete(id);
                if (subject.Code == "1")
                    MessageBox.Show(subject.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cbSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
             id = ((Subjecttable)cbSubjectName.Items[cbSubjectName.SelectedIndex]).Id;
        }

        private void cbKafedraName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSubjectName_MouseClick(object sender, MouseEventArgs e)
        {            
            cbSubjectName.SelectedIndexChanged += cbSubjectName_SelectedIndexChanged;
        }

        private void cbAuthor_MouseClick(object sender, MouseEventArgs e)
        {            
            cbAuthor.SelectedIndexChanged -= cbAuthor_SelectedIndexChanged;
        }

        private void cbKafedraName_MouseClick(object sender, MouseEventArgs e)
        {
            cbKafedraName.SelectedIndexChanged += cbKafedraName_SelectedIndexChanged;
        }
    }
}
