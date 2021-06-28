// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfsharingengine.h(155,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2ba61f92-8305-413b-9733-faf15f259384"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSharingEngineClassFactory
    {
        [PreserveSig]
        HRESULT CreateInstance(/* [annotation][in] _In_ */ uint dwFlags, /* [annotation][in] _In_opt_ */ IMFAttributes pAttr, /* [annotation][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppEngine);
    }
}
