// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3196,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DEVICEPAGEFAULT_STATE
    {
        public ulong FaultedPrimitiveAPISequenceNumber;
        public _DXGK_RENDER_PIPELINE_STAGE FaultedPipelineStage;
        public uint FaultedBindTableEntry;
        public _DXGK_PAGE_FAULT_FLAGS PageFaultFlags;
        public _DXGK_FAULT_ERROR_CODE FaultErrorCode;
        public ulong FaultedVirtualAddress;
    }
}
