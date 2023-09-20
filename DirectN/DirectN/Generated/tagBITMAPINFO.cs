// generated from <Windows SDK Path>\um\wingdi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagBITMAPINFO
    {
        public tagBITMAPINFOHEADER bmiHeader;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagRGBQUAD[] bmiColors;
    }
}
