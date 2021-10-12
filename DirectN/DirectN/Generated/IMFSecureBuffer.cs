// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfobjects.h(6969,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c1209904-e584-4752-a2d6-7f21693f8b21"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSecureBuffer
    {
        [PreserveSig]
        HRESULT GetIdentifier(/* [annotation][out] _Out_ */ out Guid pGuidIdentifier);
    }
}
