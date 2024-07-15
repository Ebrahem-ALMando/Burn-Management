using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Classes.Connection.HomeProcess;
using System.Diagnostics.PerformanceData;
using Guna.UI2.WinForms;

namespace Burn_management.Gui.GuiHome
{
    public partial class Home_UserControl : UserControl
    {
        private static Home_UserControl homeUserControl;
        Cls_HomeDB homeDB=new Cls_HomeDB();
        public Home_UserControl()
        {
            InitializeComponent();
            userVerification();
        }
        private void updateButtonCount(Guna2CircleButton button, string dataCount)
        {
            if (!string.IsNullOrEmpty(dataCount))
            {
                button.Text = $"“{dataCount}”";
            }
        }

        private void updateButtonCountFromTeacher(Guna2CircleButton button, int countRows, string dataCount)
        {
            if (countRows > 0)
            {
                updateButtonCount(button, dataCount);
            }
        }

        private void getData()
        {
            updateButtonCount(BTN_ViewUsers, homeDB.getDataCountUser()?.Rows[0][0]?.ToString());
            updateButtonCount(BTN_ViewBranchs, homeDB.getDataCountBranchs()?.Rows[0][0]?.ToString());
            updateButtonCount(BTN_ViewActiveExams, homeDB.getDataCountActiveExams()?.Rows[0][0]?.ToString());
            updateButtonCount(BTN_ViewCourses, homeDB.getDataCountCourses()?.Rows[0][0]?.ToString());
            updateButtonCount(BTN_ViewExams, homeDB.getDataCountExams()?.Rows[0][0]?.ToString());
            updateButtonCount(BTN_ViewQuestion, homeDB.getDataCountQuestion()?.Rows[0][0]?.ToString());
        }

   /*     private void getDataToTeacher()
        {
            int countRows;

            countRows = homeDB.getDataCountQuestionToTeachers(Cls_UsersDB.idUser)?.Rows.Count ?? 0;
            updateButtonCountFromTeacher(BTN_ViewQuestion, countRows, homeDB.getDataCountQuestionToTeachers(Cls_UsersDB.idUser)?.Rows[0][0]?.ToString());

            countRows = homeDB.getDataCountExamsToTeachers(Cls_UsersDB.idUser)?.Rows.Count ?? 0;
            updateButtonCountFromTeacher(BTN_ViewExams, countRows, homeDB.getDataCountExamsToTeachers(Cls_UsersDB.idUser)?.Rows[0][0]?.ToString());

            countRows = homeDB.getDataCountActiveExamsToTeachers(Cls_UsersDB.idUser)?.Rows.Count ?? 0;
            updateButtonCountFromTeacher(BTN_ViewActiveExams, countRows, homeDB.getDataCountActiveExamsToTeachers(Cls_UsersDB.idUser)?.Rows[0][0]?.ToString());

            countRows = homeDB.getDataCountCoursesToTeachers(Cls_UsersDB.idUser)?.Rows.Count ?? 0;
            updateButtonCountFromTeacher(BTN_ViewCourses, countRows, homeDB.getDataCountCoursesToTeachers(Cls_UsersDB.idUser)?.Rows[0][0]?.ToString());
        }*/

        private void userVerification()
        {
            LBL_NameUser.Text += Cls_UsersDB.nameUser ?? "Gust";
            if (Cls_UsersDB.typeUser == "مسؤول")
            {
                getData();
            }
            else
            {
             /*   getDataToTeacher();*/             
                PAN_Users.Visible = false;
                PAN_Branch.Visible = false;
                PAN_Course.Location = new System.Drawing.Point(872, 197);
                PAN_Ques.Location = new System.Drawing.Point(278, 197);
                PAN_ActiveExam.Location = new System.Drawing.Point(278, 560) ;
                PAN_Exams.Location = new System.Drawing.Point(872, 560);
                PAN_Exams.Anchor = AnchorStyles.Right;
            }
        }

     

        public static Home_UserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return homeUserControl ?? (new Home_UserControl());
        }

       
    }
}
