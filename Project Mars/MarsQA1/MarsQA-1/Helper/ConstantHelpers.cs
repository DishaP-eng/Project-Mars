using System;
using System.IO;

namespace MarsQA1.Helper;

public class ConstantHelpers
{
        //Base Url
        public static string Url = "http://localhost:8080/";

        //Mars.Xlsx Path
        private static string CurrentPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

        public static string MarsDataPath = CurrentPath +  @"MarsQA-1/SpecflowData/Mars.xlsx";
           
        //ScreenshotPath
       // public static string ScreenshotPath =CurrentPath + @"MarsQA-1\TestReports\Screenshots\";

        //ExtentReportsPath
      //  public static string ReportsPath = CurrentPath + @"MarsQA-1\TestReports\Test_files_" + DateTime.Now.ToString("ddMMyy HHmmss") +".html";

       //ReportXML Path
       // public static string ReportXMLPath = CurrentPath + @"MarsQA-1\TestReports" + "ExtentRepot_Config.xml";
    

}