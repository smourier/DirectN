// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusData
    {
        public Guid rApp;
        public uint dwFlags;
        public uint dwData;
        public uint ExtendedInfoValidMask;
        public uint ExtendedInfoData;
    }
}
