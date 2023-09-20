// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RESTOREMEMORYFORHOTUPDATE
    {
        public _DXGK_RESTOREMEMORYFORHOTUPDATEFLAGS Flags;
        public int pDataMdl;
        public uint MetaDataSize;
        public IntPtr pMetaData;
    }
}
