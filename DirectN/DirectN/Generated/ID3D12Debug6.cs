// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("82a816d6-5d01-4157-97d0-4975463fd1ed"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Debug6 : ID3D12Debug5
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
        new void SetEnableAutoName(bool Enable);
        
        // ID3D12Debug6
        [PreserveSig]
        void SetForceLegacyBarrierValidation(bool Enable);
    }
}
