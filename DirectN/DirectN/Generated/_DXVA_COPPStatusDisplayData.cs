// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusDisplayData
    {
        public Guid rApp;
        public uint dwFlags;
        public uint DisplayWidth;
        public uint DisplayHeight;
        public uint Format;
        public uint d3dFormat;
        public uint FreqNumerator;
        public uint FreqDenominator;
    }
}
