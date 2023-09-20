// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusHDCPKeyData
    {
        public Guid rApp;
        public uint dwFlags;
        public uint dwHDCPFlags;
        public Guid BKey;
        public Guid Reserved1;
        public Guid Reserved2;
    }
}
