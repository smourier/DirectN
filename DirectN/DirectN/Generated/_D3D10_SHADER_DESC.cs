// generated from <Windows SDK Path>\um\d3d10shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DESC
    {
        public uint Version;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Creator;
        public uint Flags;
        public uint ConstantBuffers;
        public uint BoundResources;
        public uint InputParameters;
        public uint OutputParameters;
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
        public uint CutInstructionCount;
        public uint EmitInstructionCount;
        public D3D_PRIMITIVE_TOPOLOGY GSOutputTopology;
        public uint GSMaxOutputVertexCount;
    }
}
