using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.PatientProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Forms.FormsPatient;
using Burn_management.Properties;
using OfficeOpenXml;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burn_management.Gui.GuiHome
{
    public partial class Patients_UserControl : UserControl
    {
        //==> Var Info To Update Or Delete 
        #region Variables
        private int id;
        private string name;
        private string age;
        private string gender;
        private string address;
        private string phone;
        private string isReferral;
        private string note;
        private static Patients_UserControl PatientesUserControl;
        Form_AddPatients addPatientes;
        private Form formMain;
        Cls_PatientsDB action=new Cls_PatientsDB();
        Cls_UsersDB users = new Cls_UsersDB();
        #endregion
        //<============================================>
        //<============================================>
        //<============================================>
        public Patients_UserControl(Form formMain)
        {
            InitializeComponent();
            userVerification();
            loadInitData(formMain);

        }
        #region Method
        public static Patients_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            return PatientesUserControl ?? (new Patients_UserControl(form));
        }
        private void loadInitData(Form formMain)
        {
            this.formMain = formMain;
            loadUsersDataEntryists();
        }
        private void userVerification()
        {
            if (Cls_UsersDB.typeUser.Trim() == "مسؤول")
            {
                BTN_Add.Visible = false;
                BTN_Update.Visible = false;
                BTN_Delete.Visible = false;
                BTN_Add.Enabled = false;
                BTN_Update.Enabled = false;
                BTN_Delete.Enabled = false;
                BTN_Export.Width = 600;
                BTN_Export.Location = new Point(460, 11);
                BTN_Export.TextAlign = HorizontalAlignment.Center;
                getData();


            }
            else
            {
                COMP_FilterData.Visible = false;
                label1.Visible = false;
                getDataPatientsByUser(Cls_UsersDB.idUser);
            }
        }
        public void getData()
        {
            dataGridViewPatients.DataSource=action.getDataPatients();
        }
        public void getDataPatientsByUser(int idUser) =>
            dataGridViewPatients.DataSource = action.getDataPatientsByUser(idUser);
        private void loadUsersDataEntryists()
        {
            COMP_FilterData.DataSource = users.getDataUsersDataEntryists();
            COMP_FilterData.ValueMember = "المعرف";
            COMP_FilterData.DisplayMember = "الاسم";
            COMP_FilterData.SelectedIndex = -1;
        }
        public void loadFilterData()
        {
            if (COMP_FilterData.SelectedIndex != -1)
            {
                getDataPatientsByUser(getIdUsers());
            }
            else
            {
                if (COMP_FilterData.Text == "")
                {
                    userVerification();
                }
            }
            TX_Search.Clear();
        }
        private int getIdUsers()
        {

            try
            {
                if (COMP_FilterData.SelectedIndex != -1)
                {
                    int IdUser;
                    Int32.TryParse(COMP_FilterData.SelectedValue.ToString(), out IdUser);
                    return IdUser;
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
            if (dataGridViewPatients.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewPatients.CurrentRow.Cells[0].Value);
                name = dataGridViewPatients.CurrentRow.Cells[1].Value.ToString();
                age = dataGridViewPatients.CurrentRow.Cells[2].Value.ToString();
                gender = dataGridViewPatients.CurrentRow.Cells[3].Value.ToString();
                address = dataGridViewPatients.CurrentRow.Cells[4].Value.ToString();
                phone = dataGridViewPatients.CurrentRow.Cells[5].Value.ToString();
                isReferral = dataGridViewPatients.CurrentRow.Cells[9].Value.ToString();
                note = dataGridViewPatients.CurrentRow.Cells[11].Value.ToString();



                BTN_Delete.Enabled = Convert.ToBoolean(action.getDataIsCanDeletePatient(id).Rows[0][0].ToString() == "0");

            }


        }
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    addPatientes = new Form_AddPatients(formMain, id, name, age, gender, address, phone, isReferral,note);
                    addPatientes.ShowDialog();
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
                   
                    if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                    {
                        action.deletePatient(id);
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
        private void searchDataGridView(string searchText)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridViewPatients.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in dataGridViewPatients.Rows)
            {
                bool rowVisible = false;


                if (row.Cells["المعرف"].Value != null && row.Cells["المعرف"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["الاسم"].Value != null && row.Cells["الاسم"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["الجنس"].Value != null && row.Cells["الجنس"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["العنوان"].Value != null && row.Cells["العنوان"].Value.ToString().ToLower().Contains(searchText.ToLower()))
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
            addPatientes = new Form_AddPatients(formMain);
            addPatientes.ShowDialog();
            addPatientes.Dispose();
            userVerification();
        }
        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }
        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }
        private void dataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BTN_Update.Enabled)
            {
                BTN_Update.PerformClick();
            }
        }
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            updateData();
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }
        private void dataGridViewPatients_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewPatients.CurrentRow != null)
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
        private void TX_Search_TextChanged(object sender, EventArgs e)
        {
            if (TX_Search.Text != "")
            {
                searchDataGridView(TX_Search.Text);
            }
            else
            {
                if (COMP_FilterData.SelectedIndex == -1)
                {
                    userVerification();
                }
                else
                {
                    loadFilterData();
                }
             
            }
        }
        private void BTN_Export_Click(object sender, EventArgs e)
        {
      


            // إنشاء ملف Excel جديد
            try
            {


                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // إنشاء ورقة Excel
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("المرضى");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
               
                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewPatients.Columns.Count; col++)
                    {
                        worksheet.Column(col).Width = 12.5;
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewPatients.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض
                    }
                    worksheet.Column(dataGridViewPatients.Columns.Count).Width = 23;
                    worksheet.Column(2).Width = 17;
                    worksheet.Column(6).Width = 20;
                    worksheet.Column(7).Width = 8;
                    worksheet.Column(8).Width = 8;
                    worksheet.Column(10).Width = 8;





                    // حلقة لنسخ البيانات من DataGridView إلى Excel
                    for (int row = 1; row <= dataGridViewPatients.Rows.Count; row++)
                    {
                        for (int col = 1; col <= dataGridViewPatients.Columns.Count; col++)
                        {
                            // يجب أن تكون البيانات في صفحة DataGridView مُستنسخة في الصفحة الثانية للورقة Excel
                            worksheet.Cells[row + 1, col].Value = dataGridViewPatients.Rows[row - 1].Cells[col - 1].Value.ToString();
                        }
                    }
                    int numberOfPatientes = dataGridViewPatients.Rows.Count;
                   
                  


                    worksheet.Cells["O3"].Value = "عدد المرضى:";
                    worksheet.Cells["O3"].Style.Font.Bold = true;
                    worksheet.Cells["O3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["O3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));

                    worksheet.Cells["O3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                 

                    worksheet.Column(15).Width = 15;
                    worksheet.Column(16).Width = 5;

                    worksheet.Cells["P3"].Style.Font.Bold = true;
                    worksheet.Cells["P3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["P3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
           
                    worksheet.Cells["P3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Cells["P3"].Value = numberOfPatientes;


                    // تنسيق البيانات كجدول
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewPatients.Rows.Count + 1, dataGridViewPatients.Columns.Count), "جدول_المرضى");
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
        private void COMP_FilterData_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFilterData();
        }
        private void COMP_FilterData_TextChanged(object sender, EventArgs e)
        {
            loadFilterData();
        }
        #endregion
    }
}
