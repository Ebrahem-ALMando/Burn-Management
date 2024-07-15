using Bunifu.UI.WinForms;
using DevExpress.Export;
using Burn_management.Classes;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Forms.FormsUser;
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
using System.Diagnostics;

namespace Burn_management.Gui.GuiUsers
{
    public partial class Users_UserControl : UserControl
    {
        private int id;
        private string name;
        private string age;
        private string phone;
        private string address;
        private string userName;
        private string password;
        private string typeUser;
        private static Users_UserControl userControl;
        Form__AddUsers addUsers;
        Cls_UsersDB action = new Cls_UsersDB();
        private Form formMain;

        public Users_UserControl(Form formMain)
        {
            InitializeComponent();
            getData();
            this.formMain = formMain;
            loadFilterData();
        }
        public static Users_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            return userControl ?? (new Users_UserControl(form));
        }
        private void loadFilterData()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                dataTable.Columns.Add(new DataColumn("Value", typeof(string)));
                dataTable.Rows.Add(new object[] { "الكل", "all" });
                dataTable.Rows.Add(new object[] { "المسؤولين", "مسؤول" });
                dataTable.Rows.Add(new object[] { "مشرفي العلاج", "مشرف علاج" });
                dataTable.Rows.Add(new object[] { "مدخلو البيانات", "مدخل بيانات" });
                COMP_FilterData.DataSource = dataTable;
                COMP_FilterData.DisplayMember = "Name";
                COMP_FilterData.ValueMember = "Value";
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            /*  COMP_FilterData.SelectedIndex = 0;*/
        }
        public void getData()=>
             dataGridViewUsers.DataSource = action.getDataUsers();
        public void getDataUsersAdmins()
        {
            dataGridViewUsers.DataSource = action.getDataUsersAdmins();
        }
        public void getDataUsersTreatmentSupervisors()
        {
            dataGridViewUsers.DataSource = action.getDataUsersTreatmentSupervisors();
        }
        public void getDataUsersDataEntryists()
        {
            dataGridViewUsers.DataSource = action.getDataUsersDataEntryists();
        }
        private void getDataFromDGV()
        {
            if (dataGridViewUsers.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells[0].Value);
                name = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();
                age = dataGridViewUsers.CurrentRow.Cells[2].Value.ToString();
                phone = dataGridViewUsers.CurrentRow.Cells[3].Value.ToString();
                address = dataGridViewUsers.CurrentRow.Cells[4].Value.ToString();
                userName = dataGridViewUsers.CurrentRow.Cells[5].Value.ToString();
                password = dataGridViewUsers.CurrentRow.Cells[6].Value.ToString();
                typeUser = dataGridViewUsers.CurrentRow.Cells[7].Value.ToString();
                /*Update In Prograss*/
              /*  BTN_Delete.Enabled = (action.getDataIsCanDeleteUser(id).Rows.Count > 0) ? false : true;*/
            }
        }
        private string getTypeSearch()
        {
            string typeSearch = COMP_FilterData.SelectedValue.ToString();
            return typeSearch;
        }
        private void deleteData()
        {
            try
            {
                if (id != 0)
                {
                    if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                    {
                        action.deleteUser(id);
                        showSuccessDeleteMessageData();
                        getData();
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
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    addUsers = new Form__AddUsers(formMain, id, name, age, phone, address, userName, password, typeUser);
                    addUsers.ShowDialog();
                    getData();
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
        private void loadData()
        {
            if (COMP_FilterData.SelectedIndex == 0)
            {
                getData();
            }
            else if (COMP_FilterData.SelectedIndex == 1)
            {
                getDataUsersAdmins();
            }
            else if (COMP_FilterData.SelectedIndex == 2)
            {
                getDataUsersTreatmentSupervisors();  
            }
            else if (COMP_FilterData.SelectedIndex == 3)
            {
                getDataUsersDataEntryists();
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
            addUsers=new Form__AddUsers(formMain);
            addUsers.ShowDialog();
            addUsers.Dispose();
            getData();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewUsers.CurrentRow != null)
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

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateData();
        }

        private void BTN_Export_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // إنشاء ورقة Excel
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("المستخدمين");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewUsers.Columns.Count; col++)
                    {
                        worksheet.Column(col).Width = 12.5;
                        worksheet.Column(dataGridViewUsers.Columns.Count).Width = 23;
                     
                        var cell = worksheet.Cells[1, col];
                 
                        cell.Value = dataGridViewUsers.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض

                    }

                    // حلقة لنسخ البيانات من DataGridView إلى Excel
                    for (int row = 1; row <= dataGridViewUsers.Rows.Count; row++)
                    {
                        for (int col = 1; col <= dataGridViewUsers.Columns.Count; col++)
                        {
                            // يجب أن تكون البيانات في صفحة DataGridView مُستنسخة في الصفحة الثانية للورقة Excel
                            worksheet.Cells[row + 1, col].Value = dataGridViewUsers.Rows[row - 1].Cells[col - 1].Value.ToString();
                        }
                    }
                    int numberOfUsers = dataGridViewUsers.Rows.Count;
                    worksheet.Cells["M3"].Value = "عدد المستخدمين:";
                    worksheet.Cells["M3"].Style.Font.Bold = true;
                    worksheet.Cells["M3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["M3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
                    worksheet.Cells["M3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Column(13).Width = 19;
                    worksheet.Column(14).Width = 5;
                    worksheet.Cells["N3"].Style.Font.Bold = true;
                    worksheet.Cells["N3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["N3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#b40100"));
                    worksheet.Cells["N3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Cells["N3"].Value = numberOfUsers;
                    // تنسيق البيانات كجدول
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewUsers.Rows.Count + 1, dataGridViewUsers.Columns.Count), "جدول_المستخدمين");
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
                loadData();
        }

        private void TX_Search_TextChanged(object sender, EventArgs e)
        {
            if (TX_Search.Text!= "")
            {
               
                dataGridViewUsers.DataSource = action.serachDataUsers(TX_Search.Text, getTypeSearch());
            }
            else
            {
                loadData();
            }
        }
    }
}
