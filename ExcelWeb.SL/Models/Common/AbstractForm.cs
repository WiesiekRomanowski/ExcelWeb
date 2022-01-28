using System.Collections.Generic;

namespace ExcelWeb.SL.Models.Common
{
    public abstract class AbstractForm
    {
        public List<Questionnaire> Questionnaries { get; set; }

        public AbstractForm()
        {
            Questionnaries = new List<Questionnaire>();
        }
    }
}
