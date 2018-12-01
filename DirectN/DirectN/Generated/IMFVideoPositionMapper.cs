// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(249,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1f6a9f17-e70b-4e24-8ae4-0b2c3ba7a4ae"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoPositionMapper
    {
        [PreserveSig]
        HRESULT MapOutputCoordinateToInputStream(/* [in] */ float xOut, /* [in] */ float yOut, /* [in] */ uint dwOutputStreamIndex, /* [in] */ uint dwInputStreamIndex, /* [annotation][out] _Out_ */ out float pxIn, /* [annotation][out] _Out_ */ out float pyIn);
    }
}
