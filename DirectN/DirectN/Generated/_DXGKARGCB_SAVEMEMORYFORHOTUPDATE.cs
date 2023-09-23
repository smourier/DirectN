// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_SAVEMEMORYFORHOTUPDATE
    {
        public uint NumDataMemoryRanges;
        public IntPtr pDataMemoryRanges;
        public IntPtr pDataMdl;
        public uint DataSize;
        public IntPtr pData;
        public uint MetaDataSize;
        public IntPtr pMetaData;
    }
}
