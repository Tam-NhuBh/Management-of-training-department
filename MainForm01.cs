using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Result;
using WindowsFormsApp1.Score;

namespace WindowsFormsApp1
{
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            this.Visible = false;
            addStdF.ShowDialog(this);
            this.Visible = true;
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            studentListForm studentListForm = new studentListForm();
            studentListForm.DisplayData();
            studentListForm.ShowDialog(this);
            this.Visible = true;
        }
        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRemove editRemove = new EditRemove();
            this.Visible = false;
            editRemove.ShowDialog(this);
            this.Visible = true;
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            this.Visible = false;
            manageStudent.ShowDialog();
            this.Visible = true;
        }
        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm Static = new StaticForm();
            //ẩn đi chứ ko tắt
            this.Visible = false;
            Static.ShowDialog(this);
            //hiển thị lại
            this.Visible = true;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentFrom PrintStudent = new PrintStudentFrom();
            //ẩn đi chứ ko tắt
            this.Visible = false;
            PrintStudent.ShowDialog(this);
            //hiển thị lại
            this.Visible = true;
        }
        private void addCourseStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourse = new AddCourseForm();
            this.Visible = false;
            addCourse.ShowDialog(this);
            this.Visible = true;

        }
        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdiCourseForm editCourse = new EdiCourseForm();
            this.Visible = false;
            editCourse.ShowDialog(this);
            this.Visible = true;
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            this.Visible = false;
            manageForm.ShowDialog(this);
            this.Visible = true;
        }              
        private void removeCourseStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removeCourse = new RemoveCourseForm();
            this.Visible = false;
            removeCourse.ShowDialog(this);
            this.Visible = true;
        }

        private void printCourseStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintCourseForm printCourse = new PrintCourseForm();
            this.Visible = false;
            printCourse.ShowDialog(this);
            this.Visible = true;
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddScore frmAddScore = new FormAddScore();
            this.Visible = false;
            frmAddScore.ShowDialog();
            this.Visible = true;
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemoveScorecs formRemoveScorecs = new FormRemoveScorecs();
            this.Visible = false;
            formRemoveScorecs.Show(this);
            this.Visible = true;
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageScore frmManageScore = new FormManageScore();
            this.Visible = false;
            frmManageScore.Show(this);
            this.Visible = true;
        }

        private void averageScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAverage formAverage = new FormAverage();
            this.Visible = false;
            formAverage.Show(this);
            this.Visible = true;
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPrintScore formPrintScore = new FormPrintScore();
            this.Visible = false;
            formPrintScore.Show(this);
            this.Visible = true;
        }

        private void staticresultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticResult statisticResult = new StatisticResult();
            this.Visible = false;
            statisticResult.Show(this);
            this.Visible = true;
        }

        private void aVGResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAVGResultByScore formAVGResultByScore = new FormAVGResultByScore();
            this.Visible = false;
            formAVGResultByScore.Show(this);
            this.Visible = true;
        }
    }
}
