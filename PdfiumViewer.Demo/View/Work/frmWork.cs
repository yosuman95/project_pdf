using PdfiumViewer.Demo.Controller;
using PdfiumViewer.Demo.DTO.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PdfiumViewer.Demo.View
{
    public partial class frmWork : Form
    {
        private string typeWork;
        public static int id;
        public frmWork(string typeWork)
        {
            this.typeWork = typeWork;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbWorkName.Text.Length > 0)
            {
                String workName = tbWorkName.Text;
                WorkTable newwork = new WorkTable();
                WorkController workController = new WorkController();
                newwork.WorkName = workName;
                var work = workController.WorkAdd(newwork);
                if (work.Code == "1")
                    MessageBox.Show(work.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        private void frmWork_Load(object sender, EventArgs e)
        {
            tbWorkName.SelectedIndexChanged -= tbWorkName_SelectedIndexChanged;
            btnSave.Text = typeWork;
            if (typeWork.Equals("Update") || typeWork.Equals("Delete"))
            {
                WorkController workController = new WorkController();
                var work = workController.GetAllWorks();
                if (work.Code == "1")
                    MessageBox.Show(work.Description);
                else
                {
                    var response = (SuccessResponseWork)work;
                    tbWorkName.DataSource = response.WorkTables.ToList();
                }
            }
        }
        private void tbWorkName_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = ((WorkTable)tbWorkName.Items[tbWorkName.SelectedIndex]).Id;
          // MessageBox.Show(id.ToString());            
        }

        private void tbWorkName_Click(object sender, EventArgs e)
        {
            tbWorkName.SelectedIndexChanged += tbWorkName_SelectedIndexChanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                "Вы правильно выбрали работу ?",
                                "Сообщение",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                WorkController workController = new WorkController();
                var work = workController.WorkDelete(id);
                if (work.Code == "1")
                    MessageBox.Show(work.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbWorkName.Text.Length > 0)
            {               
                WorkTable newwork = new WorkTable();
                newwork.WorkName = tbWorkName.Text; ;
                newwork.Id = id;
                WorkController workController = new WorkController();         
                var work = workController.WorkUpdate(newwork);
                if (work.Code == "1")
                    MessageBox.Show(work.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please Select the work");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

        
