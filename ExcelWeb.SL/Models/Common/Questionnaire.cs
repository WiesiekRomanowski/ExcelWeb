using System.Collections.Generic;

namespace ExcelWeb.SL.Models.Common
{
    public class Questionnaire
    {
        public int Counter { get; set; }
        public List<Question> Questions { get; set; }

        public Questionnaire()
        {
            Questions = new List<Question>();
        }
    }
}
