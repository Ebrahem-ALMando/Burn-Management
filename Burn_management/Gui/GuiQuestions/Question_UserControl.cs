using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.ExamProcess;
using Burn_management.Classes.Connection.QuestionProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Forms.FormsQuestion;
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
using System.Xml.Linq;

namespace Burn_management.Gui.GuiQuestions
{
    public partial class Question_UserControl : UserControl
    {
        private static Question_UserControl questionUserControl;
        private Form formMain;
        Form_AddQuestion addQuestion;
        Cls_ExamDB examDB = new Cls_ExamDB();
        Cls_QuestionDB action=new Cls_QuestionDB();
        private int id;
        private string typeQues;
        private Form_AddQuesToExam addQuesToExam;

        public Question_UserControl(Form formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            userVerification();
            loadExams();
            
        

        }
        public static Question_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once

            return questionUserControl ?? (new Question_UserControl(form));
        }
        private void userVerification()
        {
            if (Cls_UsersDB.typeUser == "مسؤول")
            {
                BTN_Add.Visible = false;
                BTN_Update.Visible = false;
                BTN_Delete.Visible = false;
                BTN_AddQuesToExam.Visible = false;
                BTN_Export.Width = 600;
                BTN_Export.TextAlign = HorizontalAlignment.Center;
                BTN_Export.Location = new Point(460, 11);
              
           /*     loadTeachers();*/
                getData();

            }
            else
            {
              /*  COMP_FilterData.Visible = false;*/
                label1.Visible = false;
                getDataToTeacher(Cls_UsersDB.idUser);
            }
        }

        private void getData()
            => dataGridViewQuestion.DataSource = action.getDataQuestion();

        

        private void getDataToTeacher(int idUser)
            => dataGridViewQuestion.DataSource = action.getDataQuestionToTeacher(idUser);


        private void getDataQuestionByExam(int idExam) 
            => dataGridViewQuestion.DataSource= action.getDataQuestionByExam(idExam);
        private int getIdExam()
        {
            try
            {
                if (COMP_FilterData.SelectedIndex != -1)
                {
                    int IdForm;
                    Int32.TryParse(COMP_FilterData.SelectedValue.ToString(), out IdForm);
                    return IdForm;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CODE:LI-88-FAUS");
                return 0;
            }
        }
        private void getDataFromDGV()
        {
            if (dataGridViewQuestion.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewQuestion.CurrentRow.Cells[0].Value);
                typeQues = dataGridViewQuestion.CurrentRow.Cells[4].Value.ToString();

                BTN_Delete.Enabled = (action.getDataIsCanDeleteQuestion(id).Rows.Count > 0) ? false : true;
            }
        }

        private void loadExams()
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                COMP_FilterData.DataSource = examDB.getDataToTeacherExams(Cls_UsersDB.idUser);
              
            }
            else
            {
                COMP_FilterData.DataSource = examDB.getDataExams();
            }
            COMP_FilterData.ValueMember = "المعـرف";
            COMP_FilterData.DisplayMember = "اسم النموذج";
            COMP_FilterData.SelectedIndex = -1;
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
                        action.deleteQuestion(id);
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

        private void showSuccessDeleteMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessDeleteData, BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void showSuccessExportDataMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessExportData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            addQuestion = new Form_AddQuestion(formMain);
            addQuestion.ShowDialog();
            addQuestion.Dispose();
            userVerification();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                deleteData();
            }
        }

        private void dataGridViewQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewQuestion_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewQuestion.CurrentRow != null)
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

        private void BTN_Export_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // إنشاء ورقة Excel
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("الاسئلة");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewQuestion.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewQuestion.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض

                    }
                    // حلقة لنسخ البيانات من DataGridView إلى Excel
                    for (int row = 1; row <= dataGridViewQuestion.Rows.Count; row++)
                    {
                        for (int col = 1; col <= dataGridViewQuestion.Columns.Count; col++)
                        {
                            // يجب أن تكون البيانات في صفحة DataGridView مُستنسخة في الصفحة الثانية للورقة Excel
                            worksheet.Cells[row + 1, col].Value = dataGridViewQuestion.Rows[row - 1].Cells[col - 1].Value.ToString();
                        }
                    }
                    int numberOfQuestion = dataGridViewQuestion.Rows.Count;
                    worksheet.Cells["J3"].Value = "عدد الاسئلة:";
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
                    worksheet.Cells["K3"].Value = numberOfQuestion;

                    // تنسيق البيانات كجدول
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewQuestion.Rows.Count + 1, dataGridViewQuestion.Columns.Count), "جدول_الاسئلة");
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

       

        private void BTN_AddQuesToExam_Click(object sender, EventArgs e)
        {
            try
            {

                if (id != 0)
                {

                        addQuesToExam=new Form_AddQuesToExam(formMain,id,typeQues);
                        addQuesToExam.ShowDialog();
                        addQuesToExam.Dispose();
                        userVerification();

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

        private void COMP_FilterData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMP_FilterData.SelectedIndex != -1)
            {
                getDataQuestionByExam(getIdExam());
            }
            else
            {
                if (COMP_FilterData.Text == "")
                {
                    userVerification();
                }

            }
        }

        private void COMP_FilterData_TextChanged(object sender, EventArgs e)
        {
            if (COMP_FilterData.SelectedIndex != -1)
            {
                getDataQuestionByExam(getIdExam());
            }
            else
            {
                if (COMP_FilterData.Text == "")
                {
                    userVerification();
                }
            }
        }
    }
}
