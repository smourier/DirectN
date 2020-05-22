// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(8116,5)
using System;
using System.Runtime.InteropServices;
using MFTIME = System.Int64;

namespace DirectN
{
    [Guid("ab9d8661-f7e8-4ef4-9861-89f334f94e74"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimecodeTranslate
    {
        [PreserveSig]
        HRESULT BeginConvertTimecodeToHNS(/* [in] */ [In, Out] PropVariant pPropVarTimecode, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndConvertTimecodeToHNS(/* [in] */ IMFAsyncResult pResult, /* [out] */ out MFTIME phnsTime);
        
        [PreserveSig]
        HRESULT BeginConvertHNSToTimecode(/* [in] */ long hnsTime, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndConvertHNSToTimecode(/* [in] */ IMFAsyncResult pResult, /* [out] */ [In, Out] PropVariant pPropVarTimecode);
    }
}
