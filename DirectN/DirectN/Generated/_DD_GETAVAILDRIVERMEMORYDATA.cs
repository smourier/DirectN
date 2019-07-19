// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawint.h(1701,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETAVAILDRIVERMEMORYDATA
    {
        public IntPtr lpDD;
        public _DDSCAPS DDSCaps;
        public uint dwTotal;
        public uint dwFree;
        public HRESULT ddRVal;
        public IntPtr GetAvailDriverMemory;
    }
}
