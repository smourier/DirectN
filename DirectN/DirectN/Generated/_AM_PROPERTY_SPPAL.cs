// generated from <Windows SDK Path>\um\dvdmedia.h
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
