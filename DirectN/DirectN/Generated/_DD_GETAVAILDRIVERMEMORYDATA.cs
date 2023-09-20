// generated from <Windows SDK Path>\um\ddrawint.h
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
