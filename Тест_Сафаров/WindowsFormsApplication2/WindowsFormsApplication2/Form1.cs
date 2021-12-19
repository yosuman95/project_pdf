using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String fileName;
        Excel.Application objApp;
        Excel._Workbook objBook;
        Excel.Workbooks objBooks;
        Excel.Sheets objSheets;
        Excel._Worksheet objSheet;
        public int QuationsQuantity = 3;
        string[] VariatLetters = new string[] { "A", "B", "C", "D", "E" };
        string[] answers;
        int[] userAnswers;
        Label[] labelQ;
        RadioButton[,] radioQA;
        Label[,] labelQA;
        FlowLayoutPanel[] FLPanel;
        TimeSpan time = new TimeSpan(0, 0, 20, 0);
        int k = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = true;
            answers = new string[QuationsQuantity];
            userAnswers = new int[QuationsQuantity];
            labelQ = new Label[QuationsQuantity];
            radioQA = new RadioButton[QuationsQuantity, 5];
            labelQA = new Label[QuationsQuantity, 5];
            FLPanel = new FlowLayoutPanel[QuationsQuantity];
            flowLayoutPanel1.Visible = true;


            for (int i = 0; i < QuationsQuantity; i++)
            {
                FLPanel[i] = new FlowLayoutPanel();
                FLPanel[i].Dock = System.Windows.Forms.DockStyle.Fill;
                FLPanel[i].AutoSize = true;
                FLPanel[i].AutoScroll = false;
                FLPanel[i].WrapContents = false;
                FLPanel[i].FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

                labelQ[i] = new Label();
                labelQ[i].AutoSize = true;
                labelQ[i].Font = new System.Drawing.Font("Palatino Linotype", 10.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelQ[i].Font = new Font(labelQ[i].Font, FontStyle.Bold);


                for (int j = 0; j < 5; j++)
                {
                    radioQA[i, j] = new RadioButton();
                    radioQA[i, j].Text = VariatLetters[j] + ".";
                    radioQA[i, j].ForeColor = Color.Chocolate;
                    radioQA[i, j].Font = new Font(radioQA[i, j].Font, FontStyle.Bold);
                }

                for (int j = 0; j < 5; j++)
                {
                    labelQA[i, j] = new Label();
                    labelQA[i, j].AutoSize = true;
                    labelQA[i, j].Font = new System.Drawing.Font(labelQA[i, j].Font.FontFamily, 10.00F);
                }

            }
           try
            {
                objApp = new Excel.Application();
                objBooks = objApp.Workbooks;
                objBook = objBooks.Add(fileName);
                objSheets = objBook.Worksheets;
                objSheet = (Excel._Worksheet)objSheets.get_Item(1);

                for (int i = 0; i < QuationsQuantity; i++)
                {
                    labelQ[i].Text =Convert.ToString(i+1)+") "+objSheet.Cells[i + 2, 2].Text.ToString();
                    answers[i] = objSheet.Cells[i + 2, 8].Text.ToString();
                    for (int j = 0; j < 5; j++)
                    {
                        labelQA[i, j].Text = objSheet.Cells[i + 2, j + 3].Text.ToString();
                    }
                    FLPanel[i].Controls.Add(labelQ[i]);
                    for (int j = 0; j < 5; j++)
                    {
                        FLPanel[i].Controls.Add(radioQA[i, j]);
                        FLPanel[i].Controls.Add(labelQA[i, j]);
                        
                    }
                    flowLayoutPanel1.Controls.Add(FLPanel[i]);
                }

                Label LabelInfo = new Label();
                LabelInfo.Text = "\n\n\n";
                flowLayoutPanel1.Controls.Add(LabelInfo);
            }
           catch (Exception theException)
           {
               MessageBox.Show("Error"+theException);
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            for (int i = 0; i < QuationsQuantity; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (radioQA[i, j].Checked)
                    {
                        userAnswers[i] = j + 1;
                    }
                }
            }
            foreach (RadioButton rd in radioQA)
                rd.Enabled = false;
            for (int i = 0; i < QuationsQuantity; i++)
            {
              labelQA[i, answersToInt(answers[i])-1].ForeColor = Color.Green;
              k++;
                if (answersToString(userAnswers[i]) != answers[i].Trim().ToUpper())
                {
                    k--;
                    if (userAnswers[i] != 0)
                    {
                        labelQA[i, userAnswers[i] - 1].ForeColor = Color.Red;
                      //  k--;
                    }
                }
            }

           // k = QuationsQuantity - k;
            lblOtvet.Text = "k="+k.ToString();

        }
        private string answersToString(int a)
        {
            string s = "";
            if (a == 1) s = "A";
            else if (a == 2) s = "B";
            else if (a == 3) s = "C";
            else if (a == 4) s = "D";
            else if (a == 5) s = "E";
            return s;
        }
        private int answersToInt(string s)
        {
            int i = 0;
            if (s.Equals("A")) i = 1;
            else if (s.Equals("B")) i = 2;
            else if (s.Equals("C")) i = 3;
            else if (s.Equals("D")) i = 4;
            else if (s.Equals("E")) i = 5;
            return i;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 1);
            time = time.Subtract(ts);
            textBox1.Text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
            if (Convert.ToDouble(time.Minutes.ToString()) == 0)
                button2.PerformClick();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            fileName = openFileDialog1.FileName;
        }

    }
}
