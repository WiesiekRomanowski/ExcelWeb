using ExcelWeb.SL.Enums;

namespace ExcelWeb.SL.Models.Common
{
    public class Question
    {
        public int Counter { get; set; }
        public string Name { get; set; }
        public string Answer { get; set; }
        public string[] PossibleAnswers { get; set; }
        public QuestionType QuestionType { get; set; }
    }
}
