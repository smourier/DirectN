// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(4401,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ad4c1b00-4bf7-422f-9175-756693d9130d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFByteStream
    {
        [PreserveSig]
        HRESULT GetCapabilities(/* [out] __RPC__out */ out uint pdwCapabilities);
        
        [PreserveSig]
        HRESULT GetLength(/* [out] __RPC__out */ out ulong pqwLength);
        
        [PreserveSig]
        HRESULT SetLength(/* [in] */ ulong qwLength);
        
        [PreserveSig]
        HRESULT GetCurrentPosition(/* [out] __RPC__out */ out ulong pqwPosition);
        
        [PreserveSig]
        HRESULT SetCurrentPosition(/* [in] */ ulong qwPosition);
        
        [PreserveSig]
        HRESULT IsEndOfStream(/* [out] __RPC__out */ out bool pfEndOfStream);
        
        [PreserveSig]
        HRESULT Read(/* [size_is][out] __RPC__out_ecount_full(cb) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pb, /* [in] */ int cb, /* [out] __RPC__out */ out uint pcbRead);
        
        [PreserveSig]
        HRESULT BeginRead(/* [annotation][out] _Out_writes_bytes_(cb) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pb, /* [in] */ int cb, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndRead(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out uint pcbRead);
        
        [PreserveSig]
        HRESULT Write(/* [size_is][in] __RPC__in_ecount_full(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pb, /* [in] */ int cb, /* [out] __RPC__out */ out uint pcbWritten);
        
        [PreserveSig]
        HRESULT BeginWrite(/* [annotation][in] _In_reads_bytes_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pb, /* [in] */ int cb, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndWrite(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out uint pcbWritten);
        
        [PreserveSig]
        HRESULT Seek(/* [in] */ _MFBYTESTREAM_SEEK_ORIGIN SeekOrigin, /* [in] */ long llSeekOffset, /* [in] */ uint dwSeekFlags, /* [out] __RPC__out */ out ulong pqwCurrentPosition);
        
        [PreserveSig]
        HRESULT Flush();
        
        [PreserveSig]
        HRESULT Close();
    }
}
