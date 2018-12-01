// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11shadertracing.h(148,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TRACE_STATS
    {
        public D3D11_SHADER_TRACE_DESC TraceDesc;
        public byte NumInvocationsInStamp;
        public byte TargetStampIndex;
        public uint NumTraceSteps;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] InputMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] OutputMask;
        public ushort NumTemps;
        public ushort MaxIndexableTempIndex;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)] 
        public ushort[] IndexableTempSize;
        public ushort ImmediateConstantBufferSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] PixelPosition;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] PixelCoverageMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] PixelDiscardedMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] PixelCoverageMaskAfterShader;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] PixelCoverageMaskAfterA2CSampleMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] PixelCoverageMaskAfterA2CSampleMaskDepth;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] PixelCoverageMaskAfterA2CSampleMaskDepthStencil;
        public bool PSOutputsDepth;
        public bool PSOutputsMask;
        public D3D11_TRACE_GS_INPUT_PRIMITIVE GSInputPrimitive;
        public bool GSInputsPrimitiveID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] HSOutputPatchConstantMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] DSInputPatchConstantMask;
    }
}
