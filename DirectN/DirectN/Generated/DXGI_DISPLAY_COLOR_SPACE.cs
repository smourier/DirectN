// generated from <Windows SDK Path>\shared\dxgi.h
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
