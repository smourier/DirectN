// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(7971,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ab9d8661-f7e8-4ef4-9861-89f334f94e74"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimecodeTranslate
    {
        [PreserveSig]
        HRESULT BeginConvertTimecodeToHNS(/* [in] */ PropVariant pPropVarTimecode, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndConvertTimecodeToHNS(/* [in] */ IMFAsyncResult pResult, /* [out] */ out long phnsTime);
        
        [PreserveSig]
        HRESULT BeginConvertHNSToTimecode(/* [in] */ long hnsTime, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndConvertHNSToTimecode(/* [in] */ IMFAsyncResult pResult, /* [out] */ out PropVariant pPropVarTimecode);
    }
}
