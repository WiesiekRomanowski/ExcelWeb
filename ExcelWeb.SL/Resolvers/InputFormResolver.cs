using ExcelWeb.SL.Enums;
using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models.InputModels;
using System.Collections.Generic;
using System.Linq;

namespace ExcelWeb.SL.Resolvers
{
    public class InputFormResolver : IInputFormResolver
    {
        private readonly List<(int counter, string question, string answers, QuestionType questionType)> _inputInfoList = InputFormInfo.GetInputFormInfo();

        public string[] GetPossibleAnswers(int counter)
        {
            var inputInfo = _inputInfoList.FirstOrDefault(x => x.counter == counter);
            return inputInfo.answers.Split(';');
        }

        public QuestionType GetQuestionType(int counter)
        {
            var inputInfo = _inputInfoList.FirstOrDefault(x => x.counter == counter);
            return inputInfo.questionType;
        }
    }
}
