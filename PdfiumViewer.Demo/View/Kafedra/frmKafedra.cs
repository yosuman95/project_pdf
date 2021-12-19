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

namespace PdfiumViewer.Demo.View.Kafedra
{
    public partial class frmKafedra : Form
    {
        private string typeWork;
        private static int id;

        public frmKafedra(string typeWork)
        {
            this.typeWork = typeWork;           
            InitializeComponent();
        }

        private void frmKafedra_Load(object sender, EventArgs e)
        {
            cbKafedraName.SelectedIndexChanged -= cbKafedraName_SelectedIndexChanged;            
            if (typeWork.Equals("Update") || typeWork.Equals("Delete"))
            {
                KafedraController kafedraController = new KafedraController();
                var kafedra = kafedraController.GetAllKafedra();
                if (kafedra.Code == "1")
                    MessageBox.Show(kafedra.Description);
                else
                {
                    var response = (SuccessResponseKafedra)kafedra;
                    cbKafedraName.DataSource = response.Kafedratables.ToList();
                }
            }
        }
        private void cbKafedraName_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = ((Kafedratable)cbKafedraName.Items[cbKafedraName.SelectedIndex]).Id;
          //  MessageBox.Show(id.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbKafedraName.Text.Length > 0)
            {
                String kafName = cbKafedraName.Text;
                Kafedratable kafedratable = new Kafedratable();
                KafedraController kafedraController = new KafedraController();
                kafedratable.KafName = kafName;
                var kafedra = kafedraController.KafedraAdd(kafedratable);
                if (kafedra.Code == "1")
                    MessageBox.Show(kafedra.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbKafedraName.Text.Length > 0)
            {
                String kafName = cbKafedraName.Text;
                Kafedratable kafedratable = new Kafedratable();
                KafedraController kafedraController = new KafedraController();
                kafedratable.KafName = kafName;
                kafedratable.Id = id;
                var kafedra = kafedraController.KafedraUpdate(kafedratable);
                if (kafedra.Code == "1")
                    MessageBox.Show(kafedra.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
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
                var kafedra = kafedraController.KafedraDelete(id);
                if (kafedra.Code == "1")
                    MessageBox.Show(kafedra.Description);
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cbKafedraName_MouseClick(object sender, MouseEventArgs e)
        {
            cbKafedraName.SelectedIndexChanged += cbKafedraName_SelectedIndexChanged;
        }
    }
}
