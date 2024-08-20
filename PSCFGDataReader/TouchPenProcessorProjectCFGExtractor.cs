using PSCFGDataReader.Data;
#if RELEASE_LIBSURFACETOUCHOEMB1_2022_902_48_ARM64 || DEBUG_LIBSURFACETOUCHOEMB1_2022_902_48_ARM64
using PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64;
#elif RELEASE_TOUCHPENPROCESSOR0C37_15_15_137_0_AMD64 || DEBUG_TOUCHPENPROCESSOR0C37_15_15_137_0_AMD64
using PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64;
#elif RELEASE_TOUCHPENPROCESSOR0C38_19_14_139_0_ARM64 || DEBUG_TOUCHPENPROCESSOR0C38_19_14_139_0_ARM64
using PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64;
#elif RELEASE_TOUCHPENPROCESSOR0996_4_253_137_0_ARM64 || DEBUG_TOUCHPENPROCESSOR0996_4_253_137_0_ARM64
using PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64;
#elif RELEASE_LIBSURFACETOUCH_C1 || DEBUG_LIBSURFACETOUCH_C1
using PSCFGDataReader.Data.libsurfacetouch_c1;
#else
#error No processor defined
#endif

namespace PSCFGDataReader
{
    public class TouchPenProcessorProjectCFGExtractor
    {
        /// <summary>Looks for the next occurrence of a sequence in a byte array</summary>
        /// <param name="array">Array that will be scanned</param>
        /// <param name="start">Index in the array at which scanning will begin</param>
        /// <param name="sequence">Sequence the array will be scanned for</param>
        /// <returns>
        ///   The index of the next occurrence of the sequence of -1 if not found
        /// </returns>
        private static int findSequence(byte[] array, int start, byte[] sequence)
        {
            int end = array.Length - sequence.Length; // past here no match is possible
            byte firstByte = sequence[0]; // cached to tell compiler there's no aliasing

            while (start <= end)
            {
                // scan for first byte only. compiler-friendly.
                if (array[start] == firstByte)
                {
                    // scan for rest of sequence
                    for (int offset = 1; ; ++offset)
                    {
                        if (offset == sequence.Length)
                        { // full sequence matched?
                            return start;
                        }
                        else if (array[start + offset] != sequence[offset])
                        {
                            break;
                        }
                    }
                }
                ++start;
            }

            // end of array reached without match
            return -1;
        }

        public static byte[][] LocateAndExtractEveryPSDBInTouchPenProcessorBinary(string FilePath)
        {
            List<byte[]> PSCFGs = [];

            byte[] fileBuffer = File.ReadAllBytes(FilePath);
            using Stream stream = File.OpenRead(FilePath);
            using BinaryReader br = new(stream);

            int start = 0;
            int index;

            while ((index = findSequence(fileBuffer, start, Constants.PSDBHeader)) != -1)
            {
                _ = stream.Seek(index, SeekOrigin.Begin);
                ConfigHeaderStruct Header = br.FromBinaryReader<ConfigHeaderStruct>();

                if (Header.LenFile <= fileBuffer.Length - index) //&& Header.LenFile > 0)
                {
                    int lengthToRead = (int)Header.LenFile;
                    if (Header.LenFile == 0)
                    {
                        lengthToRead = fileBuffer.Length - index;
                    }

                    _ = stream.Seek(index, SeekOrigin.Begin);
                    byte[] buffer = br.ReadBytes(lengthToRead);

                    PSCFGs.Add(buffer);
                }

                start = index + Constants.PSDBHeader.Length;
            }

            return PSCFGs.ToArray();
        }

        public static string GetFriendlyName(byte[] buffer)
        {
            DecompiledProjectFile.DecompiledConfigurationFileStruct decompiledConfigurationFileStruct = DSCFG.GetDecompiledConfigurationFileStruct(buffer);
            ushort projectId = decompiledConfigurationFileStruct.Header.ProjectVersion.ProjId;

            string resultingFileName = $"PS_CFG_DATA_{projectId:X4}";

            if (Enum.IsDefined(typeof(CodenameProjectId), projectId))
            {
                resultingFileName = $"PS_CFG_DATA_{Enum.GetName(typeof(CodenameProjectId), projectId)}";
            }

            return resultingFileName;
        }
    }
}
