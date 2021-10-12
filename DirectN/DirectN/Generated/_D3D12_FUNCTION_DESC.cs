// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12shader.h(199,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_FUNCTION_DESC
    {
        public uint Version;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Creator;
        public uint Flags;
        public uint ConstantBuffers;
        public uint BoundResources;
        public uint InstructionCount;
        public uint TempRegisterCount;
        public uint TempArrayCount;
        public uint DefCount;
        public uint DclCount;
        public uint TextureNormalInstructions;
        public uint TextureLoadInstructions;
        public uint TextureCompInstructions;
        public uint TextureBiasInstructions;
        public uint TextureGradientInstructions;
        public uint FloatInstructionCount;
        public uint IntInstructionCount;
        public uint UintInstructionCount;
        public uint StaticFlowControlCount;
        public uint DynamicFlowControlCount;
        public uint MacroInstructionCount;
        public uint ArrayInstructionCount;
        public uint MovInstructionCount;
        public uint MovcInstructionCount;
        public uint ConversionInstructionCount;
        public uint BitwiseInstructionCount;
        public D3D_FEATURE_LEVEL MinFeatureLevel;
        public ulong RequiredFeatureFlags;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public int FunctionParameterCount;
        public bool HasReturn;
        public bool Has10Level9VertexShader;
        public bool Has10Level9PixelShader;
    }
}
