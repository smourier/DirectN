// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi.h(2390,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DISPLAY_COLOR_SPACE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public float[] PrimaryCoordinates;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public float[] WhitePoints;
    }
}
