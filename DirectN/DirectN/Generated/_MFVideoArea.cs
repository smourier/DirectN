// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfobjects.h(2771,9)
using System.Runtime.InteropServices;
using SIZE = DirectN.tagSIZE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFVideoArea
    {
        public _MFOffset OffsetX;
        public _MFOffset OffsetY;
        public SIZE Area;
    }
}
