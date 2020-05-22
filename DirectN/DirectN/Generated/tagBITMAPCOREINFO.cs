// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(924,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagBITMAPCOREINFO
    {
        public tagBITMAPCOREHEADER bmciHeader;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagRGBTRIPLE[] bmciColors;
    }
}
