// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCOLORCORRECTPALETTE
    {
        public tagEMR emr;
        public uint ihPalette;
        public uint nFirstEntry;
        public uint nPalEntries;
        public uint nReserved;
    }
}
