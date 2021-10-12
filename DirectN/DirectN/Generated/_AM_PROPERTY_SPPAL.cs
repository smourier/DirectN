// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dvdmedia.h(99,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AM_PROPERTY_SPPAL
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public _AM_DVD_YUV[] sppal;
    }
}
