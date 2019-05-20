// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10effect.h(883,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_EFFECT_SHADER_DESC
    {
        public IntPtr pInputSignature;
        public bool IsInline;
        public IntPtr pBytecode;
        public uint BytecodeLength;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string SODecl;
        public uint NumInputSignatureEntries;
        public uint NumOutputSignatureEntries;
    }
}
