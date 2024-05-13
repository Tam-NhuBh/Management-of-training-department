using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using Xceed.Words.NET;
using Xceed.Document.NET;

using Font = Xceed.Document.NET.Font;
using Paragraph = Xceed.Document.NET.Paragraph;
using Image = Xceed.Document.NET.Image;

namespace WindowsFormsApp1
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            fillDataGridview();
            ExportChart(dataGridView1);
        }
        public void fillDataGridview(string cmd = "SELECT * FROM Course")
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = course.getAllCourse(cmd);
            
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[0].HeaderText = "Mã Lớp học";

            dataGridView1.Columns[1].HeaderText = "Tên Lớp";
            dataGridView1.Columns[2].HeaderText = "Kì Hoc";
            dataGridView1.Columns[3].HeaderText = "Số giờ học";
            dataGridView1.Columns[4].HeaderText = "Mô tả";


        }
        public void ExportChart(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                chart_Hour.Series["Hours"].Points.AddXY(row.Cells[1].Value.ToString(), row.Cells[3].Value);
            }
            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            fillDataGridview();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"E:\Course_list.txt";
            try
            {
                using (var writer = new StreamWriter(Path))
                {
                    if (!File.Exists(Path))
                    {
                        File.Create(Path);
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count ; j++)
                        {
                        
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");

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
        private void ExportWord(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                string fileName = @"E:\export_word_CourseSV.docx";
                var doc = DocX.Create(fileName);
                //doc.InsertParagraph("Hi Everyone");



                //Formatting Title  
                string title = "Your Course";

                //Formatting Title  
                // like using this we can set font family, font size, position, font color etc

                Formatting titleFormat = new Formatting();
                //Specify font family  
                titleFormat.FontFamily = new Font("Tahoma");
                //Specify font size  
                titleFormat.Size = 20D;
                titleFormat.Position = 40;
                titleFormat.FontColor = Color.BlueViolet;
                titleFormat.UnderlineColor = Color.Gray;
                titleFormat.Italic = true;


                //Formatting Title  
                string title2 = "Khoa Dao Tao CLC Tieng Anh";

                //Formatting Title  
                // like using this we can set font family, font size, position, font color etc

                Formatting titleFormat2 = new Formatting();
                //Specify font family  
                titleFormat2.FontFamily = new Font("Arial");
                //Specify font size  
                titleFormat2.Size = 20D;
                titleFormat2.Position = 40;
                titleFormat2.FontColor = Color.BlueViolet;
                titleFormat2.UnderlineColor = Color.Gray;
                titleFormat2.Italic = true;
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
                string textParagraph = "Danh Sach Lop Hoc ";

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

                //dataGridView1.Columns[2].HeaderText = "Ki Hoc";

                t.Rows[0].Cells[0].Paragraphs.First().Append("Mã Lớp học");
                t.Rows[0].Cells[1].Paragraphs.First().Append("Tên Lớp");
                t.Rows[0].Cells[2].Paragraphs.First().Append("Số Giờ Học");

                DateTime bdate;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        
                            t.Rows[i + 1].Cells[j].Paragraphs.First().Append(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        

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
    }
}
