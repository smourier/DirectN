// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_5.h(459,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3d585d5a-bd4a-489e-b1f4-3dbcb6452ffb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGISwapChain4
    {
        [PreserveSig]
        HRESULT SetHDRMetaData(/* [annotation][in] _In_ */ DXGI_HDR_METADATA_TYPE Type, /* [annotation][in] _In_ */ uint Size, /* [annotation][size_is][in] _In_reads_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] object pMetaData);
    }
}
