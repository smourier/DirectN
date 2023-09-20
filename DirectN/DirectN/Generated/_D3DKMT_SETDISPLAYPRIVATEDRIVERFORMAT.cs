// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETDISPLAYPRIVATEDRIVERFORMAT
    {
        public uint hDevice;
        public uint VidPnSourceId;
        public uint PrivateDriverFormatAttribute;
    }
}
