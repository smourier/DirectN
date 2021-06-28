// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11sdklayers.h(640,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("03916615-c644-418c-9bf4-75db5be63ca0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RefDefaultTrackingOptions
    {
        [PreserveSig]
        HRESULT SetTrackingOptions(uint ResourceTypeFlags, uint Options);
    }
}
