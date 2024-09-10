using Bunifu.UI.WinForms;
using Burn_management.Classes.Connection.DischargeProcess;
using Burn_management.Properties;
using OfficeOpenXml;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burn_management.Gui.GuiDischarge
{
    public partial class Discharge_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        #region Var
        public static Discharge_UserControl dischargeControl;
        private Form formMain;
        Cls_DischargeDB action = new Cls_DischargeDB();
        #endregion
        public Discharge_UserControl(Form form)
        {
            InitializeComponent();
            loadInitConfig(form);
        }
        #region Function
        public static Discharge_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            return dischargeControl ?? (new Discharge_UserControl(form));
        }
        private void loadInitConfig(Form form)
        {
            this.formMain = form;
            getData();
        }
        private void getData()=>
            dataGridViewDischarge.DataSource = action.getDataDischarge();
        private void showSuccessExportDataMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessExportData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        }
        private void searchData(string searchText)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridViewDischarge.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in dataGridViewDischarge.Rows)
            {
                bool rowVisible = false;


                if (row.Cells["المعرف"].Value != null && row.Cells["المعرف"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["اسم المريض"].Value != null && row.Cells["اسم المريض"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["الجنس"].Value != null && row.Cells["الجنس"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["العنوان"].Value != null && row.Cells["العنوان"].Value.ToString().ToLower().Contains(searchText.ToLower()) 
                    )
                {
                    rowVisible = true;
                }

                row.Visible = rowVisible;
            }

            currencyManager.ResumeBinding();
        }
        #endregion
        #region Event
        private void BTN_Export_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // إنشاء ورقة Excel
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("التخريجات");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewDischarge.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewDischarge.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض

                    }
                    int excelRowIndex = 2; 
                    foreach (DataGridViewRow row in dataGridViewDischarge.Rows)
                    {
                        if (row.Visible) 
                        {
                            for (int col = 1; col <= dataGridViewDischarge.Columns.Count; col++)
                            {
                                var cellValue = row.Cells[col - 1].Value != null ? row.Cells[col - 1].Value.ToString() : ""; 
                                worksheet.Cells[excelRowIndex, col].Value = cellValue; 
                            }
                            excelRowIndex++; 
                        }
                    }
                    int numberOfDischarge = dataGridViewDischarge.Rows.Count;
                    worksheet.Cells["O3"].Value = "عدد التخريجات:";
                    worksheet.Cells["O3"].Style.Font.Bold = true;
                    worksheet.Cells["O3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["O3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
                    worksheet.Cells["O3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Column(14).Width = 15;
                    worksheet.Column(15).Width = 15;
                    worksheet.Cells["P3"].Style.Font.Bold = true;
                    worksheet.Cells["P3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["P3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
                    worksheet.Cells["P3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Cells["P3"].Value = numberOfDischarge;
                    for (int col = 1; col <= dataGridViewDischarge.Columns.Count; col++)
                    {
                        worksheet.Column(col).AutoFit();

                    }
                    // تنسيق البيانات كجدول
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewDischarge.Rows.Count + 1, dataGridViewDischarge.Columns.Count), "جدول_التخريجات");
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
            if (TX_Search.Text != "")
            {
                searchData(TX_Search.Text);
            }
            else
            {
                getData();
            }
        }
        #endregion

    }
}
