using ExcelWeb.SL.Models.FileModels;
using ExcelWeb.SL.Models.InputModels;
using ExcelWeb.SL.Models.OutputModels;

namespace ExcelWeb.SL.Interfaces
{
    public interface IFormService
    {
        InputForm GetInputFormData(ExcelFileModel fileModel);
        OutputForm GetOutputFormData(InputForm inputForm);
        byte[] GetOutputExcelFile(OutputForm inputForm);
    }
}
