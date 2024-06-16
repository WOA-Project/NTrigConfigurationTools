namespace PSCFGDataReader
{
    internal class DSCFGExtras
    {
        public static void LocateEveryPSDBInBinary(string FilePath)
        {
            byte[][] PSCFGs = TouchPenProcessorProjectCFGExtractor.LocateAndExtractEveryPSDBInTouchPenProcessorBinary(FilePath);
            foreach (byte[] PSCFG in PSCFGs)
            {
                string resultingFileName = TouchPenProcessorProjectCFGExtractor.GetFriendlyName(PSCFG);

                //resultingFileName = $"{FilePath[..^4]}{Path.DirectorySeparatorChar}{resultingFileName}.bin";

                /*if (!Directory.Exists(FilePath[..^4]))
                {
                    Directory.CreateDirectory(FilePath[..^4]);
                }*/

                if (Directory.Exists(FilePath[..^4]))
                {
                    if (Directory.EnumerateFiles(FilePath[..^4]).Count() == 0)
                    {
                        Directory.Delete(FilePath[..^4]);
                    }
                }

                Console.WriteLine(FilePath);
                Console.WriteLine(resultingFileName);
                Console.WriteLine();

                //File.WriteAllBytes(resultingFileName, PSCFG);
            }
        }
    }
}