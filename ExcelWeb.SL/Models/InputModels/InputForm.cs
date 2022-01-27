using ExcelWeb.SL.Models.Common;
using System.Collections.Generic;

namespace ExcelWeb.SL.Models.InputModels
{
    public class InputForm
    {
        public List<Questionnaire> Questionnaries { get; set; }

        public InputForm()
        {
            Questionnaries = new List<Questionnaire>();
        }
    }
}
