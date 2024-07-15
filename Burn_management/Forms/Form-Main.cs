using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Classes.Home;
using Burn_management.Gui.GuiActiveExams;
using Burn_management.Gui.GuiCourses;
using Burn_management.Gui.GuiExams;
using Burn_management.Gui.GuiHome;
using Burn_management.Gui.GuiQuestions;
using Burn_management.Gui.GuiUsers;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Burn_management
{
    
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        private readonly Cls_PageManager pageManager;
        private bool togle = true;
        private bool islogout=false;
        private Guna2Button currentButton = null;
        private Guna2Button previousButton = null;
       
        Image oldImage = null;
        public Form_Main()
        {
            InitializeComponent();
            pageManager=new Cls_PageManager(this);
            pageManager.LoadPage(Home_UserControl.Instance());
            loadFirstTheme();
            userVerification();
        }
        private void userVerification()
        {
         
            if (Cls_UsersDB.typeUser == "مدرس")
            {
                BTN_Users.Visible = false;
                BTN_Patients.Visible = false;
                panel2.Margin=new Padding(3, 200, 3, 3);
            }
        }
        private void loadFirstTheme()
        {
            currentButton = BTN_Home;
            currentButton.FillColor = Color.White;
            currentButton.Image = Properties.Resources.icons8_home_60px;
            currentButton.ForeColor = Color.FromArgb(180, 0, 1);
            currentButton.BorderColor = Color.FromArgb(252, 1, 5);
            previousButton = currentButton;
        }
        private void changeColorBTN(object button,Image image)
        {
            currentButton=(Guna2Button)button;
            Image imgOld = previousButton.Image;
            currentButton.Image = image;
            currentButton.ForeColor = Color.FromArgb(180, 0, 1);
            currentButton.BorderColor = Color.FromArgb(252, 1, 5);
            currentButton.FillColor = Color.White;
            if (previousButton!=null&&currentButton!=previousButton)
            {
                previousButton.ForeColor = Color.White;
                previousButton.BorderColor = Color.White;
                previousButton.FillColor = Color.FromArgb(180, 0, 1);
           
                switch (previousButton.Name)
                {
                    case "BTN_Home":
                        oldImage = Properties.Resources.icons8_home_40px_1;
                        break;
                    case "BTN_Users":
                        oldImage = Properties.Resources.icons8_users_50px_2;
                        break;
                    case "BTN_Patients":
                        oldImage = Properties.Resources.icons8_nurse_call_60px_1;
                        break;
                    case "BTN_FollowUp":
                        oldImage = Properties.Resources.icons8_schedule_40px;
                        break;
                    case "BTN_DischargeCases":
                        oldImage = Properties.Resources.icons8_test_40px;
                        break;
                    case "BTN_Logout":
                        oldImage = Properties.Resources.icons8_logout_40px_1;
                        break;

                }
                previousButton.Image=oldImage;
            }
            previousButton = currentButton;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (togle)
            {

                PIBPanel.Image = Properties.Resources.icons8_xbox_menu_40px_1;
                togle = false;
                Pan_BTNS.Size = new Size(90, 738);
                PIBPanel.Location = new Point(199, 12);
                PAN_Time.Visible = false;
                foreach (Guna2Button menuButton in Pan_BTNS.Controls.OfType<Guna2Button>())
                {

                    menuButton.Text = " ";
                    menuButton.ImageAlign = HorizontalAlignment.Center;
                    menuButton.Padding = new Padding(0);
                    menuButton.Width =87;
                    menuButton.BorderThickness = 0;
                    menuButton.BorderRadius = 0;
                }
            }
            else
            {
                PIBPanel.Image = Properties.Resources.Back_Arrow_60px;
                togle = true;
                Pan_BTNS.Size = new Size(275, 698);
                PIBPanel.Location = new Point(212, 12);
                PAN_Time.Visible = true;

                foreach (Guna2Button menuButton in Pan_BTNS.Controls.OfType<Guna2Button>())
                {
                    menuButton.Text="   "+menuButton.Tag.ToString();
                    menuButton.ImageOffset = new Point(0, 0);
                    menuButton.Padding = new Padding(10,0,0,0);
                    menuButton.BorderThickness =2;
                    menuButton.Width = 259;
                    menuButton.BorderRadius = 20;
                    menuButton.ImageAlign = HorizontalAlignment.Left;
                }
            }
          
        }
        private void BTN_Home_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Home_UserControl.Instance());
            var image = Properties.Resources.icons8_home_60px;
            changeColorBTN(sender, image);
        }
        private void BTN_Users_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Users_UserControl.Instance(this));
            var image = Properties.Resources.icons8_users_60px;
            changeColorBTN(sender, image);
        }
        private void BTN_Patients_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Branches_UserControl.Instance(this));
            var image = Properties.Resources.icons8_nurse_call_60px;
            changeColorBTN(sender, image);
        }
        private void BTN_FollowUp_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Courses_UserControl.Instance(this));
            var image = Properties.Resources.icons8_schedule_60px;
            changeColorBTN(sender, image);
        }
        private void BTN_DischargeCases_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Exam_UserControl.Instance(this));
            var image = Properties.Resources.icons8_test_60px;
            changeColorBTN(sender, image);
        }
        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            islogout=true;
            var image = Properties.Resources.icons8_logout_60px;
            changeColorBTN(sender, image);
            Guna2MessageDialog message = new Guna2MessageDialog();
            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.YesNo;
            message.Icon = MessageDialogIcon.Question;
            DialogResult check = message.Show("هل تريد تسجيل الخروج \n ", "خروج");
            if (check == DialogResult.Yes)
            {
                this.Close();
                Application.OpenForms["Form_Login"].Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_TimeNow.Text =  DateTime.Now.ToString("hh:mm:ss tt");
            LBL_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!islogout)
            {
                Application.Exit();
            }
        }

       
    }
}