using ExcelWeb.SL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWeb.SL.Models.OutputModels
{
    public static class OutputFormInfo
    {
        public static List<(int counter, string question, string answers, QuestionType questionType)> GetOutputFormInfo() => Info;

        private static readonly List<(int counter, string question, string answers, QuestionType questionType)> Info = new()
        {
            (1, @"ID", @"", QuestionType.Id),
            (2, @"Godzina rozpoczęcia", @"", QuestionType.DateTime),
            (3, @"Godzina ukończenia", @"", QuestionType.DateTime),
            (4, @"Adres e-mail", @"", QuestionType.Email),
            (5, @"Nazwa", @"", QuestionType.Name),
            (6, @"Jak ocenia Pan/Pani stan swojego zdrowia? Proszę zaznaczyć na skali od 1-10, gdzie 10 oznacza najlepszy stan zdrowia jaki można sobie wyobrazić, a 1 najgorszy stan zdrowia jaki można sobie wyobrazić.", @"", QuestionType.SingleChoice),
            (7, @"Czy ma Pan/Pani zdiagnozowaną jakąś chorobę przewlekłą/ schorzenie o długotrwałym przebiegu/ niepełnosprawność?", @"", QuestionType.Bool),
            (8, @"*Jeśli nie ma Pan/Pani zdiagnozowanych żadnych chorób przewlekłych/schorzeń o długotrwałym przebiegu/niepełnosprawności, to proszę pominąć to pytanie. Jeśli ma Pan/Pani zdiagnozowaną jakąś choro...", @"", QuestionType.SingleChoice),
            (9, @"konsultuję się z lekarzem", @"", QuestionType.Bool),
            (10, @"poszukuję informacji w aptece", @"", QuestionType.Bool),
            (11, @"poszukuję informacji w Internecie", @"", QuestionType.Bool),
            (12, @"pytam członków rodziny", @"", QuestionType.Bool),
            (13, @"idę do znachora/uzdrowiciela", @"", QuestionType.Bool),
            (14, @"nie podejmuję żadnego działania", @"", QuestionType.Bool),
            (15, @"inne", @"", QuestionType.Bool),
            (16, @"Jak często zdarza się Panu/Pani poszukiwać informacji związanych ze zdrowiem?", @"", QuestionType.SingleChoice)
        };
    }
}
