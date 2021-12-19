using PdfiumViewer.Demo.Controller;
using PdfiumViewer.Demo.DTO.Data;
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
    public partial class frmAdd : Form
    {
        private String typeWork;
        public int idKafedra, idSubject, idRazdel, idWork;
        public frmAdd(String typeWork)
        {
            InitializeComponent();
            this.typeWork = typeWork;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int width = this.Width;
            pSubject.Width = width / 4;
            pControlls.Width = width / 4;
            pKafedra.Width = width / 4;
            pRazdel.Width = width / 4;
            pWork.Width = width / 4;

            pAddKafedra.Width = width / 4;
            pAddSubject.Width = width / 4;
            pRazdelAdd.Width = width / 4;
            pAddSubject.Width = width / 4;

            if (typeWork.Equals("Edit"))
            {
                btnAddKafedra.Text = "Edit";
                btnSaveRazdel.Text = "Edit";
                btnSaveSubject.Text = "Edit";
                button2.Text = "Edit";

            }
            KafedraToList();
            try
            {               
                WorkController workController = new WorkController();
                var work = workController.GetAllWorks();
                if (work.Code == "1")
                    MessageBox.Show(work.Description);
                else                    
                {
                    var response = (SuccessResponseWork)work;
                    cbWork.DataSource = response.WorkTables.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KafedraToList()
        {
            try
            {
                KafedraController kafedraController = new KafedraController();
                var kafedra = kafedraController.GetAllKafedra();
                if (kafedra.Code == "1")
                    MessageBox.Show(kafedra.Description);
                else
                {
                    var response = (SuccessResponseKafedra)kafedra;                  
                    lbKafedra.DataSource = response.Kafedratables.ToList();
                }             
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void SubjectsToList(int id)
        {
            try
            {             
                SubjectController subjectController = new SubjectController();
                var subject = subjectController.GetAllSubjectsByIdKaf(id);
                if (subject.Code == "1")
                    MessageBox.Show(subject.Description);
                else
                {
                    var response = (SuccessResponseSubject)subject;
                    lbSubject.DataSource = response.Subjecttables.ToList();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void RazdelsToList(int id)
        {
            try
            {
                RazdelController razdelController = new RazdelController();
                var razdel = razdelController.GetAllRazdelBySubject(id);
                if (razdel.Code == "1")
                    MessageBox.Show(razdel.Description);
                else
                {
                    var response = (SuccessResponseRazdel)razdel;
                    cbRazdel.DataSource = response.Razdeltables.ToList();
                    lbRazdel.DataSource = response.Razdeltables.ToList();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void WorksToList(int id)
        {
            try
            {
                WorkController workController = new WorkController();
                var work = workController.GetAllWorksById(id);
                if (work.Code == "1")
                    MessageBox.Show(work.Description);
                else
                {
                    var response = (SuccessWorkResponseonlyName)work;
                    lbWork.DataSource = response.WorkTables.ToList();
                }               
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnAddKafedra_Click(object sender, EventArgs e)
        {
            if (tbKafedra.Text.Length <= 1)
            {
                MessageBox.Show("Kafedra Name=?");
            }
            else
            {                
                Kafedratable kafedratable = new Kafedratable();
                KafedraController kafedraController = new KafedraController();
                kafedratable.KafName = tbKafedra.Text; ;
                if (btnAddKafedra.Text.Equals("Save"))
                {                                        
                    var kafedra = kafedraController.KafedraAdd(kafedratable);
                    if (kafedra.Code == "1")
                        MessageBox.Show(kafedra.Description);
                    else
                        MessageBox.Show("Added Kafedra");
                }
                else
                {
                    if (idKafedra != 0)
                    {
                        kafedratable.Id = idKafedra;
                        var kafedra = kafedraController.KafedraUpdate(kafedratable);
                        if (kafedra.Code == "1")
                            MessageBox.Show(kafedra.Description);
                        else
                            MessageBox.Show("Added Kafedra");
                        MessageBox.Show("Updated Kafedra");
                    }
                }

                tbKafedra.Clear();

                KafedraToList();
            }
        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            if (tbidKafedra.Text.Length <= 0)
            {
                MessageBox.Show("Please select Kafedra");
            }
            else if (tbSubject.Text.Length < 1)
            {
                MessageBox.Show(" Please Entered Subject Name");
            }
            else if ((tbidKafedra.Text.Length > 0) && (tbSubject.Text.Length > 0))
            {                
                Subjecttable subjecttable = new Subjecttable();
                subjecttable.SubjectName = tbSubject.Text.Trim();
                subjecttable.IdKaf = Convert.ToInt32(tbidKafedra.Text);

                SubjectController subjectController = new SubjectController();
                var subject = subjectController.SubjectAdd(subjecttable);
                if (subject.Code == "1")
                    MessageBox.Show(subject.Description);
                else
                {
                    MessageBox.Show("Ok");
                    SubjectsToList(Convert.ToInt32(tbidKafedra.Text));
                }
            }
        }       

       private void lbKafedra_MouseClick(object sender, MouseEventArgs e)
        {
            Kafedratable kafedra = (Kafedratable)lbKafedra.Items[lbKafedra.SelectedIndex];
            idKafedra = kafedra.Id;
            if (idKafedra > 0)
            {

                tbidKafedra.Text = idKafedra.ToString();
                SubjectsToList(idKafedra);
                tbKafedra.Text = lbKafedra.GetItemText(lbKafedra.SelectedValue);
            }

        }

        private void lbSubject_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbSubject.SelectedIndex >= 0)
            {
                Subjecttable subject = (Subjecttable)lbSubject.Items[lbSubject.SelectedIndex];
                idSubject = subject.Id;
                if (idSubject > 0)
                {
                    RazdelsToList(idSubject);
                    tbidSubject.Text = idSubject.ToString();
                    tbSubject.Text = lbSubject.GetItemText(lbSubject.SelectedValue);
                }
            }
        }

        private void lbRazdel_MouseClick(object sender, MouseEventArgs e)
        {
            Razdeltable razdel = (Razdeltable)lbRazdel.Items[lbRazdel.SelectedIndex];
            idRazdel = razdel.Id;
            if (idRazdel > 0)
            {              
                tbRazdelName.Text = lbRazdel.GetItemText(lbRazdel.SelectedValue);
                WorksToList(idRazdel);
            }
        }
        private void btnSaveRazdel_Click(object sender, EventArgs e)
        {
            if (tbidSubject.Text.Length <= 0)
            {
                MessageBox.Show("Please select Subject");
            }
            else if (tbRazdelName.Text.Length < 1)
            {
                MessageBox.Show(" Please Entered Razdel Name");
            }
            else if ((tbidSubject.Text.Length > 0) && (tbRazdelName.Text.Length > 0))
            {
                int id = Convert.ToInt32(tbidSubject.Text);
                String razdelName = tbRazdelName.Text.Trim();
                Razdeltable razdeltable = new Razdeltable();
                razdeltable.IdSubject = id;
                razdeltable.PartName = razdelName;                
                if (btnSaveRazdel.Text.Equals("Save"))
                {                    
                    RazdelController razdelController = new RazdelController();
                    var razdel = razdelController.AddRazdel(razdeltable);
                    if (razdel.Code == "1")
                        MessageBox.Show(razdel.Description);
                    else
                    {
                        MessageBox.Show("Ok");
                    }                 
                }
                else
                {
                    if (idRazdel != 0)
                    {                        
                        RazdelController razdelController = new RazdelController();
                        razdeltable.Id = idRazdel;
                        var razdel = razdelController.RazdelUpdate(razdeltable);

                        if (razdel.Code == "1")
                            MessageBox.Show(razdel.Description);
                        else
                        {
                            MessageBox.Show("Ok");
                        }
                    }
                }
                RazdelsToList(id);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbRazdel.Text.Length <= 0)
            {
                MessageBox.Show("Please select Razdel");
            }
            else if (cbWork.Text.Length < 1)
            {
                MessageBox.Show(" Please Select Work");
            }
            else if ((cbRazdel.Text.Length > 0) && (cbWork.Text.Length > 0))
            {
                String RazdelName = cbRazdel.Text;
                String WorkName = cbWork.Text;

              /*  int idWork = WorkController.getidWorkbyName(WorkName);
                int idRazdel = RazdelController.getidRazdelName(RazdelName);
                SourceController.AddSource(idRazdel, idWork);*/


                String subject = lbSubject.GetItemText(lbSubject.SelectedValue);


                String razdel = lbRazdel.GetItemText(lbRazdel.SelectedValue);

                String typework = lbWork.GetItemText(lbWork.SelectedValue);


                String filename = subject + "\\" + razdel + "_" + typework + ".pdf";

                string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\PDFFiles\\";

                if (!Directory.Exists(wanted_path + "\\" + subject))
                    Directory.CreateDirectory(wanted_path + "\\" + subject);

                String curfileName = wanted_path + filename;

                String sourceFile = tbFileNameBrowser.Text;

                if (!System.IO.File.Exists(curfileName))
                    System.IO.File.Move(sourceFile, curfileName);
                else
                    MessageBox.Show("File is exists");

                WorksToList(idRazdel);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                               "Вы правильно выбрали кафедру ?",
                               "Сообщение",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                KafedraController kafedraController = new KafedraController();
                var kafedra = kafedraController.KafedraDelete(idKafedra);
                if (kafedra.Code == "1")
                    MessageBox.Show(kafedra.Description);
                else
                    MessageBox.Show("Added Kafedra");
            }
        }

        private void lbKafedra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowser_Click_1(object sender, EventArgs e)
        {

        }

        private void lbWork_MouseClick(object sender, MouseEventArgs e)
        {
            String workName = lbWork.GetItemText(lbWork.SelectedValue);
            string razdelName = lbRazdel.GetItemText(lbRazdel.SelectedValue);
            cbRazdel.Text = razdelName;
            //tbIdWork.Text = workName;  


        }


        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
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
                tbFileNameBrowser.Text = openFileDialog1.FileName;

            }

        }



        private void btnSaveSubject_Click_1(object sender, EventArgs e)
        {
            if (tbidKafedra.Text.Length <= 0)
            {
                MessageBox.Show("Please select Kafedra");
            }
            else if (tbSubject.Text.Length < 1)
            {
                MessageBox.Show(" Please Entered Subject Name");
            }

            else if ((tbidKafedra.Text.Length > 0) && (tbSubject.Text.Length > 0))
            {

                int id = Convert.ToInt32(tbidKafedra.Text);
                String SubjectName = tbSubject.Text.Trim();
                Subjecttable subjecttable = new Subjecttable();
                subjecttable.SubjectName = SubjectName;
                subjecttable.IdKaf = id;
                if (btnSaveSubject.Text.Equals("Save"))
                {
                    SubjectController subjectController = new SubjectController();
                    var subject = subjectController.SubjectAdd(subjecttable);
                    if (subject.Code == "1")
                        MessageBox.Show(subject.Description);
                    else
                        MessageBox.Show("Save ");
                }

                else
                {
                    if (idSubject != 0)
                    {
                        SubjectController subjectController = new SubjectController();
                        subjecttable.Id= ((WorkTable)lbSubject.Items[lbSubject.SelectedIndex]).Id;
                        var subject = subjectController.SubjectUpdate(subjecttable);
                        if (subject.Code == "1")
                            MessageBox.Show(subject.Description);
                        else
                            MessageBox.Show("Save ");                        
                        MessageBox.Show("Edit");
                    }

                }             
                SubjectsToList(id);
            }
        }
    }
}

