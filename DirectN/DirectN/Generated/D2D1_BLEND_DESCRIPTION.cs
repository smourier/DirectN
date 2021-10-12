// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(352,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Blend description which configures a blend transform object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_BLEND_DESCRIPTION
    {
        public D2D1_BLEND sourceBlend;
        public D2D1_BLEND destinationBlend;
        public D2D1_BLEND_OPERATION blendOperation;
        public D2D1_BLEND sourceBlendAlpha;
        public D2D1_BLEND destinationBlendAlpha;
        public D2D1_BLEND_OPERATION blendOperationAlpha;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] blendFactor;
    }
}
