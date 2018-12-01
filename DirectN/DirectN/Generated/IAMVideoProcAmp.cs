// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(10413,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c6e13360-30ac-11d0-a18c-00a0c9118956"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVideoProcAmp
    {
        [PreserveSig]
        HRESULT GetRange(/* [in] */ int Property, /* [annotation][out] _Out_ */ out long pMin, /* [annotation][out] _Out_ */ out long pMax, /* [annotation][out] _Out_ */ out long pSteppingDelta, /* [annotation][out] _Out_ */ out long pDefault, /* [annotation][out] _Out_ */ out long pCapsFlags);
        
        [PreserveSig]
        HRESULT Set(/* [in] */ int Property, /* [in] */ int lValue, /* [in] */ int Flags);
        
        [PreserveSig]
        HRESULT Get(/* [in] */ int Property, /* [annotation][out] _Out_ */ out long lValue, /* [annotation][out] _Out_ */ out long Flags);
    }
}
