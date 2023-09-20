// generated from <Windows SDK Path>\um\d3d10effect.h
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
        public IntPtr IAInputSignatureSize;
        public uint StencilRef;
        public uint SampleMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] BlendFactor;
    }
}
