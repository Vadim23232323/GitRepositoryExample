using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    public static class FileInfoEx
    {

        public static void ShowFilesInfo()
        {
            var fileInfo = new FileInfo(@"d:\courses\GitRepositoryExample\HW_9\txt\ShowFileInfo.txt");

            if (!fileInfo.Exists)
            {

                try
                {
                    fileInfo.Create();
                    Console.WriteLine($"File {fileInfo.FullName} was successfully created");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else Console.WriteLine(fileInfo.FullName);
        }


    }
}
