using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.ActiveExamsProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Forms.FormsActiveExams;
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
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Burn_management.Gui.GuiActiveExams
{
    public partial class ActiveExams_UserControl : UserControl
    {
        private static ActiveExams_UserControl activeExamsUserControl;
        Form formMain;
        Form_AddActiveExams Form_AddActiveExams;
        Form_UpdateTime updateTime;
        Cls_ActiveExamsDB action = new Cls_ActiveExamsDB();
        private int id;
        private string nameForm;
        private string timeForm;

        public ActiveExams_UserControl(Form formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            userVerification();
        }
        
        public static ActiveExams_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once

            return activeExamsUserControl ?? (new ActiveExams_UserControl(form));
        }
        private void getData()
            => dataGridViewActiveExam.DataSource = action.getDataActiveExam();
        private void getDataToTeacher(int idTeacher)
            => dataGridViewActiveExam.DataSource = action.getDataActiveExamToTeacher(idTeacher);
        private void userVerification()
        {
            if (Cls_UsersDB.typeUser == "مسؤول")
            {
                BTN_Add.Visible = false;
                BTN_Update.Visible = false;
                BTN_Delete.Visible = false;

                BTN_Export.Width = 600;
                BTN_Export.TextAlign = HorizontalAlignment.Center;
                BTN_Export.Location = new Point(460, 11);
            /*    loadTeachers();*/
                getData();

            }
            else
            {
             /*   COMP_FilterData.Visible = false;
                label1.Visible = false;*/
                getDataToTeacher(Cls_UsersDB.idUser);
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
        private void getDataFromDGV()
        {
            if (dataGridViewActiveExam.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewActiveExam.CurrentRow.Cells[0].Value);
                nameForm = dataGridViewActiveExam.CurrentRow.Cells[1].Value.ToString();
                timeForm = dataGridViewActiveExam.CurrentRow.Cells[10].Value.ToString();
                BTN_Delete.Enabled = (action.getDataIsCanDeleteActiveForm(id).Rows.Count > 0) ? false : true;
            }
        }
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    updateTime = new Form_UpdateTime(id,nameForm,timeForm,formMain);
                    updateTime.ShowDialog();
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
        private void deleteData()
        {
            try
            {

                if (id != 0)
                {
                    if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                    {
                        action.deleteActiveExams(id);
                        showSuccessDeleteMessageData();
                        userVerification();
                        id = 0;
                    }
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
            Form_AddActiveExams=new Form_AddActiveExams(formMain);
            Form_AddActiveExams.ShowDialog();
            Form_AddActiveExams.Dispose();
            userVerification();
        }

        private void dataGridViewActiveExam_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewActiveExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                updateData();
            }
        }

        private void dataGridViewActiveExam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridViewActiveExam_KeyDown(object sender, KeyEventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                if (dataGridViewActiveExam.CurrentRow != null)
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
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("النماذج النشطة");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewActiveExam.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewActiveExam.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض

                    }
                    // حلقة لنسخ البيانات من DataGridView إلى Excel
                    for (int row = 1; row <= dataGridViewActiveExam.Rows.Count; row++)
                    {
                        for (int col = 1; col <= dataGridViewActiveExam.Columns.Count; col++)
                        {
                            // يجب أن تكون البيانات في صفحة DataGridView مُستنسخة في الصفحة الثانية للورقة Excel
                            worksheet.Cells[row + 1, col].Value = dataGridViewActiveExam.Rows[row - 1].Cells[col - 1].Value.ToString();
                        }
                    }
                    int numberOfCourses = dataGridViewActiveExam.Rows.Count;
                    worksheet.Cells["K3"].Value = "عدد النماذج النشطة:";
                    worksheet.Cells["K3"].Style.Font.Bold = true;
                    worksheet.Cells["K3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["K3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));
                    worksheet.Cells["K3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Column(11).Width = 15;
                    worksheet.Column(12).Width = 15;
                    worksheet.Cells["L3"].Style.Font.Bold = true;
                    worksheet.Cells["L3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["L3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));
                    worksheet.Cells["L3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Cells["L3"].Value = numberOfCourses;

                    // تنسيق البيانات كجدول
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewActiveExam.Rows.Count + 1, dataGridViewActiveExam.Columns.Count), "جدول_النماذج_النشطة");
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
    }
}
