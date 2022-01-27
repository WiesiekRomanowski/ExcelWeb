using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models.Common;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExcelWeb.SL.Services
{
    public class ExcelService : IExcelService
    {
        private readonly IInputFormResolver _inputFormResolver;

        public ExcelService(IInputFormResolver inputFormResolver)
        {
            _inputFormResolver = inputFormResolver;
        }

        public ExcelPackage GetExcelFile(byte[] fileData)
        {
            try
            {
                using var stream = new MemoryStream(fileData);
                return new ExcelPackage(stream);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ExcelWorksheet GetExcelWorksheet(ExcelPackage excelFilePackage, string worksheetName)
        {
            try
            {
                return excelFilePackage.Workbook.Worksheets
                    .FirstOrDefault(x => x.Name == worksheetName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Questionnaire> LoopExcel(byte[] fileData)
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
    }
}
