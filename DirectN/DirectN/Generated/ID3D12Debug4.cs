// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12sdklayers.h(595,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("014b816e-9ec5-4a2f-a845-ffbe441ce13a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Debug4 : ID3D12Debug3
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
        void DisableDebugLayer();
    }
}
