// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(17165,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("02997c3b-8e1b-460e-9270-545e0de9563e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVideoEncoder : IEncoderAPI
    {
        // IEncoderAPI
        [PreserveSig]
        new HRESULT IsSupported(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api);
        
        [PreserveSig]
        new HRESULT IsAvailable(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api);
        
        [PreserveSig]
        new HRESULT GetParameterRange(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][out] _Out_ */ out IntPtr ValueMin, /* [annotation][out] _Out_ */ out IntPtr ValueMax, /* [annotation][out] _Out_ */ out IntPtr SteppingDelta);
        
        [PreserveSig]
        new HRESULT GetParameterValues(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][size_is][size_is][out] _Outptr_result_buffer_all_(*ValuesCount) */ out IntPtr Values, /* [annotation][out] _Out_ */ out uint ValuesCount);
        
        [PreserveSig]
        new HRESULT GetDefaultValue(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][out] _Out_ */ out IntPtr Value);
        
        [PreserveSig]
        new HRESULT GetValue(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][out] _Out_ */ out IntPtr Value);
        
        [PreserveSig]
        new HRESULT SetValue(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][in] _In_ */ IntPtr Value);
        
        // IVideoEncoder
    }
}
