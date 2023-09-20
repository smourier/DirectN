// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("93a665c4-a3b2-4e5d-b692-a26ae14e3374"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Debug2
    {
        [PreserveSig]
        void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags);
    }
}
