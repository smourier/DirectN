// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct REGFILTERPINS
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string strName;
        public bool bRendered;
        public bool bOutput;
        public bool bZero;
        public bool bMany;
        public IntPtr clsConnectsToFilter;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string strConnectsToPin;
        public uint nMediaTypes;
        public IntPtr lpMediaType;
    }
}
