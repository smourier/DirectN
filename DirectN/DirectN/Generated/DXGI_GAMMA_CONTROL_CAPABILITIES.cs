// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgitype.h(50,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_GAMMA_CONTROL_CAPABILITIES
    {
        public bool ScaleAndOffsetSupported;
        public float MaxConvertedValue;
        public float MinConvertedValue;
        public uint NumGammaControlPoints;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)] 
        public float[] ControlPointPositions;
    }
}
