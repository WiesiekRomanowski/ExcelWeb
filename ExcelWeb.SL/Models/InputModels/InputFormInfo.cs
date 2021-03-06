using ExcelWeb.SL.Enums;
using System.Collections.Generic;

namespace ExcelWeb.SL.Models.InputModels
{
    public static class InputFormInfo
    {
        public static List<(int counter, string question, string answers, QuestionType questionType)> GetInputFormInfo() => Info;

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
            (9, @"Co robi Pan/Pani po wystąpieniu objawów mogących świadczyć o chorobie?", @"konsultuję się z lekarzem;poszukuję informacji w aptece;poszukuję informacji w Internecie;pytam członków rodziny;idę do znachora/uzdrowiciela;nie podejmuję żadnego działania;inne", QuestionType.MultiChoice),
            (10, @"Jak często zdarza się Panu/Pani poszukiwać informacji związanych ze zdrowiem?", @"", QuestionType.SingleChoice),
            (11, @"Z jakiego powodu poszukuje Pan/Pani informacji zdrowotnej (można zaznaczyć kilka odpowiedzi):", @"profilaktycznie, kiedy chcę przeciwdziałać chorobie;interesują mnie tematy związane ze zdrowiem;w związku z objawami choroby u siebie/osoby bliskiej;w celu weryfikacji postawionej przez lekarza diagnozy;z powodu nieotrzymania odpowiedzi na moje pytania podczas wizyty lekarskiej;z powodu niezrozumienia informacji przekazywanej przez lekarza;inne", QuestionType.MultiChoice),
            (12, @"Jakiego typu informacji Pan/Pani poszukuje (można zaznaczyć kilka odpowiedzi):", @"o objawach chorób;o lekach na receptę, które przypisał mi lekarz;o lekach, które mogę nabyć bez recepty;o szczepieniach;o metodach leczenia;o zabiegach operacyjnych;o zdrowym stylu życia;o odchudzaniu;o stosowaniu suplementów diety;o kwestiach dotyczących krwiodawstwa/transplantologii;inne", QuestionType.MultiChoice),
            (13, @" od lekarzy", @"Skąd czerpie Pan/Pani informacje zdrowotne? Jeśli korzysta Pan/Pani z danego źródła, to proszę zaznaczyć na skali, jak ocenia Pan/Pani poziom satysfakcji z uzyskiwanych informacji. Jeśli z danego źródła Pan/Pani nie korzysta, to proszę zaznaczyć opcję 'nie korzystam'", QuestionType.SingleChoiceAddName),
            (14, @"w aptece", @"Skąd czerpie Pan/Pani informacje zdrowotne? Jeśli korzysta Pan/Pani z danego źródła, to proszę zaznaczyć na skali, jak ocenia Pan/Pani poziom satysfakcji z uzyskiwanych informacji. Jeśli z danego źródła Pan/Pani nie korzysta, to proszę zaznaczyć opcję 'nie korzystam'", QuestionType.SingleChoiceAddName),
            (15, @"od pielęgniarek ", @"Skąd czerpie Pan/Pani informacje zdrowotne? Jeśli korzysta Pan/Pani z danego źródła, to proszę zaznaczyć na skali, jak ocenia Pan/Pani poziom satysfakcji z uzyskiwanych informacji. Jeśli z danego źródła Pan/Pani nie korzysta, to proszę zaznaczyć opcję 'nie korzystam'", QuestionType.SingleChoiceAddName),
            (16, @"z Internetu ", @"Skąd czerpie Pan/Pani informacje zdrowotne? Jeśli korzysta Pan/Pani z danego źródła, to proszę zaznaczyć na skali, jak ocenia Pan/Pani poziom satysfakcji z uzyskiwanych informacji. Jeśli z danego źródła Pan/Pani nie korzysta, to proszę zaznaczyć opcję 'nie korzystam'", QuestionType.SingleChoiceAddName),
            (17, @"z reklam ", @"Skąd czerpie Pan/Pani informacje zdrowotne? Jeśli korzysta Pan/Pani z danego źródła, to proszę zaznaczyć na skali, jak ocenia Pan/Pani poziom satysfakcji z uzyskiwanych informacji. Jeśli z danego źródła Pan/Pani nie korzysta, to proszę zaznaczyć opcję 'nie korzystam'", QuestionType.SingleChoiceAddName),
            (18, @"z programów telewizyjnych/audycji radiowych ", @"Skąd czerpie Pan/Pani informacje zdrowotne? Jeśli korzysta Pan/Pani z danego źródła, to proszę zaznaczyć na skali, jak ocenia Pan/Pani poziom satysfakcji z uzyskiwanych informacji. Jeśli z danego źródła Pan/Pani nie korzysta, to proszę zaznaczyć opcję 'nie korzystam'", QuestionType.SingleChoiceAddName),
            (19, @"od członków rodziny/znajomych ", @"Skąd czerpie Pan/Pani informacje zdrowotne? Jeśli korzysta Pan/Pani z danego źródła, to proszę zaznaczyć na skali, jak ocenia Pan/Pani poziom satysfakcji z uzyskiwanych informacji. Jeśli z danego źródła Pan/Pani nie korzysta, to proszę zaznaczyć opcję 'nie korzystam'", QuestionType.SingleChoiceAddName),
            (20, @"Jeśli czerpie Pan/Pani informacje zdrowotne ze źródeł niewymienionych wyżej, to proszę podać jakich:", @"", QuestionType.Other),
            (21, @"Jeśli poszukuje Pan/Pani informacji zdrowotnej w Internecie, to proszę doprecyzować, z jakich źródeł najczęściej Pan/Pani korzysta (można zaznaczyć kilka odpowiedzi)?", @"nigdy nie poszukuję informacji zdrowotnych w Internecie;fora internetowe;media społecznościowe;portale medyczne;czasopisma medyczne ukazujące się online;blogi/vlogi lekarzy;nie wiem, wybieram źródła sugerowane przez wyszukiwarkę;inne", QuestionType.MultiChoice),
            (22, @"Skąd chciałby Pan/chciałaby Pani  czerpać informacje zdrowotne, gdyby był Pan przekonany/ byłaby Pani przekonana, że są to informacje wiarygodne i łatwo dostępne (można zaznaczyć kilka odpowiedzi)?", @"od lekarzy;w aptece;od pielęgniarek;na forach internetowych;w mediach społecznościowych;na portalach medycznych;w czasopismach medycznych ukazujących się online;na blogach/vlogach lekarzy;z telewizji;z radia;od członków rodziny;inne", QuestionType.MultiChoice),
            (23, @"Czy zdarza się Panu/Pani nie konsultować objawów mogących świadczyć o chorobie z lekarzem? Jeśli tak, to proszę zaznaczyć jakie są tego powody (można zaznaczyć kilka odpowiedzi):", @"zawsze konsultuję objawy mogące świadczyć o chorobie z lekarzem;nie konsultuję się w sytuacji występowania łagodnych dolegliwości;nie konsultuję się w przypadku wystąpienia dolegliwości, które są mi znane i wiem jak samodzielnie je leczyć;nie konsultuję się ze względu na długi czas oczekiwania lub problem z dostępem do lekarza;nie konsultuję się, gdy odczuwam wstyd lub lęk;nie konsultuję się ze względu na chęć zaoszczędzenia czasu i/lub pieniędzy;nie konsultuję się ze względu na dużą odległość do ośrodka zdrowia;nigdy nie konsultuję się z lekarzem, nie wierzę we współczesną medycynę;inne", QuestionType.MultiChoice),
            (24, @"Czy zdarza się Panu/Pani stosować jakiekolwiek leki bez konsultacji z lekarzem?", @"", QuestionType.SingleChoice),
            (25, @"Czy zdarza się Panu/Pani modyfikować stosowanie leku lub metody leczenia sugerowane przez lekarza pod wpływem informacji zaczerpniętych z innych źródeł?", @"", QuestionType.SingleChoice),
            (26, @"Czy stosuje Pan/Pani suplementy diety lub inne produkty dostępne w aptekach, a niebędące lekami, bez konsultacji z lekarzem?", @"", QuestionType.SingleChoice),
            (27, @"Wiek", @"", QuestionType.SingleChoice),
            (28, @"Płeć", @"", QuestionType.SingleChoice),
            (29, @"Wykształcenie", @"", QuestionType.SingleChoice),
            (30, @"Sytuacja zawodowa", @"", QuestionType.SingleChoice),
            (31, @"Miejsce zamieszkania", @"", QuestionType.SingleChoice),
            (32, @"Stan cywilny", @"", QuestionType.SingleChoice),
            (33, @"Jak ocenia Pan/Pani swoją sytuację ekonomiczną?", @"", QuestionType.SingleChoice)
        };
    }
}
