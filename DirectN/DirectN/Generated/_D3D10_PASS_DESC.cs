// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10effect.h(1170,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_PASS_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public uint Annotations;
        public IntPtr pIAInputSignature;
        public ulong IAInputSignatureSize;
        public uint StencilRef;
        public uint SampleMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] BlendFactor;
    }
}
