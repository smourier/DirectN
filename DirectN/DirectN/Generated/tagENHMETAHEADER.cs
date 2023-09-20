// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagENHMETAHEADER
    {
        public uint iType;
        public uint nSize;
        public _RECTL rclBounds;
        public _RECTL rclFrame;
        public uint dSignature;
        public uint nVersion;
        public uint nBytes;
        public uint nRecords;
        public ushort nHandles;
        public ushort sReserved;
        public uint nDescription;
        public uint offDescription;
        public uint nPalEntries;
        public tagSIZE szlDevice;
        public tagSIZE szlMillimeters;
        public uint cbPixelFormat;
        public uint offPixelFormat;
        public uint bOpenGL;
        public tagSIZE szlMicrometers;
    }
}
