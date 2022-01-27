using ExcelWeb.SL.Enums;

namespace ExcelWeb.SL.Interfaces
{
    public interface IInputFormResolver
    {
        QuestionType GetQuestionType(int counter);
        string[] GetPossibleAnswers(int counter);
    }
}
