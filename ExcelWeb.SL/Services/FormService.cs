using ExcelWeb.SL.Enums;
using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models.Common;
using ExcelWeb.SL.Models.FileModels;
using ExcelWeb.SL.Models.InputModels;
using ExcelWeb.SL.Models.OutputModels;
using System;
using System.Linq;

namespace ExcelWeb.SL.Services
{
    public class FormService : IFormService
    {
        private readonly IExcelService _excelService;

        private InputForm _inputForm;
        private OutputForm _outputForm;

        public FormService(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public InputForm GetInputFormData(ExcelFileModel fileModel)
        {
            try
            {
                SetInputForm(fileModel.FileData);
                return _inputForm;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OutputForm GetOutputFormData(InputForm inputForm)
        {
            try
            {
                SetOutputForm(inputForm);
                return _outputForm;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public byte[] GetOutputExcelFile(OutputForm outputForm)
        {
            return _excelService.LoopOutputExcel(outputForm.Questionnaries);
        }

        private void SetInputForm(byte[] fileData)
        {
            _inputForm = new InputForm
            {
                Questionnaries = _excelService.LoopInputExcel(fileData)
            };
        }

        private void SetOutputForm(InputForm inputForm)
        {
            _outputForm = new OutputForm();
            foreach (var inputQuestionnaire in inputForm.Questionnaries)
            {
                var outputQuestionnaire = new Questionnaire();
                foreach (var inputQuestion in inputQuestionnaire.Questions)
                {
                    if (CanAddOutput(inputQuestion.QuestionType))
                    {
                        var outputQuestion = new Question
                        {
                            Answer = DoAddQuestionValue(inputQuestion) 
                            ? $"{inputQuestion.PossibleAnswers.First()}: {inputQuestion.Answer}" 
                            : inputQuestion.Answer
                        };
                        outputQuestionnaire.Questions.Add(outputQuestion);
                    }

                    if (IsMultichoice(inputQuestion.QuestionType))
                    {
                        foreach (var possibleAnswer in inputQuestion.PossibleAnswers)
                        {
                            var answerQuestion = new Question
                            {
                                Answer = IsHeader(inputQuestion) 
                                    ? $"{inputQuestion.Name}: {possibleAnswer}" 
                                    : BoolToString(AnswerChecked(inputQuestion.PossibleAnswers, possibleAnswer, inputQuestion.Answer))
                            };
                            outputQuestionnaire.Questions.Add(answerQuestion);
                        }
                    }
                }
                _outputForm.Questionnaries.Add(outputQuestionnaire);
            }
        }

        private static bool DoAddQuestionValue(Question question)
        {
            return question.QuestionType == QuestionType.SingleChoiceAddName
                       && question.Name == question.Answer;
        }

        private static bool IsMultichoice(QuestionType questionType)
            => questionType == QuestionType.MultiChoice;

        private static bool CanAddOutput(QuestionType questionType)
        {
            return questionType != QuestionType.DateTime 
                && questionType != QuestionType.Email 
                && questionType != QuestionType.Name
                && questionType != QuestionType.MultiChoice;
        }

        private static bool IsHeader(Question question) 
            => question.Name == question.Answer;

        private static bool AnswerChecked(string[] possibleAnswers, string currentAnswer, string answersChecked)
        {
            var answersCheckedList = answersChecked.Split(';').Select(x => x.Trim()).ToList();
            var answersCheckedDuplicate = answersChecked.Split(';').Select(x => x.Trim()).ToList();

            if (answersCheckedList.Contains(currentAnswer))
                return true;

            if (currentAnswer != "inne")
                return false;

            foreach (var answerChecked in answersCheckedList)
                if (possibleAnswers.Contains(answerChecked))
                    answersCheckedDuplicate.Remove(answerChecked);

            var duplicateCopy = answersCheckedDuplicate
                .Where(x => !string.IsNullOrWhiteSpace(x)).Distinct().ToList();
            return duplicateCopy.Any();
        }

        private static string BoolToString(bool value) 
            => value ? "tak" : "nie";
    }
}
