﻿using System.Runtime.InteropServices;
using static PSCFGDataReader.PSCFGData_TouchPenProcessor0C37;

namespace PSCFGDataReader
{
    internal partial class PSCFGExtras
    {
        public static void ParseRaw(string FilePath)
        {
            DecompiledProjectFile.DecompiledConfigurationFileStruct decompiledConfigurationFile = DSCFG.GetDecompiledConfigurationFileStructFromBinaryFilePath(FilePath);

            foreach (DecompiledProjectFile.DecompiledConfigSection section in decompiledConfigurationFile.ConfigSections)
            {
                Console.WriteLine("Section Id: " + section.Header.Id);
                Console.WriteLine("Section Type: " + section.Header.Type);
                Console.WriteLine("Section Length: " + section.Header.Len);

                if (Enum.IsDefined(typeof(SectionId), section.Header.Id))
                {
                    SectionId sectionId = (SectionId)section.Header.Id;
                    Console.WriteLine("Section ID (Friendly Name): " + sectionId);

                    File.WriteAllBytes($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.bin", section.Payload);

                    using MemoryStream payloadStream = new(section.Payload);
                    using BinaryReader br = new(payloadStream);

                    switch (sectionId)
                    {
                        case SectionId.Topology:
                            if (section.Payload.Length != Marshal.SizeOf<TopologyDataCfg>())
                            {
                                Console.WriteLine("Invalid TopologyDataCfg size!");
                                break;
                            }

                            TopologyDataCfg topologyDataCfg = br.FromBinaryReader<TopologyDataCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", topologyDataCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.PenJnr:
                            if (section.Payload.Length != Marshal.SizeOf<PenJnrCfg>())
                            {
                                Console.WriteLine("Invalid PenJnrCfg size!");
                                break;
                            }

                            PenJnrCfg penJnrCfg = br.FromBinaryReader<PenJnrCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", penJnrCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.PenTrackingThresholds:
                            if (section.Payload.Length != Marshal.SizeOf<PenThrsAndTrackCfgTuning>())
                            {
                                Console.WriteLine("Invalid PenThrsAndTrackCfgTuning size!");
                                break;
                            }

                            PenThrsAndTrackCfgTuning penThrsAndTrackCfgTuning = br.FromBinaryReader<PenThrsAndTrackCfgTuning>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", penThrsAndTrackCfgTuning.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.ReportMechanism:
                            if (section.Payload.Length != Marshal.SizeOf<ReportMechanism>())
                            {
                                Console.WriteLine("Invalid ReportMechanism size!");
                                break;
                            }

                            ReportMechanism reportMechanism = br.FromBinaryReader<ReportMechanism>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", reportMechanism.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.TouchPostProcessing:
                            if (section.Payload.Length != Marshal.SizeOf<TouchPostProcessingCfg>())
                            {
                                Console.WriteLine("Invalid TouchPostProcessingCfg size!");
                                break;
                            }

                            TouchPostProcessingCfg touchPostProcessingCfg = br.FromBinaryReader<TouchPostProcessingCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", touchPostProcessingCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.Descriptor:
                            if (section.Payload.Length != Marshal.SizeOf<DescriptorsCfg>())
                            {
                                Console.WriteLine("Invalid DescriptorCfg size!");
                                break;
                            }

                            DescriptorsCfg descriptorCfg = br.FromBinaryReader<DescriptorsCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", descriptorCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.TouchData:
                            if (section.Payload.Length != Marshal.SizeOf<TouchTrackDataCfg>())
                            {
                                Console.WriteLine("Invalid TouchDataCfg size!");
                                break;
                            }

                            TouchTrackDataCfg touchDataCfg = br.FromBinaryReader<TouchTrackDataCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", touchDataCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.StaticConfig:
                            if (section.Payload.Length != Marshal.SizeOf<StaticConfig>())
                            {
                                Console.WriteLine("Invalid StaticConfig size!");
                                break;
                            }

                            StaticConfig staticConfig = br.FromBinaryReader<StaticConfig>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", staticConfig.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.TouchDetection:
                            if (section.Payload.Length != Marshal.SizeOf<TouchDetectionCfg>())
                            {
                                Console.WriteLine("Invalid TouchDetectionCfg size!");
                                break;
                            }

                            TouchDetectionCfg touchDetectionCfg = br.FromBinaryReader<TouchDetectionCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", touchDetectionCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.CampoConfig:
                            if (section.Payload.Length != Marshal.SizeOf<CampoCfg>())
                            {
                                Console.WriteLine("Invalid CampoCfg size!");
                                break;
                            }

                            CampoCfg campoConfig = br.FromBinaryReader<CampoCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", campoConfig.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.TelemetryConfig:
                            if (section.Payload.Length != Marshal.SizeOf<TelemetryCfg>())
                            {
                                Console.WriteLine("Invalid TelemetryCfg size!");
                                break;
                            }

                            TelemetryCfg telemetryConfig = br.FromBinaryReader<TelemetryCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", telemetryConfig.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.DataSelction:
                            if (section.Payload.Length != Marshal.SizeOf<DataSelectionCfg>())
                            {
                                Console.WriteLine("Invalid DataSelectionCfg size!");
                                break;
                            }

                            DataSelectionCfg dataSelctionCfg = br.FromBinaryReader<DataSelectionCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", dataSelctionCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.PenMagToBits:
                            if (section.Payload.Length != Marshal.SizeOf<PenMagToBitsCfg>())
                            {
                                Console.WriteLine("Invalid PenMagToBitsCfg size!");
                                break;
                            }

                            PenMagToBitsCfg penMagToBitsCfg = br.FromBinaryReader<PenMagToBitsCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", penMagToBitsCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.PenCenterOfMass:
                            if (section.Payload.Length != Marshal.SizeOf<PenCenterOfMassCfg>())
                            {
                                Console.WriteLine("Invalid PenCenterOfMassCfg size!");
                                break;
                            }

                            PenCenterOfMassCfg penCenterOfMassCfg = br.FromBinaryReader<PenCenterOfMassCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", penCenterOfMassCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.PenDigitalProcessing:
                            if (section.Payload.Length != Marshal.SizeOf<PenDigitalProcessingCfg>())
                            {
                                Console.WriteLine("Invalid PenDigitalProcessingCfg size!");
                                break;
                            }

                            PenDigitalProcessingCfg penDigitalProcessingCfg = br.FromBinaryReader<PenDigitalProcessingCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", penDigitalProcessingCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                        case SectionId.PenZeroForceInking:
                            if (section.Payload.Length != Marshal.SizeOf<PenZeroForceInkingCfg>())
                            {
                                Console.WriteLine("Invalid PenZeroForceInkingCfg size!");
                                break;
                            }

                            PenZeroForceInkingCfg penZeroForceInkingCfg = br.FromBinaryReader<PenZeroForceInkingCfg>();
                            File.WriteAllText($"{Path.GetDirectoryName(FilePath)}\\{sectionId}.xml", penZeroForceInkingCfg.Serialize(), System.Text.Encoding.Unicode);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unknown Section ID Friendly Name!");

                    File.WriteAllBytes($"{Path.GetDirectoryName(FilePath)}\\{section.Header.Id}.bin", section.Payload);
                }

                Console.WriteLine();
            }
        }

        public static void ParseRaw2(string SourceFilePath, string DestFilePath)
        {
            List<(ConfigSectionHeader sectionHeader, long offset)> mapping = new();

            using FileStream destinationStream = File.Open(DestFilePath, FileMode.Open, FileAccess.ReadWrite);
            using BinaryReader destinationBr = new(destinationStream);

            ConfigHeaderStruct destinationHeader = destinationBr.FromBinaryReader<ConfigHeaderStruct>();

            // Parse every section minus the checksum at the end

            while (destinationStream.Position < destinationHeader.LenFile - 2)
            {
                ConfigSectionHeader sectionHeader = destinationBr.FromBinaryReader<ConfigSectionHeader>();
                mapping.Add((sectionHeader, destinationStream.Position));
                destinationStream.Seek(sectionHeader.Len, SeekOrigin.Current); // Skip payload for now
            }

            using FileStream sourceStream = File.OpenRead(SourceFilePath);
            using BinaryReader sourceBr = new(sourceStream);

            ConfigHeaderStruct sourceHeader = sourceBr.FromBinaryReader<ConfigHeaderStruct>();

            // Parse every section minus the checksum at the end

            while (sourceStream.Position < sourceHeader.LenFile - 2)
            {
                ConfigSectionHeader sourceSectionHeader = sourceBr.FromBinaryReader<ConfigSectionHeader>();

                Console.WriteLine("Section Id: " + sourceSectionHeader.Id);
                Console.WriteLine("Section Type: " + sourceSectionHeader.Type);
                Console.WriteLine("Section Length: " + sourceSectionHeader.Len);

                if (Enum.IsDefined(typeof(SectionId), sourceSectionHeader.Id))
                {
                    SectionId sourceSectionId = (SectionId)sourceSectionHeader.Id;
                    Console.WriteLine("Section ID (Friendly Name): " + sourceSectionId);
                }
                else
                {
                    Console.WriteLine("Unknown Section ID Friendly Name!");
                }

                byte[] payload = sourceBr.ReadBytes(sourceSectionHeader.Len);

                foreach ((ConfigSectionHeader sectionHeader, long offset) in mapping)
                {
                    if (sectionHeader.Id == sourceSectionHeader.Id && sectionHeader.Len == payload.Length)
                    {
                        Console.WriteLine($"Writing at {offset}...");
                        destinationStream.Seek(offset, SeekOrigin.Begin);
                        destinationStream.Write(payload, 0, payload.Length);
                    }
                }

                //sourceStream.Seek(sourceSectionHeader.Len, SeekOrigin.Current); // Skip payload for now

                Console.WriteLine();
            }
        }
    }
}
