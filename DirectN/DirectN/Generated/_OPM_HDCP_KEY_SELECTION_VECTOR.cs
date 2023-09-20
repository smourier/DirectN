// generated from <Windows SDK Path>\um\opmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _OPM_HDCP_KEY_SELECTION_VECTOR
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public byte[] abKeySelectionVector;
    }
}
