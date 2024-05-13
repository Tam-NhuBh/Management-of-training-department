using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Word = Microsoft.Office.Interop.Word;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class ManageForm : Form
    {
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        string cotID = "Ma Khoa Hoc";
        string cotName = "Ten Lop Hoc";
        string cotHour = "So Luong Gio";
        string cotMoTa = "Mo ta";
        string coutKihoc = "Hoc Ki";
        
        public ManageForm()
        {
            InitializeComponent();
        }
        public void fillDataGridview(string cmd = "SELECT * FROM Course")
        {
            
            dataGridViewCourse.ReadOnly = true;
            dataGridViewCourse.RowTemplate.Height = 80;
            dataGridViewCourse.DataSource = course.getAllCourse(cmd);

            txtVT.Text = (dataGridViewCourse.CurrentRow.Index + 1).ToString();
            txtMax.Text = (dataGridViewCourse.RowCount).ToString();
            //int index = Convert.ToInt32(dataGridViewCourse.CurrentRow.Index + 1);
            //dataGridViewCourse.Rows[index].Select = true;
            dataGridViewCourse.Columns[0].HeaderText = cotID;
            dataGridViewCourse.Columns[1].HeaderText = cotName;
            dataGridViewCourse.Columns[2].HeaderText = coutKihoc;
            dataGridViewCourse.Columns[3].HeaderText = cotHour;
            dataGridViewCourse.Columns[4].HeaderText = cotMoTa;
            
            label_total.Text = "Total Course: " + (dataGridViewCourse.Rows.Count );
        }
        private void btnPrivious_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(txtVT.Text);
            int Max = Convert.ToInt32(txtMax.Text);
            if ((temp) <= 1)
            {
                MessageBox.Show("You have selected the first box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnPrivious.Enabled = false;
            }



            if (temp == Max)
            {

                btnNext.Enabled = false;
            }
            if (temp == 1)
            {
                btnPrivious.Enabled = false;

            }
            if (temp <= Max && temp - 1 != 0)
            {
                temp = temp - 1;
                txtVT.Text = (temp).ToString();
                dataGridViewCourse.CurrentCell = dataGridViewCourse.Rows[temp - 1].Cells[0];
                int id = Convert.ToInt32(dataGridViewCourse.Rows[temp -1].Cells[0].Value.ToString());
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                txtId.Text = table.Rows[0][0].ToString();
                txtName.Text = table.Rows[0][1].ToString();
                numericUpDownkihoc.Value = Int32.Parse(table.Rows[0][2].ToString());
                numericUpDownHours.Value = Int32.Parse(table.Rows[0][3].ToString());
                rTxtDecription.Text = table.Rows[0][4].ToString();
                fillCombo(dataGridViewCourse.Rows[temp - 1].Index);

            }
            if (temp >= 1)
            {
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(txtVT.Text);
            int Max= Convert.ToInt32(txtMax.Text) ;
            if ((temp + 1) > Max)
            {
                MessageBox.Show("You have selected the last cell", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext.Enabled = false;
            }

            if (temp < Max)
            {
                btnPrivious.Enabled = true;
            }

            if (temp == Max)
            {

                btnNext.Enabled = false;
            }
            if (temp == 0)
            {
                btnPrivious.Enabled = false;

            }
            if (temp < Max && temp > 0)
            {
                temp = temp + 1;
                txtVT.Text = temp.ToString();

                dataGridViewCourse.CurrentCell = dataGridViewCourse.Rows[temp - 1].Cells[0];
                int id = Convert.ToInt32(dataGridViewCourse.Rows[temp - 1].Cells[0].Value.ToString());
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                txtId.Text = table.Rows[0][0].ToString();
                txtName.Text = table.Rows[0][1].ToString();
                numericUpDownkihoc.Value = Int32.Parse(table.Rows[0][2].ToString());
                numericUpDownHours.Value = Int32.Parse(table.Rows[0][3].ToString());
                rTxtDecription.Text = table.Rows[0][4].ToString();

                fillCombo(dataGridViewCourse.Rows[temp - 1].Index);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox1.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                txtId.Text = table.Rows[0][0].ToString();
                txtName.Text = table.Rows[0][1].ToString();
                numericUpDownkihoc.Value = Int32.Parse(table.Rows[0][2].ToString());
                numericUpDownHours.Value = Int32.Parse(table.Rows[0][3].ToString());
                rTxtDecription.Text = table.Rows[0][4].ToString();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            comboBox1.DisplayMember = "Label";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = course.getAllCourse();
            fillDataGridview();
        }
        public void fillCombo(int index = 0, string cmd = "SELECT * FROM Course")
        {

            comboBox1.DisplayMember = "Label";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = course.getAllCourse(cmd);

            comboBox1.SelectedIndex = index;
        }
        private void dataGridViewCourse_DoubleClick(object sender, EventArgs e)
        {
            fillCombo(dataGridViewCourse.CurrentRow.Index);
            txtId.Text = dataGridViewCourse.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridViewCourse.CurrentRow.Cells[1].Value.ToString();
            numericUpDownkihoc.Value = Int32.Parse(dataGridViewCourse.CurrentRow.Cells[2].Value.ToString());
            numericUpDownHours.Value = Convert.ToInt32( dataGridViewCourse.CurrentRow.Cells[3].Value.ToString());
            rTxtDecription.Text = dataGridViewCourse.CurrentRow.Cells[4].Value.ToString();
            txtVT.Text = (dataGridViewCourse.CurrentRow.Index + 1).ToString();
            txtMax.Text = (dataGridViewCourse.RowCount ).ToString();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddCourseForm AddCForm = new AddCourseForm();
            AddCForm.numericUpDownkihoc.Value = numericUpDownkihoc.Value;
            AddCForm.txtId.Text = txtId.Text;
            AddCForm.txtName.Text = txtName.Text;
            AddCForm.numericUpDownHours.Value = numericUpDownHours.Value;
            AddCForm.rTxtDecription.Text = rTxtDecription.Text;
            this.Hide();
            AddCForm.ShowDialog();
            
            this.Visible = true;
            fillDataGridview();
            fillCombo();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseld = Convert.ToInt32(txtId.Text);
                COURSE course = new COURSE();
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseld))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    fillDataGridview();
                    fillCombo();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Enter A Valid Numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fillDataGridview();
            fillCombo();
        }

        private void btntxt_Click(object sender, EventArgs e)
        {

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourse.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridViewCourse.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridViewCourse.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridViewCourse.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {

                                    pdfTable.AddCell(cell.Value.ToString());



                                }
                            }


                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            ExportWord();
        }

        private void ExportWord()
        {
            try
            {
                if (dataGridViewCourse.Rows.Count != 0)
                {
                    int RowCount = dataGridViewCourse.Rows.Count;
                    int ColumnCount = dataGridViewCourse.Columns.Count;
                    Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                    //add rows
                    int r = 0;
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        for (r = 0; r <= RowCount - 1; r++)
                        {
                            DataArray[r, c] = dataGridViewCourse.Rows[r].Cells[c].Value;
                        } //end row loop
                    } //end column loop

                    Word.Document oDoc = new Word.Document();
                    oDoc.Application.Visible = true;

                    //page orintation
                    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                    dynamic oRange = oDoc.Content.Application.Selection.Range;
                    string oTemp = "";
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        for (int c = 0; c <= ColumnCount - 1; c++)
                        {
                            
                            oTemp = oTemp + DataArray[r, c] + "\t";

                        }
                    }

                    //table format
                    oRange.Text = oTemp;

                    object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                    object ApplyBorders = true;
                    object AutoFit = true;
                    object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                    oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                          Type.Missing, Type.Missing, ref ApplyBorders,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                    oRange.Select();

                    oDoc.Application.Selection.Tables[1].Select();
                    oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                    oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.InsertRowsAbove(1);
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();

                    //header row style
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Name";
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    //add header row manually
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataGridViewCourse.Columns[c].HeaderText;
                    }

                    //table style 
                    oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    //header text
                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Text = "Student List";
                        headerRange.Font.Size = 16;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    
                    oDoc.Close();
                }
            }
            catch (Exception)
            {

                
                MessageBox.Show("No Record To Export !!!", "Info");
            }

            //save the file
            //oDoc.Application.ActiveWorkbook.Saved = true;


        }

        private void btn_search_Click_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_search.Text) != true)
            {
                string query = "select * from Course WHERE concat(ID,Label) LIKE'%" + textBox_search.Text + "%'";

                fillDataGridview(query);
            }
            else
                MessageBox.Show("Please fill in the ID information", "SEARCH ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //ham concat trong sql noi 2 hay nhieu chuoi thanh 1 chuoi lon
            
            //fillCombo(dataGridViewCourse.CurrentRow.Index, query);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EdiCourseForm EditCForm = new EdiCourseForm();

            EditCForm.numericUpDownkihoc.Value = numericUpDownkihoc.Value;
            EditCForm.txtName.Text = txtName.Text;
            EditCForm.numericUpDownHours.Value = numericUpDownHours.Value;
            EditCForm.rTxtDecription.Text = rTxtDecription.Text;
            this.Hide();
            EditCForm.ShowDialog();

            this.Visible = true;
            fillDataGridview();
            fillCombo();
        }
    }
}
