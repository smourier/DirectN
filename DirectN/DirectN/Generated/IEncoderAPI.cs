// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("70423839-6acc-4b23-b079-21dbf08156a5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEncoderAPI
    {
        [PreserveSig]
        HRESULT IsSupported(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api);
        
        [PreserveSig]
        HRESULT IsAvailable(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api);
        
        [PreserveSig]
        HRESULT GetParameterRange(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][out] _Out_ */ out IntPtr ValueMin, /* [annotation][out] _Out_ */ out IntPtr ValueMax, /* [annotation][out] _Out_ */ out IntPtr SteppingDelta);
        
        [PreserveSig]
        HRESULT GetParameterValues(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][size_is][size_is][out] _Outptr_result_buffer_all_(*ValuesCount) */ out IntPtr Values, /* [annotation][out] _Out_ */ out uint ValuesCount);
        
        [PreserveSig]
        HRESULT GetDefaultValue(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][out] _Out_ */ out IntPtr Value);
        
        [PreserveSig]
        HRESULT GetValue(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][out] _Out_ */ out IntPtr Value);
        
        [PreserveSig]
        HRESULT SetValue(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][in] _In_ */ IntPtr Value);
    }
}
