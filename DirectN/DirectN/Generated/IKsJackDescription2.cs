// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\devicetopology.h(2533,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("478f3a9b-e0c9-4827-9228-6f5505ffe76a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsJackDescription2
    {
        [PreserveSig]
        HRESULT GetJackCount(/* [annotation][out] _Out_ */ out uint pcJacks);
        
        [PreserveSig]
        HRESULT GetJackDescription2(/* [in] */ uint nJack, /* [annotation][out] _Out_ */ out _tagKSJACK_DESCRIPTION2 pDescription2);
    }
}
