// generated from <Windows SDK Path>\um\dshowasf.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("b25b8372-d2d2-44b2-8653-1b8dae332489"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMWMBufferPassCallback
    {
        [PreserveSig]
        HRESULT Notify(/* [in] __RPC__in_opt */ INSSBuffer3 pNSSBuffer3, /* [in] __RPC__in_opt */ IPin pPin, /* [in] __RPC__in */ ref REFERENCE_TIME prtStart, /* [in] __RPC__in */ ref REFERENCE_TIME prtEnd);
    }
}
