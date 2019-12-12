using CSSaveToFileSysFW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSaveToFileSysCLIFW
{
    class Program
    {
        private static int sqlConnectionString = 0;
        private static int templateName = 1;
        private static int outPath = 2;
        private static int outPathProcess = 3;
        private static int outPathSuccess = 4;
        private static int outPathError = 5;

        static void Main(string[] args)
        {

            if (args.Length != 6)
            {
                Console.WriteLine(args.Length);
                Console.WriteLine("<sqlConnectionString> <templateName> <outPath> <outPathProcess> <outPathSuccess> <outPathError>");
            }

            string[] files =
                Directory.GetFiles(args[outPath], "*.xml", SearchOption.TopDirectoryOnly);

            new SaveToFileSysFW(
            args[sqlConnectionString],
            args[templateName],
            args[outPath],
            args[outPathProcess],
            args[outPathSuccess],
            args[outPathError]
            ).Load();
        }
    }
}
