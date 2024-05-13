using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

using Xceed.Words.NET;
using Xceed.Document.NET;

using Font = Xceed.Document.NET.Font;
using Paragraph = Xceed.Document.NET.Paragraph;
using Image = Xceed.Document.NET.Image;

namespace WindowsFormsApp1
{
    public partial class PrintStudentFrom : Form
    {
        STUDENT student = new STUDENT();
        public PrintStudentFrom()
        {
            InitializeComponent();
        }

        //phương thức thực hiện điền dl vào datagridview
        public void fillDataGridview(SqlCommand cmd)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudent(cmd);
            //cột 7 là ảnh đổ từ database
            picol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;


            dataGridView1.Columns[0].HeaderText = "Mã Học Sinh";

            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[2].HeaderText = "Họ và Tên Lót";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Giới Tính";
            dataGridView1.Columns[5].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[6].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[7].HeaderText = "Hình Ảnh";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy-dd-MM";
        }

        private void PrintStudentFrom_Load(object sender, EventArgs e)
        {
            fillDataGridview(new SqlCommand("SELECT * FROM Student"));
            if (radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;

            }
            
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }
        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonYes.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                
            }

        }
        private void btnGO_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string query;
            if (radioButtonYes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM Student WHERE  BirthDate BETWEEN '" + date1 + "' And '" + date2 + "' And Gender = 'Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM Student Where BirthDate BETWEEN  '" + date1 + "' And '" + date2 + "' And Gender = 'Female'";

                }
                else
                {
                    query = "SELECT * FROM Student Where BirthDate BETWEEN '" + date1 + "' And '" + date2 + "'" ;
                }
                command = new SqlCommand(query);
                fillDataGridview(command);
            }
            else
            {
                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM Student WHERE  Gender = 'Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM Student Where  Gender = 'Female'";

                }
                else
                {
                    query = "SELECT * FROM Student ";
                }
                command = new SqlCommand(query);
                fillDataGridview(command);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\students_list.txt";
            try
            {
                using (var writer = new StreamWriter(Path))
                {
                    if (!File.Exists(Path))
                    {
                        File.Create(Path);
                    }
                    DateTime bdate;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            if (j == 3)
                            {
                                bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                            }
                            else if (j == dataGridView1.Columns.Count - 2)
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());

                            }
                            else
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");

                            }

                        }
                        writer.WriteLine("");
                        writer.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }

                    writer.Close();
                    MessageBox.Show("Data Exported");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data not Exported");

            }
            

        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            
                try
                {
                    ExportWord(dataGridView1);
                    MessageBox.Show("File export successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed!\n" + ex.Message);
                }
            

        }
        // Tham khao :https://laptrinhvb.net/bai-viet/ebook-it/---Csharp----Huong-dan-tao-file-Microsoft-Word-paragraph,-table,-image,-hyperlink-su-dung-DocX/a65dd247ba3c5e4a.html
        // Hung channel
        private void ExportWord(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                string fileName = @"E:\export_word_listSV.docx";
                var doc = DocX.Create(fileName);
                //doc.InsertParagraph("Hi Everyone");



                //Formatting Title  
                string title = "Khoa Dao Tao CLC Tieng Anh";

                //Formatting Title  
                // like using this we can set font family, font size, position, font color etc

                Formatting titleFormat = new Formatting();
                //Specify font family  
                titleFormat.FontFamily = new Font("Arial");
                //Specify font size  
                titleFormat.Size = 20D;
                titleFormat.Position = 40;
                titleFormat.FontColor = Color.BlueViolet;
                titleFormat.UnderlineColor = Color.Gray;
                titleFormat.Italic = true;
                //Formatting Title  
                // like using this we can set font family, font size, position, font color etc

                

                




                #region three
                //Create a picture  
                // Cải tiến sử dụng hình ảnh logo trên form thay vì ảnh đường dẫn

                string workingDirectory = Environment.CurrentDirectory;
                string Dir = Directory.GetParent(workingDirectory).Parent.FullName;
                string path2 = Dir + "\\Resources\\logoCLCCircle.png";
                var img = doc.AddImage(path2);

                Picture Pictest2 = img.CreatePicture();
                Pictest2.Height = 150;
                Pictest2.Width = 150;
                //Create a new paragraph  
                titleFormat.FontColor = Color.Orange;
                Paragraph par = doc.InsertParagraph();
                par.AppendPicture(Pictest2);
                par.Alignment = Alignment.center;
                #endregion

                // string Date
                string dateCrea = "Ho Chi Minh City, " + DateTime.Now.ToString("MM/dd/yyyy");
                Formatting dateCreaFormat = new Formatting();
                //Specify font family  
                dateCreaFormat.FontFamily = new Font("Arial");
                //Specify font size  
                dateCreaFormat.Size = 14D;
                // dateCreaFormat.Position = 20;
                dateCreaFormat.FontColor = Color.BlueViolet;

                Paragraph pardateCrea = doc.InsertParagraph(dateCrea, false, dateCreaFormat);
                pardateCrea.Alignment = Alignment.right;

                //Formatting Title



                //Text  
                string textParagraph = "Danh Sach Sinh vien ";

                //Formatting Text Paragraph  
                Formatting textParagraphFormat = new Formatting();
                //font family  
                textParagraphFormat.FontFamily = new Font("Tahoma");
                //font size  
                textParagraphFormat.Size = 12D;
                //Spaces between characters  
                textParagraphFormat.Spacing = 1;
                //Insert title  
                Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
                paragraphTitle.Alignment = Alignment.center;
                //Insert text  
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);





                doc.InsertParagraph();
                //Create Table

                Table t = doc.AddTable(dataGridView1.Rows.Count + 1, dataGridView1.Columns.Count);

                t.Alignment = Alignment.center;
                t.Design = TableDesign.ColorfulList;
                t.Rows[0].Cells[0].Paragraphs.First().Append("Ma SV");
                t.Rows[0].Cells[1].Paragraphs.First().Append("Ten");
                t.Rows[0].Cells[2].Paragraphs.First().Append("Ho");
                t.Rows[0].Cells[3].Paragraphs.First().Append("Ngay Sinh");
                t.Rows[0].Cells[4].Paragraphs.First().Append("Gioi Tinh");
                t.Rows[0].Cells[5].Paragraphs.First().Append("So dien thoai");
                t.Rows[0].Cells[6].Paragraphs.First().Append("Dia chi");
                t.Rows[0].Cells[7].Paragraphs.First().Append("Anh dai dien");
                DateTime bdate;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == 7)
                        {

                            byte[] pic;
                            pic = (byte[])dataGridView1.Rows[i].Cells[j].Value;
                            MemoryStream str = new MemoryStream();
                            str.Write(pic, 0, pic.Length);
                            Bitmap bit = new Bitmap(str);



                            string path = @"E:\bitmap1.bmp";
                            bit.Save(path);
                            string imagString = path;
                            Image imgtemp = doc.AddImage(path);

                            Picture Pictest = imgtemp.CreatePicture();
                            Pictest.Height = 40;
                            Pictest.Width = 40;
                            t.Rows[i + 1].Cells[j].Paragraphs.First().AppendPicture(Pictest);
                            File.Delete(path);
                        }
                        else if(j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            t.Rows[i + 1].Cells[j].Paragraphs.First().Append(bdate.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            t.Rows[i + 1].Cells[j].Paragraphs.First().Append(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }

                    }
                }

                // Fill cells by adding text.  
                // First row


                doc.InsertTable(t);


                //#region five
                //// Hyperlink
                //Hyperlink url = doc.AddHyperlink("My Youtube Channel", new Uri("https://www.youtube.com/channel/UC0s4YRzr1oDMqH8P393nhtw"));
                //Paragraph p1 = doc.InsertParagraph();
                //p1.AppendLine("Please visit:  ").Bold().AppendHyperlink(url).Color(Color.Orange); // Hyperlink in blue color 
                //#endregion



                #region part of one
                doc.Save();

                #endregion
            }
        }
        
        
        
        // Tham khao http://www.nullskull.com/q/8506/how-to-insert-a-picture-into-excel-using-c.aspx
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = " Export Excel";
            saveFileDialog.Filter = "Execl files (*.xls)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                    ExportExcel(saveFileDialog.FileName);
                   
            }
            
        }
        
        private void ExportExcel(string pathE)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xcelApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                DateTime bdate;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if(j == 3)
                        {
                            
                                bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                xcelApp.Cells[i + 2, j + 1] = bdate.ToString("yyyy-MM-dd");
                            
                        }
                        else if (j == 7)
                        {

                            byte[] pic;
                            pic = (byte[])dataGridView1.Rows[i].Cells[j].Value;
                            MemoryStream str = new MemoryStream();
                            str.Write(pic, 0, pic.Length);
                            Bitmap bit = new Bitmap(str);

                            //xcelApp.Cells[i + 2, j + 1] = bit;
                            // You have to get original bitmap path here


                            string path = @"E:\bitmap1.bmp";
                            bit.Save(path);
                            string imagString = path;
                            Excel.Range oRange = (Excel.Range)xlWorkSheet.Cells[i + 2, j + 1];
                            float Left = (float)((double)oRange.Left);
                            float Top = (float)((double)oRange.Top);
                            const float ImageSize = 40;
                            xlWorkSheet.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                            oRange.RowHeight = ImageSize + 2;
                            File.Delete(path);
                        }
                        else
                        {
                            xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }

                    }
                }
                xcelApp.Columns.AutoFit();

                //xcelApp.Visible = true;
                xlWorkBook.SaveAs(pathE);
                xlWorkBook.Close();
                MessageBox.Show("Excel file created !!!  ");



            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception Occured", ex.Message);
            }
        }

        

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
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

                            exportPDF(sfd.FileName);
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
        private void exportPDF(string FileName)
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 7)
                    {
                        //Paragraph paragraph = new Paragraph();
                        byte[] pic;
                        pic = (byte[])cell.Value;
                        MemoryStream picture = new MemoryStream(pic);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(picture);
                        iTextSharp.text.Image ItextImage = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Jpeg);
                        ItextImage.Alignment = Element.ALIGN_CENTER;

                        pdfTable.AddCell(ItextImage);

                        //pdfTable.Close();
                    }
                    else
                        pdfTable.AddCell(cell.Value.ToString());



                }
            }


            using (FileStream stream = new FileStream(FileName, FileMode.Create))
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 20f, 20f, 10f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }
    }
}
