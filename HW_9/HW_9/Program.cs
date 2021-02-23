using System;
using HW_9;


namespace HW_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.FileInfo;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.GetCarAuthor:
                    GetData.GetDataCarAuthor();
                    break;
                case ExamplesEnumeration.FileInfo:
                    FileInfoEx.ShowFilesInfo();
                    break;
            }
        }
    }
}
