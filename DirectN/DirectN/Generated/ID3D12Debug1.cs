// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12sdklayers.h(262,5)
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
