using Bunifu.UI.WinForms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using Burn_management.Classes.Connection.GradeProccess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Properties;
using OfficeOpenXml;
using OfficeOpenXml.Style;
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

namespace Burn_management.Forms.FormsGrade
{
    public partial class Form_ViewGrade : DevExpress.XtraEditors.XtraForm
    {
        Cls_GradeDB gradeDB = new Cls_GradeDB();    
        private int idForm;
        private Form formMain;
        private int countGRA;

        public Form_ViewGrade()
        {
            InitializeComponent();
        }
        public Form_ViewGrade(Form form,int idForm,string nameYEA,string nameSES,string nameCOU,string nameEXA,string dateEXA)
        {
            InitializeComponent();
            this.idForm = idForm;
            this.formMain= form;
            loadData(nameYEA, nameSES,nameCOU,nameEXA,dateEXA);
        }
        private void loadData(string nameYEA, string nameSES, string nameCOU, string nameEXA, string dateEXA)
        {
            LBL_NameYEA.Text= nameYEA;
            LBL_NameSES.Text= nameSES;
            LBL_NameEXA.Text = nameEXA;
            LBL_NameCOU.Text = nameCOU;
            LBL_DateEXA.Text= dateEXA;
            dataGridViewGrade.DataSource = gradeDB.getDataGradeToExam(idForm);
             countGRA = dataGridViewGrade.Rows.Count;
            LBL_CountGRA.Text = $"“{countGRA}”";
        }

        private void setValueCellsHeader(ExcelWorksheet worksheet,string range,string value,string indexCol,bool isChangeFont)
        {
            worksheet.Cells[range].Merge = true;
            worksheet.Column(1).Width = 40;
            worksheet.Column(2).Width = 40;
            worksheet.Column(3).Width = 40;
            worksheet.Column(4).Width = 40;

            worksheet.Cells[indexCol].Value = value;
            worksheet.Cells[indexCol].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            worksheet.Cells[indexCol].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            worksheet.Cells[indexCol].Style.Font.Bold = true;
            worksheet.Cells[indexCol].Style.Font.Size = 14;
            if (isChangeFont)
            {
                worksheet.Cells[indexCol].Style.Font.Name = "Andalus";
                worksheet.Cells[indexCol].Style.Font.Size =28;

            }


        }
        private void showSuccessExportDataMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessExportData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void BTN_Export_Click(object sender, EventArgs e)
        {
           
            /*العلامات*/
            if (countGRA > 0)
            {
                // إنشاء ملف Excel جديد
                try
                {

                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // إنشاء ورقة Excel
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("العلامات");
                        worksheet.Cells.Style.Font.Name = "Cairo";
                        worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                        worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        // تنسيق رأس الأعمدة
                        for (int col = 1; col <= dataGridViewGrade.Columns.Count; col++)
                        {
                            var cell = worksheet.Cells[5, col];
                            cell.Value = dataGridViewGrade.Columns[col - 1].HeaderText;
                            cell.Style.Font.Bold = true; // جعل الخط بولد
                            cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7")); // تغيير لون الخلفية
                            cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض

                        }
                        setValueCellsHeader(worksheet, "A1:D1", "جامعة ادلب", "A1",true);
                        setValueCellsHeader(worksheet, "A2:D2", Cls_UsersDB.nameBranch, "A2", true);
                        var value = $"نتائج مقرر {LBL_NameCOU.Text}";
                        setValueCellsHeader(worksheet, "A3:D3", value, "A3", false);
                        value = $"{LBL_NameYEA.Text}-{LBL_NameSES.Text}-العام الدراسي {LBL_DateEXA.Text}";
                        setValueCellsHeader(worksheet, "A4:D4", value, "A4",false);
                        // حلقة لنسخ البيانات من DataGridView إلى Excel
                        for (int row = 5; row < dataGridViewGrade.Rows.Count + 5; row++)
                        {
                            for (int col = 0; col < dataGridViewGrade.Columns.Count; col++)
                            {
                                // يجب أن تكون البيانات في صفحة DataGridView مُستنسخة في الصفحة الثانية للورقة Excel
                                worksheet.Cells[row + 1, col + 1].Value = dataGridViewGrade.Rows[row - 5].Cells[col].Value.ToString();
                            }
                        }

                        int numberOfGrade = dataGridViewGrade.Rows.Count;




                        worksheet.Cells["F5"].Value = "عدد الطلاب:";
                        worksheet.Cells["F5"].Style.Font.Bold = true;
                        worksheet.Cells["F5"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells["F5"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));

                        worksheet.Cells["F5"].Style.Font.Color.SetColor(System.Drawing.Color.White);


                        worksheet.Column(6).Width = 15;
                        worksheet.Column(7).Width = 15;

                        worksheet.Cells["G5"].Style.Font.Bold = true;
                        worksheet.Cells["G5"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells["G5"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));
                                          
                        worksheet.Cells["G5"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        worksheet.Cells["G5"].Value = numberOfGrade;


                        // تنسيق البيانات كجدول
                        var table = worksheet.Tables.Add(new ExcelAddressBase(5, 1, dataGridViewGrade.Rows.Count + 5, dataGridViewGrade.Columns.Count), "جدول_العلامات");
                        table.TableStyle = OfficeOpenXml.Table.TableStyles.Light1;

                        // حفظ الملف
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "ملفات Excel (*.xlsx)|*.xlsx";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(excelFile);
                            showSuccessExportDataMessageData();
                            Task.Delay(2000);
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
}