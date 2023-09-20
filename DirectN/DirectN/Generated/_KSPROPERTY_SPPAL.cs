// generated from <Windows SDK Path>\shared\ksmedia.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSPROPERTY_SPPAL
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public _KS_DVD_YUV[] sppal;
    }
}
