// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2378,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS3
    {
        public bool CopyQueueTimestampQueriesSupported;
        public bool CastingFullyTypedFormatSupported;
        public D3D12_COMMAND_LIST_SUPPORT_FLAGS WriteBufferImmediateSupportFlags;
        public D3D12_VIEW_INSTANCING_TIER ViewInstancingTier;
        public bool BarycentricsSupported;
    }
}
