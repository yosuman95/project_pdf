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
    public partial class frmRazdel : Form
    {
        private int id, idSubject;
        public frmRazdel()
        {
            InitializeComponent();
        }
        private void frmRazdel_Load(object sender, EventArgs e)
        {
            cbIdSubject.SelectedIndexChanged -= cbIdSubject_SelectedIndexChanged;
            cbPartName.SelectedIndexChanged -= cbPartName_SelectedIndexChanged;            
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
                cbIdSubject.DataSource = response.Subjecttables.ToList();                
            }
            cbIdSubject.Text = "";
            cbPartName.Text = "";
        }
        private void cbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPartName.SelectedIndex >= 0)
            {
                id = ((Razdeltable)cbPartName.Items[cbPartName.SelectedIndex]).Id;
            }
        }
        private void cbIdSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdSubject.SelectedIndex >= 0)
                idSubject = ((Subjecttable)cbIdSubject.Items[cbIdSubject.SelectedIndex]).Id;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int idSubject = 0;
            if (cbIdSubject.SelectedIndex >= 0)
                idSubject = (int)((Subjecttable)cbIdSubject.Items[cbIdSubject.SelectedIndex]).Id;

            if (idSubject > 0 && cbPartName.Text.Length > 0)
            {
                Razdeltable razdeltable = new Razdeltable();
                razdeltable.PartName = cbPartName.Text;
                razdeltable.IdSubject = idSubject;

                RazdelController razdelController = new RazdelController();
                var razdel = razdelController.AddRazdel(razdeltable);
                if (razdel.Code == "1")
                    MessageBox.Show(razdel.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please select or insert Informations");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {                     
            if (idSubject > 0 && id>0 && cbPartName.Text.Length > 0)
            {
                Razdeltable razdeltable = new Razdeltable();
                razdeltable.PartName = cbPartName.Text;
                MessageBox.Show(cbPartName.Text);
                razdeltable.IdSubject = idSubject;
                MessageBox.Show(idSubject.ToString());
                razdeltable.Id = id;

                RazdelController razdelController = new RazdelController();
                var razdel = razdelController.RazdelUpdate(razdeltable);
                if (razdel.Code == "1")
                    MessageBox.Show(razdel.Description);
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
                              "Вы правильно выбрали раздела?",
                              "Сообщение",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information,
                              MessageBoxDefaultButton.Button1,
                              MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                RazdelController razdelController = new RazdelController();
                int id= ((Razdeltable)cbPartName.Items[cbPartName.SelectedIndex]).Id;
                var razdel = razdelController.RazdelDelete(id);
                if (razdel.Code == "1")
                    MessageBox.Show(razdel.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        private void cbPartName_MouseClick(object sender, MouseEventArgs e)
        {
            cbPartName.SelectedIndexChanged += cbPartName_SelectedIndexChanged;
        }
        private void cbIdSubject_MouseClick(object sender, MouseEventArgs e)
        {
            cbIdSubject.SelectedIndexChanged += cbIdSubject_SelectedIndexChanged;
        }
    }
}
