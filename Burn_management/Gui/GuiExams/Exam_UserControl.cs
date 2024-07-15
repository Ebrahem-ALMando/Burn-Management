using Bunifu.UI.WinForms;
using DevExpress.XtraEditors;
using Burn_management.Classes;
using Burn_management.Classes.Connection.ExamProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Forms.FormsCourse;
using Burn_management.Forms.FormsExam;
using Burn_management.Forms.FormsGrade;
using Burn_management.Gui.GuiUsers;
using Burn_management.Properties;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Burn_management.Gui.GuiExams
{
    public partial class Exam_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public static Exam_UserControl examControl;
        private Form formMain;
        Form_AddExam addExam;
        Cls_ExamDB action = new Cls_ExamDB();
        private int id;
        private string NameExam;
        private string Season;
        private string Course;
        private string DateExam;
        private string CountQuestion;
        private string FinalGrade;
        private string note;
        private string Branch;
        private string year;

        public Exam_UserControl(Form form)
        {
            InitializeComponent();
            this.formMain = form;
            userVerification();
        }
        public static Exam_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            return examControl ?? (new Exam_UserControl(form));
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            addExam=new Form_AddExam(formMain);
            addExam.ShowDialog();
            addExam.Dispose();
            userVerification();
        }
        private void userVerification()
        {
            if (Cls_UsersDB.typeUser == "مسؤول")
            {
                BTN_Add.Visible = false;
                BTN_Update.Visible = false;
                BTN_Delete.Visible = false;
                BTN_Grade.Visible = false;
                BTN_Export.Width = 600;
                BTN_Export.TextAlign = HorizontalAlignment.Center;
                BTN_Export.Location = new Point(460, 11);
                getDataAdmin();
            }
            else
            {
                COMP_FilterData.Visible = false;
                label1.Visible = false;
                getDataToTeacherExams(Cls_UsersDB.idUser);
            }
        }
        private void getDataAdmin()
        {
            dataGridViewExams.DataSource = action.getDataExams();
        }
        private void getDataToTeacherExams(int idUser)
        {
            dataGridViewExams.DataSource = action.getDataToTeacherExams(idUser);
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
         
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                deleteData();
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
                        action.deleteExam(id);
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
        private void showSuccessDeleteMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessDeleteData, BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void BTN_Export_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // إنشاء ورقة Excel
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("النماذج");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewExams.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewExams.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض

                    }
                    // حلقة لنسخ البيانات من DataGridView إلى Excel
                    for (int row = 1; row <= dataGridViewExams.Rows.Count; row++)
                    {
                        for (int col = 1; col <= dataGridViewExams.Columns.Count; col++)
                        {
                            // يجب أن تكون البيانات في صفحة DataGridView مُستنسخة في الصفحة الثانية للورقة Excel
                            worksheet.Cells[row + 1, col].Value = dataGridViewExams.Rows[row - 1].Cells[col - 1].Value.ToString();
                        }
                    }
                    int numberOfExams = dataGridViewExams.Rows.Count;
                    worksheet.Cells["N3"].Value = "عدد النماذج:";
                    worksheet.Cells["N3"].Style.Font.Bold = true;
                    worksheet.Cells["N3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["N3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));
                    worksheet.Cells["N3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Column(14).Width = 15;
                    worksheet.Column(15).Width = 15;
                    worksheet.Cells["O3"].Style.Font.Bold = true;
                    worksheet.Cells["O3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["O3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));
                    worksheet.Cells["O3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Cells["O3"].Value = numberOfExams;

                    // تنسيق البيانات كجدول
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewExams.Rows.Count + 1, dataGridViewExams.Columns.Count), "جدول_النماذج");
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
        private void showSuccessExportDataMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessExportData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        }
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                
                updateData();
            }
        }
        private void getDataFromDGV()
        {
            if (dataGridViewExams.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewExams.CurrentRow.Cells[0].Value);
                Branch = dataGridViewExams.CurrentRow.Cells[1].Value.ToString();
                year = dataGridViewExams.CurrentRow.Cells[2].Value.ToString();
                Season = dataGridViewExams.CurrentRow.Cells[3].Value.ToString();
                Course = dataGridViewExams.CurrentRow.Cells[4].Value.ToString();
                DateExam = dataGridViewExams.CurrentRow.Cells[5].Value.ToString();
                NameExam = dataGridViewExams.CurrentRow.Cells[6].Value.ToString();
                CountQuestion = dataGridViewExams.CurrentRow.Cells[7].Value.ToString();
                FinalGrade = dataGridViewExams.CurrentRow.Cells[8].Value.ToString();
                note = dataGridViewExams.CurrentRow.Cells[10].Value.ToString();

                BTN_Delete.Enabled = (action.getDataIsCanDeleteExam(id).Rows.Count > 0) ? false : true;
            }
        }
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    addExam = new Form_AddExam(formMain, id, Branch, year, Season, Course,DateExam, NameExam, CountQuestion, FinalGrade,note);
                    addExam.ShowDialog();
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
        private void dataGridViewExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }
        private void dataGridViewExams_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                updateData();
            }
        }

        private void BTN_Grade_Click(object sender, EventArgs e)
        {
            new Form_GetGrade(formMain).ShowDialog();
        }
    }
}
