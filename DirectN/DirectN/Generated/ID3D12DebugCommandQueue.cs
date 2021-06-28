// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12sdklayers.h(945,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("09e0bf36-54ac-484f-8847-4baeeab6053a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugCommandQueue
    {
        [PreserveSig]
        bool AssertResourceState(/* _In_ */ ID3D12Resource pResource, uint Subresource, uint State);
    }
}
