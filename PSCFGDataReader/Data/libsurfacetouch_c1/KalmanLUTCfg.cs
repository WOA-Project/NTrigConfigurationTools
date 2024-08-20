﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct KalmanLUTCfg
    {
        public uint VelocitiesTableLength
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public ushort[] VelocitiesTable
        {
            get; set;
        }
        public uint NsrTableMTLength
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public ushort[] NsrTableMT
        {
            get; set;
        }
        public ushort NsrTableST
        {
            get; set;
        }
        public uint MeasurementStd2TableMtNumOfAxis
        {
            get; set;
        }
        public uint MeasurementStd2TableMtNumOfMeasuredStd
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public float[] MeasurementStd2TableMT
        {
            get; set;
        }
        public float MeasurementStd2TableST
        {
            get; set;
        }
        public float MeasurementStd2TableSeparated
        {
            get; set;
        }
        public uint ProcessStd2Length
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public uint[] ProcessStd2
        {
            get; set;
        }
    };
}
