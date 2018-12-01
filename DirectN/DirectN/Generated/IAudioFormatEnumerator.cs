// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\spatialaudioclient.h(166,5)
using System;
using System.Runtime.InteropServices;
using WAVEFORMATEX = DirectN.tWAVEFORMATEX;

namespace DirectN
{
    [Guid("dcdaa858-895a-4a22-a5eb-67bda506096d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioFormatEnumerator
    {
        [PreserveSig]
        HRESULT GetCount(/* [annotation][out] _Out_ */ out uint count);
        
        [PreserveSig]
        HRESULT GetFormat(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Outptr_ */ out IntPtr format);
    }
}
