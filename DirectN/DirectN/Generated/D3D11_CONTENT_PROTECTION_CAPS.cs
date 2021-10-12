﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(10428,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D11_CONTENT_PROTECTION_CAPS
    {
        D3D11_CONTENT_PROTECTION_CAPS_SOFTWARE = 0x00000001,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE = 0x00000002,
        D3D11_CONTENT_PROTECTION_CAPS_PROTECTION_ALWAYS_ON = 0x00000004,
        D3D11_CONTENT_PROTECTION_CAPS_PARTIAL_DECRYPTION = 0x00000008,
        D3D11_CONTENT_PROTECTION_CAPS_CONTENT_KEY = 0x00000010,
        D3D11_CONTENT_PROTECTION_CAPS_FRESHEN_SESSION_KEY = 0x00000020,
        D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK = 0x00000040,
        D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK_KEY = 0x00000080,
        D3D11_CONTENT_PROTECTION_CAPS_SEQUENTIAL_CTR_IV = 0x00000100,
        D3D11_CONTENT_PROTECTION_CAPS_ENCRYPT_SLICEDATA_ONLY = 0x00000200,
        D3D11_CONTENT_PROTECTION_CAPS_DECRYPTION_BLT = 0x00000400,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECT_UNCOMPRESSED = 0x00000800,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECTED_MEMORY_PAGEABLE = 0x00001000,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_TEARDOWN = 0x00002000,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION = 0x00004000,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION_MULTI_THREADED = 0x00008000,
    }
}
