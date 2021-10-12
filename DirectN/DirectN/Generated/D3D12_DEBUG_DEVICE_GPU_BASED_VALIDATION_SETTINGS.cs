// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12sdklayers.h(876,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEBUG_DEVICE_GPU_BASED_VALIDATION_SETTINGS
    {
        public uint MaxMessagesPerCommandList;
        public D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE DefaultShaderPatchMode;
        public D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS PipelineStateCreateFlags;
    }
}
