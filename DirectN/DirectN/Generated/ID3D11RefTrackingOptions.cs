// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11sdklayers.h(560,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("193dacdf-0db2-4c05-a55c-ef06cac56fd9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RefTrackingOptions
    {
        [PreserveSig]
        HRESULT SetTrackingOptions(uint uOptions);
    }
}
