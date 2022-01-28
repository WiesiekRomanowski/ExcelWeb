using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models.Common;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExcelWeb.SL.Services
{
    public class ExcelService : IExcelService
    {
        private readonly IInputFormResolver _inputFormResolver;

        public ExcelService(IInputFormResolver inputFormResolver)
        {
            _inputFormResolver = inputFormResolver;
        }

        public List<Questionnaire> LoopInputExcel(byte[] fileData)
        {
            try
            {
                var questionnaries = new List<Questionnaire>();

                using var stream = new MemoryStream(fileData);
                using var excelPackage = new ExcelPackage(stream);
                foreach (var worksheet in excelPackage.Workbook.Worksheets)
                {
                    for (int i = worksheet.Dimension.Start.Row; i < worksheet.Dimension.End.Row; i++)
                    {
                        var questionnaire = new Questionnaire
                        {
                            Counter = i - 1
                        };

                        for (int j = worksheet.Dimension.Start.Column; j < worksheet.Dimension.End.Column; j++)
                        {
                            var question = new Question
                            {
                                Counter = j,
                                Name = worksheet.Cells[1, j].Value.ToString(),
                                Answer = worksheet.Cells[i, j].Value?.ToString() ?? string.Empty,
                                PossibleAnswers = _inputFormResolver.GetPossibleAnswers(j),
                                QuestionType = _inputFormResolver.GetQuestionType(j)
                            };
                            questionnaire.Questions.Add(question);
                        }
                        questionnaries.Add(questionnaire);
                    }
                }

                return questionnaries;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public byte[] LoopOutputExcel(List<Questionnaire> questionnaries)
        {
            try
            {
                using var excelPackage = new ExcelPackage();
                var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                for (int i = 1; i <= questionnaries.Count; i++)
                {
                    for (int j = 1; j <= questionnaries[i - 1].Questions.Count; j++)
                    {
                        worksheet.Cells[i, j].Value = questionnaries[i - 1].Questions[j - 1].Answer;
                    }
                }
                return excelPackage.GetAsByteArray();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
