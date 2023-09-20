// generated from <Windows SDK Path>\um\d3d12.h
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
