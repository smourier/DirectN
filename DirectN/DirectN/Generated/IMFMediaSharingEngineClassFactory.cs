// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfsharingengine.h(656,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("524d2bc4-b2b1-4fe5-8fac-fa4e4512b4e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSharingEngineClassFactory
    {
        [PreserveSig]
        HRESULT CreateInstance(/* [annotation][in] _In_ */ uint dwFlags, /* [annotation][in] _In_ */ IMFAttributes pAttr, /* [annotation][out] _Outptr_ */ out IMFMediaSharingEngine ppEngine);
    }
}
