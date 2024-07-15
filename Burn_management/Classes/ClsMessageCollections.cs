using Bunifu.UI.WinForms;
using Burn_management.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burn_management.Classes
{
    public static class ClsMessageCollections
    {
      

        public static readonly Guna2MessageDialog messageShow = new Guna2MessageDialog();
        public static  BunifuSnackbar messageShowBUF;
        //==>Show Message Empty Data

        private static void getWarningMessageFormat()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Warning;
        }
        private static void getSuccessMessageFormat()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Information;
        }
        private static void getQuitionMessageFormat()
        {
            messageShow.Buttons = MessageDialogButtons.OKCancel;
            messageShow.Style = MessageDialogStyle.Dark;
            messageShow.Icon = MessageDialogIcon.Question;
        }
        private static void getErroeMessageFormat()
        {
            messageShow.Buttons = MessageDialogButtons.OK;
            messageShow.Style = MessageDialogStyle.Light;
            messageShow.Icon = MessageDialogIcon.Error;
        }
        public static void showEmptyMessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.EmptyData + "\n ", Resources.CaptionWarningData);
        }

        public static void showCheckGetExamMessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.EmptyDataExam + "\n ", Resources.CaptionWarningData);
        }
        public static void showWarningInputvalidPasswordMessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.WarningInputvalidPassword + "\n ", Resources.CaptionWarningData);
        }
        public static void showWarningOverFlowCountMessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.WarningOverFlowCount + "\n ", Resources.CaptionWarningData);
        }
        public static void showWarningThisExamHasBeenProvidedPreviouslytMessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.WarningisSubmittedExam + "\n ", Resources.CaptionWarningData);
        }
        //==>Show Message Empty Data Serach
        public static void showEmptySearchMessageData()
        {
            getWarningMessageFormat();
            /*messageShow.Show(Resources.EmptyDataSerarch + "\n ", Resources.CaptionWarningData);*/
        }

        //==>Show Message Warning Input less length Password  
        public static void showWarningInputlesslengthPasswordMessage()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.WarningInputPasswordlesslenth + "\n ", Resources.CaptionWarningData);
        }


        public static void WarningDataIsEmptyMessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.WarningDataIsEmpty + "\n ", Resources.CaptionWarningData);
        }
        //===>Show Warning InputAlready Password Message
        public static void showWarningInputAlreadyPasswordMessage()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.WarningInputAlreadyPassword + "\n ", Resources.CaptionWarningData);
        }


        //==>Show Message Success Add Data
        public static void showSuccessAddMessageData(Form form)
        {
        
              messageShowBUF = new BunifuSnackbar();
            getSuccessMessageFormat();
            messageShow.Show(Resources.SuccessAddData + "\n ", Resources.CaptionSuccessActionData);
            messageShowBUF.Show(form, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
            
        }
        //==>Show Message Quition Add Data
        public static DialogResult showQuitionAddMessageData()
        {
            getQuitionMessageFormat();
            DialogResult check = messageShow.Show(Resources.QuitionAddData + "\n ", Resources.CaptionQuitionAddData);
            return check;
        }
        public static DialogResult showQuitionEndExamMessageData()
        {
            getQuitionMessageFormat();
            DialogResult check = messageShow.Show(Resources.QuitionEndExam + "\n ", Resources.CaptionQuitionEndExam);
            return check;
        }
        //==>Show Message Quition Add Data
        /*    public static DialogResult showQuitionDepositMessageData()
            {
                getQuitionMessageFormat();
                DialogResult check = messageShow.Show(Resources.QuitionDepositData + "\n ", Resources.CaptionQuitionDepositData);
                return check;
            }
            public static DialogResult showQuitionWithdrawalMessageData()
            {
                getQuitionMessageFormat();
                DialogResult check = messageShow.Show(Resources.QuitionWithdrawalData + "\n ", Resources.CaptionQuitionwithdrawalData);
                return check;
            }*/
        /*   public static void showSuccessWithdrawalMessageData()
           {
               getSuccessMessageFormat();

               messageShow.Show(Resources.SuccessWithdrawalData + "\n ", Resources.CaptionSuccessActionData);
           }
           public static void showSuccessDepositMessageData()
           {
               getSuccessMessageFormat();

               messageShow.Show(Resources.SuccessDepositData + "\n ", Resources.CaptionSuccessActionData);
           }
           public static void showWarningNotEnoughAmountMessageData()
           {
               getWarningMessageFormat();
               messageShow.Show(Resources.WarningNotEnoughAmount + "\n ", Resources.CaptionWarningData);
           }*/

        //==>Show Message Quition Add Data
        public static void showWarningInputJustNumberMessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.WarningInputJustNumber + "\n ", Resources.CaptionWarningData);
        }

        //==>Show Message Quition Delete Data
        public static DialogResult showQuitionDeleteMessageData()
        {
            getQuitionMessageFormat();
            DialogResult check = messageShow.Show(Resources.QuitionDeleteData + "\n ", Resources.CaptionQuitionDeleteData);
            return check;
        }

        //==>Show Message Success Delete Data
        public static void showSuccessDeleteMessageData()
        {
            getSuccessMessageFormat();
            messageShow.Show(Resources.SuccessDeleteData + "\n ", Resources.CaptionSuccessActionData);
        }
        public static void showSuccessExprotMessageData()
        {
            getSuccessMessageFormat();
            messageShow.Show(Resources.SuccessExportData + "\n ", Resources.CaptionSuccessActionData);
        }
        //==>Show Message Warning Id Delete Data
        public static void showWarningIdSelectMessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.WarningIdSelectData + "\n ", Resources.CaptionWarningData);
        }

        //==>Show Message Quition Update Data
        public static DialogResult showQuitionUpdateMessageData()
        {
            getQuitionMessageFormat();
            DialogResult check = messageShow.Show(Resources.QuitionUpdateData + "\n ", Resources.CaptionQuitionUpdateData);
            return check;
        }
        //==>Show Message Success Update Data
        public static void showSuccessUpdateMessageData()
        {
            getSuccessMessageFormat();
            messageShow.Show(Resources.SuccessUpdateData + "\n ", Resources.CaptionSuccessActionData);
        }
        //==>Show Message SaveBackup  Data
        public static void showSuccessSaveBackupData()
        {
            getSuccessMessageFormat();
            messageShow.Show(Resources.SuccessSaveBackup + "\n ", Resources.CaptionSuccessActionData);
        }
        public static void showErroeSaveBackupIn_C_DiskMessage()
        {
            getErroeMessageFormat();
            messageShow.Show(Resources.ErrorSaveBackupIndesk_C + "\n ", Resources.CaptionWarningData);
        }
        public static void showWarningInputPathBackupMessage()
        {
            getErroeMessageFormat();
            messageShow.Show(Resources.WarningInputPathToBackup + "\n ", Resources.CaptionWarningData);
        }
        public static void showSuccessRestoreBackupData()
        {
            getSuccessMessageFormat();
            messageShow.Show(Resources.SuccessRestoreBackup + "\n ", Resources.CaptionSuccessActionData);
        }

        public static DialogResult showWarningClrearAnswerMessageData()
        {
            getQuitionMessageFormat();
            DialogResult check = messageShow.Show(Resources.WarningClrearAnswer + "\n ", Resources.CaptionWarningData);
            return check;
        }
        public static void showSuccessSubmiteExamMessageData()
        {
            getSuccessMessageFormat();
            messageShow.Show(Resources.SuccessSubmiteExam + "\n ", Resources.CaptionSuccessActionData);
        }
        //-------------------------------New

        public static void showWarningInputvalueGreaterthan100MessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.WarningInputValueInRange + "\n ", Resources.CaptionWarningData);
        }


        public static void showSuccessUpdateTimeMessageData()
        {
            getSuccessMessageFormat();
            messageShow.Show(Resources.SuccessUpdateTime + "\n ", Resources.CaptionSuccessActionData);
        }

        //---------------------------
        //==========================
        public static void checkInputTextBoxNumber(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ' || e.KeyChar == '`'
                 || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '@'
                || e.KeyChar == '!' || e.KeyChar == '^' || e.KeyChar == '&' || e.KeyChar == '('
                || e.KeyChar == ')' || e.KeyChar == '_' || e.KeyChar == '~'
                || e.KeyChar == '/' || e.KeyChar == ';' || e.KeyChar == '+')
            {
                e.Handled = true;
                showWarningInputJustNumberMessageData();
            }
            else
            {
                e.Handled = false;
            }

        }
        public static void checkInputTextBoxNumber(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                float textValue = Convert.ToSingle(textBox.Text);
                if (textValue > 100)
                {
                    showWarningInputvalueGreaterthan100MessageData();
                    textBox.Clear();
                }
            }

        }
        public static void showEmptySelectedMessageData()
        {
            getWarningMessageFormat();
            messageShow.Show(Resources.EmptySelectdData + "\n ", Resources.CaptionWarningData);
        }

    }
}
