// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;

namespace DirectN
{
    [Flags]
    public enum _DXGKMDT_OPM_STATUS
    {
        DXGKMDT_OPM_STATUS_NORMAL = 0x00000000,
        DXGKMDT_OPM_STATUS_LINK_LOST = 0x00000001,
        DXGKMDT_OPM_STATUS_RENEGOTIATION_REQUIRED = 0x00000002,
        DXGKMDT_OPM_STATUS_TAMPERING_DETECTED = 0x00000004,
        DXGKMDT_OPM_STATUS_REVOKED_HDCP_DEVICE_ATTACHED = 0x00000008,
    }
}
