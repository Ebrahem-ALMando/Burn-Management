using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.CoursesProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Forms.FormsBranhc;
using Burn_management.Forms.FormsCourse;
using Burn_management.Gui.GuiHome;
using Burn_management.Properties;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burn_management.Gui.GuiCourses
{
    public partial class Courses_UserControl : UserControl
    {  //==> Var Info To Update Or Delete 
        #region Variables
        private int id = 0;
        private string name;
        private string yearName;
        private string season;
        private string note; 
        private static Courses_UserControl courseUserControl;
        private Form formMain;
        Cls_CoursesDB action =new Cls_CoursesDB();
        Cls_UsersDB usersDB = new Cls_UsersDB();
        Form_AddCourse addCourse;
        #endregion
        //<============================================>
        //<============================================>
        //<============================================>
        public Courses_UserControl(Form form)
        {
            InitializeComponent();
            this.formMain = form;
            userVerification();
        }
        private void userVerification()
        {
            if (Cls_UsersDB.typeUser == "مسؤول")
            {
                BTN_Add.Visible = false;
                BTN_Update.Visible = false;
                BTN_Delete.Visible = false;
              
                BTN_Export.Width=600;
                BTN_Export.TextAlign=HorizontalAlignment.Center;
                BTN_Export.Location=new Point(460, 11);
             /*   loadTeachers();*/
                getData();

            }
            else
            {
                COMP_FilterData.Visible = false;
                label1.Visible = false;
                getDataToTeacher(Cls_UsersDB.idUser);
            }
        }
        private int getIdTeacher()
        {
            if (COMP_FilterData.SelectedIndex >= 0)
            {
                int idTeacher;
                Int32.TryParse(COMP_FilterData.SelectedValue.ToString(), out idTeacher);
                return idTeacher;
            }
            return -1;

        }
        private void loadFilterData()
        {
            if (COMP_FilterData.Text != "" && COMP_FilterData.SelectedIndex != -1)
            {
                getDataToTeacher(getIdTeacher());
            }
            else
            {
                getData();
            }
            TX_Search.Clear();
        }
    /*    private void loadTeachers()
        {
            COMP_FilterData.DataSource = usersDB.getDataUsersTeachers();
            COMP_FilterData.DisplayMember = "الاسم";
            COMP_FilterData.ValueMember = "المعرف";
            COMP_FilterData.SelectedIndex = -1;
        }*/

        public static Courses_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            return courseUserControl ?? (new Courses_UserControl(form));
        }
        private void getData()
        {
            dataGridViewCourses.DataSource = action.getDataCourses();
        }
        private void getDataToTeacher(int idUser)
        {
            dataGridViewCourses.DataSource = action.getDataCoursesToTeacher(idUser);
        }
        private void getDataFromDGV()
        {
            if (dataGridViewCourses.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewCourses.CurrentRow.Cells[0].Value);
                name = dataGridViewCourses.CurrentRow.Cells[1].Value.ToString();
                yearName = dataGridViewCourses.CurrentRow.Cells[4].Value.ToString();
                season = dataGridViewCourses.CurrentRow.Cells[5].Value.ToString();
                note = dataGridViewCourses.CurrentRow.Cells[6].Value.ToString();
                BTN_Delete.Enabled = (action.getDataIsCanDeleteCourses(id).Rows.Count > 0) ? false : true;
            }
        }
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    addCourse = new Form_AddCourse(formMain, id, name, yearName, season, note);
                    addCourse.ShowDialog();
                    userVerification();
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:79-FG_User ", "خطأ");
            }
        }
        private void showSuccessDeleteMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessDeleteData, BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void showSuccessExportDataMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessExportData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void deleteData()
        {
            try
            {

                if (id != 0)
                {
                    /*    if (getNumberInternsToSupplier(id) > 0)
                        {
                            ClsMessageCollections.showWarningSupplierHasInternsMessageData();
                        }*/
                    /* else*/
                    /*{*/
                    if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                    {
                        action.deleteCourse(id);
                        showSuccessDeleteMessageData();
                        userVerification();
                        id = 0;
                    }
                    /*}*/

                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:385-FG_User ", "خطأ");
            }
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            addCourse = new Form_AddCourse(formMain);
            addCourse.ShowDialog();
            addCourse.Dispose();
            userVerification();

        }

        private void dataGridViewCourses_SizeChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                updateData();
            }
             
        }
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                updateData();
            }
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                deleteData();
            }
        }
        private void dataGridViewCourses_KeyDown(object sender, KeyEventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                if (dataGridViewCourses.CurrentRow != null)
                {
                    if (e.KeyData == Keys.Delete)
                    {
                        if (BTN_Delete.Enabled)
                        {
                            BTN_Delete.PerformClick();
                        }
                    }
                }
            }
        }
        private void BTN_Export_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // إنشاء ورقة Excel
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("المواد");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewCourses.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewCourses.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض

                    }
                    // حلقة لنسخ البيانات من DataGridView إلى Excel
                    for (int row = 1; row <= dataGridViewCourses.Rows.Count; row++)
                    {
                        for (int col = 1; col <= dataGridViewCourses.Columns.Count; col++)
                        {
                            // يجب أن تكون البيانات في صفحة DataGridView مُستنسخة في الصفحة الثانية للورقة Excel
                            worksheet.Cells[row + 1, col].Value = dataGridViewCourses.Rows[row - 1].Cells[col - 1].Value.ToString();
                        }
                    }
                    int numberOfCourses = dataGridViewCourses.Rows.Count;
                    worksheet.Cells["J3"].Value = "عدد المواد:";
                    worksheet.Cells["J3"].Style.Font.Bold = true;
                    worksheet.Cells["J3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["J3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));
                    worksheet.Cells["J3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Column(10).Width = 15;
                    worksheet.Column(11).Width = 15;
                    worksheet.Cells["K3"].Style.Font.Bold = true;
                    worksheet.Cells["K3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["K3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));
                    worksheet.Cells["K3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Cells["K3"].Value = numberOfCourses;

                    // تنسيق البيانات كجدول
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewCourses.Rows.Count + 1, dataGridViewCourses.Columns.Count), "جدول_المواد");
                    table.TableStyle = OfficeOpenXml.Table.TableStyles.Light1;
                    // حفظ الملف
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "ملفات Excel (*.xlsx)|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(excelFile);
                        showSuccessExportDataMessageData();
                        Task.Delay(1500);
                        System.Diagnostics.Process.Start(excelFile.FullName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nTry Agin");
            }
        }
        private void TX_Search_TextChanged(object sender, EventArgs e)
        {
            if (Cls_UsersDB.typeUser == "مسؤول")
            {
                if (TX_Search.Text != "")
                {
                    if (COMP_FilterData.Text == "" && COMP_FilterData.SelectedIndex == -1)
                    {
                        dataGridViewCourses.DataSource = action.serachDataCourse(TX_Search.Text);

                    }
                    else if (COMP_FilterData.SelectedIndex != -1)
                    {
                        dataGridViewCourses.DataSource = action.serachDataCourseToTeacher(getIdTeacher(), TX_Search.Text);
                    }
                }
                else
                {
                    if (COMP_FilterData.Text == "")
                    {
                        getData();
                    }
                    else
                    {

                        getDataToTeacher(getIdTeacher());
                    }
                }
            }
            else
            {
                if (TX_Search.Text != "")
                {
                    dataGridViewCourses.DataSource = action.serachDataCourseToTeacher(Cls_UsersDB.idUser, TX_Search.Text);

                }
                else
                {
                    getDataToTeacher(Cls_UsersDB.idUser);
                }
            }
        }
        private void COMP_FilterData_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFilterData();
        }
        private void COMP_FilterData_TextChanged(object sender, EventArgs e)
        {
            loadFilterData();
        }
    }
}
