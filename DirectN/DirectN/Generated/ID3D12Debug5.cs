// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("548d6b12-09fa-40e0-9069-5dcd589a52c9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Debug5 : ID3D12Debug4
    {
        // ID3D12Debug
        [PreserveSig]
        new void EnableDebugLayer();
        
        // ID3D12Debug3
        [PreserveSig]
        new void SetEnableGPUBasedValidation(bool Enable);
        
        [PreserveSig]
        new void SetEnableSynchronizedCommandQueueValidation(bool Enable);
        
        [PreserveSig]
        new void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags);
        
        // ID3D12Debug4
        [PreserveSig]
        new void DisableDebugLayer();
        
        // ID3D12Debug5
        [PreserveSig]
        void SetEnableAutoName(bool Enable);
    }
}
