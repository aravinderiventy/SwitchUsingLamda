// See https://aka.ms/new-console-template for more information

//Switch using lamda expression

string fileType = Constants.ExcelFileType;
var result = fileType switch
{
    Constants.PdfFileType => ExportPdf(),
    Constants.ExcelFileType => ExportXls(),
    Constants.DocFileType => ExportDoc(),
    _ => null
};

Console.WriteLine(result);

string ExportPdf()
{
    Console.WriteLine("Pdf file Exported");
    return methodToExecute;
}

string ExportDoc()
{
    Console.WriteLine("Doc file Exported");
    return string.Empty;
}

string ExportXls ()
{
    Console.WriteLine("Xls file Exported");
    return string.Empty;
}


//Day name by number
int dayNum = Constants.Day1;

string dayName = dayNum switch
{
    Constants.Day1 => "Sunday",
    Constants.Day2 => "Monday",
    Constants.Day3 => "Tuesday",
    _ => "Invalid day"
};

Console.WriteLine(dayName);


public static class Constants
{
    public const string DocFileType = "Doc";
    public const string PdfFileType = "Pdf";
    public const string ExcelFileType = "Excel";

    public const int Day1 = 1;
    public const int Day2 = 2;
    public const int Day3 = 3;
}
