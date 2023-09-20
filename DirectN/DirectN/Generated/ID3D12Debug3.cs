// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5cf4e58f-f671-4ff1-a542-3686e3d153d1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Debug3 : ID3D12Debug
    {
        // ID3D12Debug
        [PreserveSig]
        new void EnableDebugLayer();
        
        // ID3D12Debug3
        [PreserveSig]
        void SetEnableGPUBasedValidation(bool Enable);
        
        [PreserveSig]
        void SetEnableSynchronizedCommandQueueValidation(bool Enable);
        
        [PreserveSig]
        void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags);
    }
}
