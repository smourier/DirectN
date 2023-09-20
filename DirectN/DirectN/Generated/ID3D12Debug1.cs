// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("affaa4ca-63fe-4d8e-b8ad-159000af4304"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Debug1
    {
        [PreserveSig]
        void EnableDebugLayer();
        
        [PreserveSig]
        void SetEnableGPUBasedValidation(bool Enable);
        
        [PreserveSig]
        void SetEnableSynchronizedCommandQueueValidation(bool Enable);
    }
}
