// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(12361,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("31efac30-515c-11d0-a9aa-00aa0061be93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsPropertySet
    {
        [PreserveSig]
        HRESULT Set(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidPropSet, /* [in] */ uint dwPropID, /* [annotation][size_is][in] _In_reads_bytes_(cbInstanceData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] pInstanceData, /* [in] */ uint cbInstanceData, /* [annotation][size_is][in] _In_reads_bytes_(cbPropData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] IntPtr[] pPropData, /* [in] */ uint cbPropData);
        
        [PreserveSig]
        HRESULT Get(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidPropSet, /* [in] */ uint dwPropID, /* [annotation][size_is][in] _In_reads_bytes_(cbInstanceData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] pInstanceData, /* [in] */ uint cbInstanceData, /* [annotation][size_is][out] _Out_writes_bytes_to_(cbPropData, *pcbReturned) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] IntPtr[] pPropData, /* [in] */ uint cbPropData, /* [annotation][out] _Out_ */ out uint pcbReturned);
        
        [PreserveSig]
        HRESULT QuerySupported(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidPropSet, /* [in] */ uint dwPropID, /* [annotation][out] _Out_ */ out uint pTypeSupport);
    }
}
