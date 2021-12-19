using PdfiumViewer.Demo.Controller;
using PdfiumViewer.Demo.DTO.Data;
using PdfiumViewer.Demo.View.File;
using PdfiumViewer.Demo.View.Kafedra;
using PdfiumViewer.Demo.View.Subject;
using Students.DTO.Data;
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

namespace PdfiumViewer.Demo.View
{
    public partial class frmMain : Form
    {
        private String typeWork;
        public frmMain()
        {
            InitializeComponent();
        }
        public Subjecttable subjects;
        public Razdeltable razdels;
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int width = this.Width;
            flowLayoutPanel1.Width = width / 4;
            flowLayoutPanel2.Width = width / 4;
            flowLayoutPanel3.Width = width / 4;
            flowLayoutPanel4.Width = width / 4;
            lstKafedra.Width = width / 4;
            lstSubjects.Width = width / 4;
            lstRazdel.Width = width / 4;
            lsttypework.Width = width / 4;

            KafedraController kafedraController = new KafedraController();
            var kafedra = kafedraController.GetAllKafedra();
            if (kafedra.Code == "1")
                MessageBox.Show(kafedra.Description);
            else
            {
                var response = (SuccessResponseKafedra)kafedra;
                lstKafedra.DataSource = response.Kafedratables.ToList();
            }
        }
        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstKafedra_SelectedIndexChanged(object sender, EventArgs e)
        {
            // var kafedra = getInformation.GetAllKafedra();
            /*int id = Select id from  kafedra
                where ;*/

            //  String item = "Информатика и ИТ"; //lstKafedra.DisplayMember..ToString();
            // MessageBox.Show(item);
            //int id = 1;
            // lstSubjects.DataSource = getInformation.GetAllSubjects(id);
            // lstSubjects.DisplayMember = "SubjectName";


        }


        private void lstKafedra_MouseClick(object sender, MouseEventArgs e)
        {
            Kafedratable kafedra = (Kafedratable)lstKafedra.Items[lstKafedra.SelectedIndex];
            int id = kafedra.Id;
            if (id > 0)
            {
                SubjectController subjectController = new SubjectController();
                var subject = subjectController.GetAllSubjectsByIdKaf(id);
                if (subject.Code == "1")
                    MessageBox.Show(subject.Description);
                else
                {
                    var response = (SuccessResponseSubject)subject;
                    lstSubjects.DataSource = response.Subjecttables.ToList();
                }
            }
        }
        private void lstSubjects_MouseClick(object sender, MouseEventArgs e)
        {
            Subjecttable subject = (Subjecttable)lstSubjects.Items[lstSubjects.SelectedIndex];
            int id = subject.Id;
            if (id > 0)
            {
                RazdelController razdelController = new RazdelController();
                var razdel = razdelController.GetAllRazdelBySubject(id);
                if (razdel.Code == "1")
                    MessageBox.Show(razdel.Description);
                else
                {
                    var response = (SuccessResponseRazdel)razdel;
                    lstRazdel.DataSource = response.Razdeltables.ToList();
                }
            }
        }
        private void lstRazdel_MouseClick(object sender, MouseEventArgs e)
        {
            Razdeltable razdel = (Razdeltable)lstRazdel.Items[lstRazdel.SelectedIndex];
            int id = razdel.Id;
            if (id > 0)
            {
                WorkController workController = new WorkController();
                var work = workController.GetAllWorksById(id);
                if (work.Code == "1")
                    MessageBox.Show(work.Description);
                else
                {
                    var response = (SuccessWorkResponseonlyName)work;
                    lsttypework.DataSource = response.WorkTables.ToList();
                }
            }
        }

        private void lsttypework_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * 
              using (booksdbstoreContext db = new booksdbstoreContext())
            {
                var works = (from source in db.Sourcetable
                         join work in db.WorkTable on source.IdWork equals work.Id
                         orderby work.Id
                         select new 
                         {
                             work.WorkName,
                             work.Id                             
                         }).ToList();

             
            }
             * */
        }



        private void lsttypework_MouseClick(object sender, MouseEventArgs e)
        {

            String subject = lstSubjects.GetItemText(lstSubjects.SelectedValue);


            String razdel = lstRazdel.GetItemText(lstRazdel.SelectedValue);

            String typework = lsttypework.GetItemText(lsttypework.SelectedValue);

            String filename = subject + "\\" + razdel + "_" + typework;


            MainForm frm = new MainForm(filename);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected = lstKafedra.GetItemText(lstKafedra.SelectedValue);
            MessageBox.Show(selected);

        }

        private void addKafedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeWork = "Add";
            frmAdd frm = new frmAdd(typeWork);
            frm.ShowDialog();

        }

        private void lstKafedra_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void addWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeWork = "Save";
            using (var form = new frmWork(typeWork))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                    //     typeWork = "Edit";

                }
            }
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeWork = "Save";
            frmAdd frm = new frmAdd(typeWork);
            frm.ShowDialog();
        }

        private void addRazdelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeWork = "Edit";
            frmWork frm = new frmWork(typeWork);
            frm.ShowDialog();
        }

        private void lsttypework_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void newWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeWork = "Save";
            using (var form = new frmWork(typeWork))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void updateWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeWork = "Update";
            using (var form = new frmWork(typeWork))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void deleteWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeWork = "Delete";
            using (var form = new frmWork(typeWork))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void addKafedraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            typeWork = " ";
            using (var form = new frmKafedra(typeWork))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void updateKafedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeWork = "Update";
            using (var form = new frmKafedra(typeWork))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void deleteKafedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeWork = "Delete";
            using (var form = new frmKafedra(typeWork))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void newSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmSubject())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void updateSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmSubject())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void deleteSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmSubject())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void newRazdelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmRazdel())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }
        private void updateRazdelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmRazdel())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }
        private void deleteRazdelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmRazdel())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmFile())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("All Ok");
                }
            }
        }
    }
}

