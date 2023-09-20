// generated from <Windows SDK Path>\um\d3d10effect.h
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
