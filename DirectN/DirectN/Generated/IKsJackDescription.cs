// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\devicetopology.h(2326,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4509f757-2d46-4637-8e62-ce7db944f57b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsJackDescription
    {
        [PreserveSig]
        HRESULT GetJackCount(/* [annotation][out] _Out_ */ out uint pcJacks);
        
        [PreserveSig]
        HRESULT GetJackDescription(/* [in] */ uint nJack, /* [annotation][out] _Out_ */ out KSJACK_DESCRIPTION pDescription);
    }
}
