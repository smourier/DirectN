// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct _OUTPUTDUPL_CONTEXT_DEBUG_INFO
    {
        public _OUTPUTDUPL_CONTEXT_DEBUG_STATUS Status;
        public IntPtr ProcessID;
        public uint AccumulatedPresents;
        public long LastPresentTime;
        public long LastMouseTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)] 
        public string ProcessName;
    }
}
