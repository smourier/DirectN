// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct REGFILTER
    {
        public Guid Clsid;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
    }
}
