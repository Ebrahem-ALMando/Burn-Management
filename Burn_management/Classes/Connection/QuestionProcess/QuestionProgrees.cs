using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn_management.Classes.Connection.QuestionProcess
{
    internal class QuestionProgrees
    {
        public int QuestionNumber { get; set; } // رقم السؤال
        public int ValProgrees { get; set; } // القييمة التي يجب ان يأخذها الشريط عند زيارة هذا الزر 
        public QuestionProgrees(int questionNumber, int valProgress)
        {
            QuestionNumber = questionNumber;
            ValProgrees = valProgress;
        }
    }
}
