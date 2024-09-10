using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.FollowUpProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Forms.FormsFollowUp;
using Burn_management.Properties;
using OfficeOpenXml;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Burn_management.Classes.Connection.PatientProcess;
using Burn_management.Classes.Connection.DischargeProcess;

namespace Burn_management.Gui.GuiFollowUp
{
    public partial class FollowUp_UserControl : UserControl
    {  //==> Var Info To Update Or Delete 
        #region Variables
        private int id = 0;
        private int idPatient = 0;
        private int resultDelete = -1;
        private bool isDelete=false;
        private float burnRate;
        private bool isDischarge;
        private static FollowUp_UserControl courseUserControl;
        private Form formMain;
        Cls_FollowUpDB action =new Cls_FollowUpDB();
        Cls_UsersDB usersDB = new Cls_UsersDB();
        Cls_PatientsDB patientsDB = new Cls_PatientsDB();
        Cls_DischargeDB dischargeDB = new Cls_DischargeDB();
        Form_AddFollowUp addCourse;
        private float temperatureMeasurement;
        private int burnDrawer;
        #endregion
        //<============================================>
        //<============================================>
        //<============================================>
        public FollowUp_UserControl(Form form)
        {
            InitializeComponent();
            this.formMain = form;
            userVerification();
            loadInitFilterBTN();
        }
        #region Function
        public static FollowUp_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            return courseUserControl ?? (new FollowUp_UserControl(form));
        }
        private void userVerification()
        {
            if (Cls_UsersDB.typeUser.Trim() == "مسؤول" && BTN_Add.Visible)
            {
                BTN_Add.Visible = false;
                BTN_Update.Visible = false;
                BTN_Delete.Visible = false;
                BTN_Export.Width=600;
                BTN_Export.TextAlign=HorizontalAlignment.Center;
                BTN_Export.Location=new Point(460, 11);
            }
            getData();
            dataGridViewFollowUp.Columns[1].Visible = false;
            loadInitFilterBTN();
        }
        public void loadInitFilterBTN()=>
            setButoonTheam(BTN_All);
        public void setButoonTheam(Guna2Button selectButton)
        {
         
            foreach (Control ctrl in PAN_BTN_Filter.Controls)
            {
                if (ctrl is Guna2Button gunaButton)
                {

                    gunaButton.FillColor = Color.Transparent; 

                    gunaButton.ForeColor = Color.White;
                }
            }
            selectButton.FillColor = Color.White;
            selectButton.ForeColor = Color.FromArgb(180, 0, 1);
            id = 0;

        }
        public void getData()=>
            dataGridViewFollowUp.DataSource = action.getDataFollowUp();
        public void getDataFollowUpDischarge()=>
            dataGridViewFollowUp.DataSource=action.getDataFollowUpDischarge();
        public void getDataFollowUpReferral() =>
            dataGridViewFollowUp.DataSource = action.getDataFollowUpReferral();
        public void getDataFollowUpResult_Follow() =>
            dataGridViewFollowUp.DataSource = action.getDataFollowUpResult_Follow();
        private void getDataFromDGV()
        {
            if (dataGridViewFollowUp.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewFollowUp.CurrentRow.Cells[0].Value);
                idPatient = Convert.ToInt32(dataGridViewFollowUp.CurrentRow.Cells[1].Value);
                temperatureMeasurement = Convert.ToSingle(dataGridViewFollowUp.CurrentRow.Cells[7].Value);
                burnDrawer = Convert.ToInt32(dataGridViewFollowUp.CurrentRow.Cells[9].Value);
                burnRate = Convert.ToSingle(dataGridViewFollowUp.CurrentRow.Cells[10].Value);
                isDischarge = (temperatureMeasurement >= 35 && temperatureMeasurement <= 39)
                    && (burnDrawer == 1 || burnDrawer == 2) && burnRate <= 5;
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
         
                if (id != 0&&idPatient!=0)
                {
                    if (burnRate > 30)
                    {
                        FormDeleteFollowUp formDelete = new FormDeleteFollowUp("إحـــالــة");
                        formDelete.ShowDialog();

                        resultDelete = formDelete.getResult();
                        formDelete.Dispose();
                        if (resultDelete == 1||resultDelete==2)
                        {
                            action.deleteFollowUp(id);
               
                            if (resultDelete == 2)
                            {
                                patientsDB.setIsDischarge(idPatient, "لا");
                            }
                            isDelete = true;
                        }
                      
                    }
                    else if (isDischarge)
                    {
                        FormDeleteFollowUp formDelete = new FormDeleteFollowUp("تـخــريــج");
                        formDelete.ShowDialog();

                        resultDelete = formDelete.getResult();
                        formDelete.Dispose();
                        if (resultDelete == 2)
                        {
                            action.deleteFollowUp(id);
                            dischargeDB.deleteDischarge(id);
                            patientsDB.setIsDischarge(idPatient, "لا");
                            isDelete = true;
                        }
                    }
                    else
                    {
                        if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                        {
                            action.deleteFollowUp(id);
                            isDelete = true;
                        }
                    }
                   if (isDelete)
                    {
                        showSuccessDeleteMessageData();
                        patientsDB.decrementNumberVisits(idPatient);
                        userVerification();
                        id = 0;
                        idPatient = 0;
                        isDelete = false;
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
        private void searchData(string searchText)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridViewFollowUp.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in dataGridViewFollowUp.Rows)
            {
                bool rowVisible = false;


                if (row.Cells["المعرف"].Value != null && row.Cells["المعرف"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["اسم المريض"].Value != null && row.Cells["اسم المريض"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["مشرف العلاج"].Value != null && row.Cells["مشرف العلاج"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["نوع التمرين"].Value != null && row.Cells["نوع التمرين"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["التأثيرات النفسية"].Value != null && row.Cells["التأثيرات النفسية"].Value.ToString().ToLower().Contains(searchText.ToLower()))
                {
                    rowVisible = true;
                }

                row.Visible = rowVisible;
            }

            currencyManager.ResumeBinding();
        }
        #endregion
        #region Event
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            addCourse = new Form_AddFollowUp(formMain);
            addCourse.ShowDialog();
            addCourse.Dispose();
            userVerification();
        }
        private void dataGridViewFollowUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                deleteData();
            }
        }
        private void dataGridViewFollowUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (Cls_UsersDB.typeUser != "مسؤول")
            {
                if (dataGridViewFollowUp.CurrentRow != null)
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
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("المتابعات");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewFollowUp.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewFollowUp.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض
                    }

                    // حلقة لنسخ البيانات من DataGridView إلى Excel
                    for (int row = 1; row <= dataGridViewFollowUp.Rows.Count; row++)
                    {
                        for (int col = 1; col <= dataGridViewFollowUp.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 1, col].Value = dataGridViewFollowUp.Rows[row - 1].Cells[col - 1].Value?.ToString();
                        }
                    }

                    // تنسيق عرض الأعمدة بناءً على القيم الموجودة
                    for (int col = 1; col <= dataGridViewFollowUp.Columns.Count; col++)
                    {
                        worksheet.Column(col).AutoFit(); // ضبط عرض الأعمدة تلقائيًا
                    }



                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewFollowUp.Rows.Count + 1, dataGridViewFollowUp.Columns.Count), "جدول_المتابعات");
                    table.TableStyle = OfficeOpenXml.Table.TableStyles.Light1;
                    worksheet.DeleteColumn(2);
                    worksheet.DeleteColumn(18);

                    // تنسيق عدد المتابعات
                    int numberOfCourses = dataGridViewFollowUp.Rows.Count;
                    worksheet.Cells["S3"].Value = "عدد المتابعات:";
                    worksheet.Cells["S3"].Style.Font.Bold = true;
                    worksheet.Cells["S3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["S3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
                    worksheet.Cells["S3"].Style.Font.Color.SetColor(System.Drawing.Color.White);

                    worksheet.Cells["T3"].Value = numberOfCourses;
                    worksheet.Cells["T3"].Style.Font.Bold = true;
                    worksheet.Cells["T3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["T3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
                    worksheet.Cells["T3"].Style.Font.Color.SetColor(System.Drawing.Color.White);

      
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
                MessageBox.Show(ex.Message + "\nTry Again");
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
                userVerification();
            }
        }
        private void dataGridViewFollowUp_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
             bool isDischarge;
             bool isReferral;

            DataGridView dgv = dataGridViewFollowUp;

            var burnRate =Convert.ToSingle( dgv.Rows[e.RowIndex].Cells["نسبة الحرق"].Value?.ToString());
            var burnDrawer = Convert.ToSingle(dgv.Rows[e.RowIndex].Cells["درجة الحرق"].Value?.ToString());
            var temperatureMeasurement = Convert.ToSingle(dgv.Rows[e.RowIndex].Cells["درجة الحرارة"].Value?.ToString());
            isReferral = burnRate > 30;
            isDischarge= (temperatureMeasurement >= 35 && temperatureMeasurement <= 39)
                    && (burnDrawer == 1 || burnDrawer == 2) && burnRate <= 5;

                if (isReferral)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
         
                else if (isDischarge)
                {
                  dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 255, 79);
                }

                else 
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
            
        }
        private void BTN_Discharge_Click(object sender, EventArgs e)
        {
            setButoonTheam(BTN_Discharge);
            getDataFollowUpDischarge();
        }
        private void BTN_FollowUp_Click(object sender, EventArgs e)
        {
            setButoonTheam(BTN_FollowUp);
            getDataFollowUpResult_Follow();
        }
        private void BTN_Referral_Click(object sender, EventArgs e)
        {
            setButoonTheam(BTN_Referral);
            getDataFollowUpReferral();
        }
        private void BTN_All_Click(object sender, EventArgs e)
        {
            setButoonTheam(BTN_All);
            getData();
        }
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            Guna2MessageDialog messageDialog = new Guna2MessageDialog();
            messageDialog.Icon = MessageDialogIcon.Information;
            messageDialog.Text = ". . .  قيد العمل\n\n";
            messageDialog.Style = MessageDialogStyle.Dark;
            messageDialog.Show();
        }
        #endregion


    }
}
