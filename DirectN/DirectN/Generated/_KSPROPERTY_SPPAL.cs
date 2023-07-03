// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(3614,9)
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
