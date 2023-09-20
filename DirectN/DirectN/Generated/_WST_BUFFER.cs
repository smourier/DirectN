// generated from <Windows SDK Path>\shared\ksmedia.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WST_BUFFER
    {
        public _VBICODECFILTERING_SCANLINES ScanlinesRequested;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)] 
        public _WST_BUFFER_LINE[] WstLines;
    }
}
