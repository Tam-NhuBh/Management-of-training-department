using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Font = Xceed.Document.NET.Font;
using Paragraph = Xceed.Document.NET.Paragraph;
using Image = Xceed.Document.NET.Image;
using System.IO;

namespace WindowsFormsApp1.Print
{
    internal class PrintWord
    {
        public void ExportWord(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                string fileName = @"E:\export_word_ScoreInCourse.docx";
                var doc = DocX.Create(fileName);
                //doc.InsertParagraph("Hi Everyone");



                //Formatting Title  
                string title = "Score in your Course ";

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
                //Insert title  
                Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
                paragraphTitle.Alignment = Alignment.center;

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
                Paragraph par = doc.InsertParagraph(title2, false, titleFormat2);
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
                string textParagraph = "Score in your Course ";

                //Formatting Text Paragraph  
                Formatting textParagraphFormat = new Formatting();
                //font family  
                textParagraphFormat.FontFamily = new Font("Tahoma");
                //font size  
                textParagraphFormat.Size = 12D;
                //Spaces between characters  
                textParagraphFormat.Spacing = 1;
                
                //Insert text  
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);






                //Create Table

                Table t = doc.AddTable(dataGridView1.Rows.Count + 1, dataGridView1.Columns.Count);

                t.Alignment = Alignment.center;
                t.Design = TableDesign.ColorfulList;



                t.Rows[0].Cells[0].Paragraphs.First().Append("Ma SV");
                t.Rows[0].Cells[1].Paragraphs.First().Append("Ten");
                t.Rows[0].Cells[2].Paragraphs.First().Append("Ho");
                t.Rows[0].Cells[3].Paragraphs.First().Append("Diem");
                t.Rows[0].Cells[4].Paragraphs.First().Append("Mo Ta");
                t.Rows[0].Cells[5].Paragraphs.First().Append("Image");

                DateTime bdate;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == 5)
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



               // #region part of one
                doc.Save();

                //#endregion
            }
            else
                MessageBox.Show("No data to print");
        }
        public void ExportScoreStudentWord(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                string fileName = @"E:\export_word_ScoreOfStudent.docx";
                var doc = DocX.Create(fileName);
                //doc.InsertParagraph("Hi Everyone");



                //Formatting Title  
                string title = "Your Soure ";

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
                string textParagraph = "Score in your Courses ";

                //Formatting Text Paragraph  
                Formatting textParagraphFormat = new Formatting();
                //font family  
                textParagraphFormat.FontFamily = new Font("Tahoma");
                //font size  
                textParagraphFormat.Size = 12D;
                //Spaces between characters  
                textParagraphFormat.Spacing = 1;
                
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
                t.Rows[0].Cells[3].Paragraphs.First().Append("Ma Lop");
                t.Rows[0].Cells[4].Paragraphs.First().Append("Ten Lop");
                t.Rows[0].Cells[5].Paragraphs.First().Append("Diem");
                t.Rows[0].Cells[6].Paragraphs.First().Append("Mo Ta");

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
        public void ExportScoreAStudentWord(DataGridView dataGridView1, string nameStudent, string IdStudent, string avgScore, int pass, int fail, List<int> listSemester)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                string fileName = @"E:\export_word_ScoreOfAStudent.docx";
                var doc = DocX.Create(fileName);
                //doc.InsertParagraph("Hi Everyone");



                //Formatting Title  
                string title = "University of Technology and Education HCM ";

                //Formatting Title  
                // like using this we can set font family, font size, position, font color etc

                Formatting titleFormat = new Formatting();
                //Specify font family  
                titleFormat.FontFamily = new Font("Arial");
                //Specify font size  
                titleFormat.Size = 26D;
                titleFormat.Position = 20;
                titleFormat.FontColor = Color.Blue;

                Paragraph parTitle =doc.InsertParagraph(title, false, titleFormat);
                parTitle.Alignment = Alignment.center;


                

                #region three
                //Create a picture  
                // Cải tiến sử dụng hình ảnh logo trên form thay vì ảnh đường dẫn

                string workingDirectory = Environment.CurrentDirectory;
                string Dir = Directory.GetParent(workingDirectory).Parent.FullName;
                string path = Dir + "\\Resources\\logoCLCCircle.png";
                var img = doc.AddImage(path);

                Picture Pictest = img.CreatePicture();
                Pictest.Height = 150;
                Pictest.Width = 150;
                //Create a new paragraph  
                titleFormat.FontColor = Color.Orange;
                Paragraph par = doc.InsertParagraph();
                par.AppendPicture(Pictest);
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

                

                //Insert text  
                

                //Text  
                string nameStudentNew ="Full Name: " +nameStudent + "\n [" +"Student ID: "+ IdStudent + "]" ;

                //Formatting Text Paragraph  
                Formatting nameStudentFormat = new Formatting();
                //font family  
                nameStudentFormat.FontFamily = new Font("Arial");
                //font size  
                nameStudentFormat.Size = 14D;
                //Spaces between characters  
                nameStudentFormat.Spacing = 1;


                //Insert text  
                doc.InsertParagraph(nameStudentNew, false, nameStudentFormat);


                //Text  Thong tin diem
                string textTotal = "Average of the whole course " + avgScore + "\nNumber of subjects passed: " + pass + "\n" + "Failed subjects: " + fail + "\n";

                //Formatting Text Paragraph  
                Formatting textTotalFormat = new Formatting();
                //font family  
                textTotalFormat.FontFamily = new Font("Arial");
                //font size  
                textTotalFormat.Size = 11D;
                //Spaces between characters  
                textTotalFormat.Spacing = 1;
                textTotalFormat.FontColor = Color.Red;
                textTotalFormat.Italic = true;
                //Insert text  
                Paragraph paragraph = doc.InsertParagraph(textTotal, false, textTotalFormat);
                paragraph.Alignment = Alignment.left;





                //Text  
                string textParagraph = "Scores on all courses\n";

                //Formatting Text Paragraph  
                Formatting textParagraphFormat = new Formatting();
                //font family  
                textParagraphFormat.FontFamily = new Font("Arial");
                //font size  
                textParagraphFormat.Size = 22D;
                //Spaces between characters  
                textParagraphFormat.Spacing = 1;
                //Insert title  
                Paragraph parTotal = doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                parTotal.Alignment = Alignment.center;


                foreach (int user in listSemester)
                {
                    //Text  
                    string newSemester = "Semester: " + user ;

                    //Formatting Text Paragraph  
                    Formatting newSemesterFormat = new Formatting();
                    //font family  
                    nameStudentFormat.FontFamily = new Font("Arial");
                    //font size  
                    nameStudentFormat.Size = 12D;
                    //Spaces between characters  
                    nameStudentFormat.Spacing = 1;
                    //Insert text  
                    doc.InsertParagraph(newSemester, false, newSemesterFormat);


                    //Create Table\

                    /*
                     Còn cần nâng cấp do lặp lại số lần lặp
                     
                     */

                    float sumSemester = 0;
                    int passSemester = 0;
                    int failSemester = 0;
                    int numCourse = 0;

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (user == Convert.ToInt32(dataGridView1.Rows[i].Cells["Semester"].Value))
                        {
                            numCourse++;
                            float score = float.Parse(dataGridView1.Rows[i].Cells["Score"].Value.ToString());
                            sumSemester += score;
                            if (score > 5.0)
                            {
                                passSemester++;

                            }
                            else
                            {
                                failSemester++;

                            }

                        }
                    }


                    Table t = doc.AddTable(numCourse + 1, dataGridView1.Columns.Count);

                    t.Alignment = Alignment.center;
                    t.Design = TableDesign.ColorfulList;

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        t.Rows[0].Cells[i].Paragraphs.First().Append(dataGridView1.Columns[i].HeaderText.ToString());
                    }
                    int tempRow = 1;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (user == Convert.ToInt32(dataGridView1.Rows[i].Cells["Semester"].Value))
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                t.Rows[tempRow].Cells[j].Paragraphs.First().Append(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                
                                    
                            }
                            tempRow++;
                        }
                    }

                    // Fill cells by adding text.  
                    // First row


                    doc.InsertTable(t);
                    float avgScoreSemester = (float)sumSemester / numCourse;

                    //Text  Thong tin diem
                    string textTotalSemester = "Average of the whole semester " + Math.Round( avgScoreSemester,2 )+ "\nNumber of subjects passed: " + passSemester + "\n" + "Failed subjects: " + failSemester + "\n";

                    //Formatting Text Paragraph  
                    Formatting textTotalSemesterFormat = new Formatting();
                    //font family  
                    textTotalSemesterFormat.FontFamily = new Font("Arial");
                    //font size  
                    textTotalSemesterFormat.Size = 9D;
                    //Spaces between characters  
                    textTotalSemesterFormat.Spacing = 1;
                    textTotalSemesterFormat.FontColor = Color.Black;
                    textTotalSemesterFormat.Italic = true;
                    //Insert text  
                    Paragraph paragraphSemester = doc.InsertParagraph(textTotalSemester, false, textTotalSemesterFormat);
                    paragraphSemester.Alignment = Alignment.right;
                    



                    doc.InsertParagraph();
                }
                


                



                #region part of one
                doc.Save();

                #endregion
            }
        }
    }
}
