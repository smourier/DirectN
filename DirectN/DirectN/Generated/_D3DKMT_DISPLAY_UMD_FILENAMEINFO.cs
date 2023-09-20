// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_DISPLAY_UMD_FILENAMEINFO
    {
        public _KMT_DISPLAY_UMD_VERSION Version;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string UmdFileName;
    }
}
