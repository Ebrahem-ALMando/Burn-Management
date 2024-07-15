using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Forms.FormsBranhc;
using Burn_management.Properties;
using OfficeOpenXml;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burn_management.Gui.GuiHome
{
    public partial class Branches_UserControl : UserControl
    {
        //==> Var Info To Update Or Delete 
        #region Variables

        private int id;
        private string name;
        private string place;
        private int yearCount;
        private string note;
        private static Branches_UserControl branchesUserControl;
        Form_AddBranches addBranches;
        private Form formMain;
        Cls_BranchDB action=new Cls_BranchDB();
        #endregion
        //<============================================>
        //<============================================>
        //<============================================>
        public Branches_UserControl(Form formMain)
        {
            InitializeComponent();
            getData();
            this.formMain = formMain;

        }
      
        #region Method
        public static Branches_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            
            return branchesUserControl ?? (new Branches_UserControl(form));
        }
        

        public void getData()
        {
            dataGridViewBranchs.DataSource=action.getDataBranch();
        }
        private void getDataFromDGV()
        {
            if (dataGridViewBranchs.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewBranchs.CurrentRow.Cells[0].Value);
                name = dataGridViewBranchs.CurrentRow.Cells[1].Value.ToString();
                place=  dataGridViewBranchs.CurrentRow.Cells[2].Value.ToString();
                yearCount = Convert.ToInt32(dataGridViewBranchs.CurrentRow.Cells[3].Value.ToString());
                note= dataGridViewBranchs.CurrentRow.Cells[4].Value.ToString();
                BTN_Delete.Enabled = (action.getDataIsCanDeleteBranch(id).Rows.Count > 0) ? false : true;

            }


        }
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    addBranches = new Form_AddBranches(formMain,id, name, place,yearCount,note);
                    addBranches.ShowDialog();
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
                        action.deleteBranch(id);
                        showSuccessDeleteMessageData();
                        getData();
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
        #endregion
        private void BTN_Add_Click_1(object sender, EventArgs e)
        {
            addBranches = new Form_AddBranches(formMain);
            addBranches.ShowDialog();
            addBranches.Dispose();
            getData();
        }

        private void dataGridViewBranchs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewBranchs_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewBranchs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateData();
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void dataGridViewBranchs_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewBranchs.CurrentRow != null)
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
                dataGridViewBranchs.DataSource = action.serachDataBranch(TX_Search.Text);
            }
            else
            {
                getData();
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
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("الأفرع");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true; // تعيين اتجاه النص إلى اليمين
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    // تنسيق رأس الأعمدة
                    for (int col = 1; col <= dataGridViewBranchs.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[1, col];
                        cell.Value = dataGridViewBranchs.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true; // جعل الخط بولد
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7")); // تغيير لون الخلفية
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White); // تغيير لون الخط إلى أبيض
                       
                    }

                    // حلقة لنسخ البيانات من DataGridView إلى Excel
                    for (int row = 1; row <= dataGridViewBranchs.Rows.Count; row++)
                    {
                        for (int col = 1; col <= dataGridViewBranchs.Columns.Count; col++)
                        {
                            // يجب أن تكون البيانات في صفحة DataGridView مُستنسخة في الصفحة الثانية للورقة Excel
                            worksheet.Cells[row + 1, col].Value = dataGridViewBranchs.Rows[row - 1].Cells[col - 1].Value.ToString();
                        }
                    }
                    int numberOfBranches = dataGridViewBranchs.Rows.Count;
                   
                  


                    worksheet.Cells["I3"].Value = "عدد الأفرع:";
                    worksheet.Cells["I3"].Style.Font.Bold = true;
                    worksheet.Cells["I3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["I3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));

                    worksheet.Cells["I3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                 

                    worksheet.Column(9).Width = 15;
                    worksheet.Column(10).Width = 15;

                    worksheet.Cells["J3"].Style.Font.Bold = true;
                    worksheet.Cells["J3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["J3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#5028f7"));
           
                    worksheet.Cells["J3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Cells["J3"].Value = numberOfBranches;


                    // تنسيق البيانات كجدول
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewBranchs.Rows.Count + 1, dataGridViewBranchs.Columns.Count), "جدول_الأفرع");
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
