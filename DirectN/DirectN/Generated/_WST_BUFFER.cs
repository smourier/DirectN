// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(4689,9)
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
