// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(9255,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3787614f-65f7-4003-b673-ead8293a0e60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineClassFactory3
    {
        [PreserveSig]
        HRESULT CreateMediaKeySystemAccess(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string keySystem, /* [annotation] _In_count_(uSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IPropertyStore[] ppSupportedConfigurationsArray, /* [annotation] _In_ */ int uSize, /* [annotation] _COM_Outptr_ */ out IMFMediaKeySystemAccess ppKeyAccess);
    }
}
