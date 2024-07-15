using Bunifu.UI.WinForms;
using DevExpress.XtraEditors.Filtering;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Properties;
using System;
using System.Windows.Forms;
using System.Xml.Linq;
using ClsMessageCollections = Burn_management.Classes.ClsMessageCollections;

namespace Burn_management.Forms.FormsBranhc
{
    public partial class Form_AddBranches : DevExpress.XtraEditors.XtraForm
    {
        private int id=0;
        private bool isClose;
        private Form formMain;
        Cls_BranchDB action = new Cls_BranchDB();
        public Form_AddBranches(Form formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            TX_NameBranch.Select();
        }
        public Form_AddBranches(Form formMain, int id ,string name, string place,int yearCount, string note)
        {
            InitializeComponent();
            this.formMain = formMain;
            TX_NameBranch.Select();
            this.id = id;
            loadData(name, place, yearCount, note);
        }
        #region Method
        private void showSuccessAddMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void showSuccessUpdateMessageData()
        {
            MessageShow.InformationOptions.Icon = null;
            MessageShow.Show(formMain, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void chickEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BTN_AddClose.PerformClick();
            }
        }
        private void addData()
        {
            try
            {
                if (TX_NameBranch.Text == "" || TX_PlaceBranch.Text == "" || TX_YearCountBranch.Text == "")
                {

                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        action.insertBranch(TX_NameBranch.Text, TX_PlaceBranch.Text, int.Parse(TX_YearCountBranch.Text),
                                    RIT_NoteBranch.Text, DateTime.Now);
                        showSuccessAddMessageData();
                        clearField();
                        if (isClose)
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:135-FA_User ", "خطأ");
            }
        }

        private void loadData( string name, string place, int yearCount, string note)
        {
            TX_NameBranch.Text = name;
            TX_PlaceBranch.Text=place;
            TX_YearCountBranch.Text= yearCount.ToString();
            RIT_NoteBranch.Text= note;
        }
        private void updateData()
        {
            try
            {
                if (TX_NameBranch.Text == "" || TX_PlaceBranch.Text == "" || TX_YearCountBranch.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updateBranch(id,TX_NameBranch.Text, TX_PlaceBranch.Text, int.Parse(TX_YearCountBranch.Text),
                             RIT_NoteBranch.Text);

                        showSuccessUpdateMessageData();
                        if (isClose)
                        {
                            this.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:185-FA_User ", "خطأ");
            }
        }
        private void saveData()
        {
            if (id != 0)
            {
                updateData();
            }
            else
            {
                addData();
            }
        }
        private void clearField()
        {
            TX_NameBranch.Clear();
            TX_YearCountBranch.Clear();
            TX_PlaceBranch.Clear();
            RIT_NoteBranch.Clear();
          
        }
        #endregion
        #region Event
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            isClose = false;
            saveData();
        }

        private void BTN_AddClose_Click(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }

        private void TX_YearCountBranch_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }

        private void TX_NameBranch_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void TX_PlaceBranch_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);

        }

        private void TX_YearCountBranch_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);

        }

        private void RIT_NoteBranch_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);

        }
        #endregion
    }
}