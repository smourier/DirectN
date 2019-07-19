// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\opmapi.h(299,9)
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
