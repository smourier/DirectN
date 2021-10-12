// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(4550,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("901db4c7-31ce-41a2-85dc-8fa0bf41b8da"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICodecAPI
    {
        [PreserveSig]
        HRESULT IsSupported(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api);
        
        [PreserveSig]
        HRESULT IsModifiable(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api);
        
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
        
        [PreserveSig]
        HRESULT RegisterForEvent(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [in] */ IntPtr userData);
        
        [PreserveSig]
        HRESULT UnregisterForEvent(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api);
        
        [PreserveSig]
        HRESULT SetAllDefaults();
        
        [PreserveSig]
        HRESULT SetValueWithNotify(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [in] */ IntPtr Value, /* [annotation][size_is][size_is][out] _Outptr_result_buffer_all_(*ChangedParamCount) */ out IntPtr ChangedParam, /* [annotation][out] _Out_ */ out uint ChangedParamCount);
        
        [PreserveSig]
        HRESULT SetAllDefaultsWithNotify(/* [annotation][size_is][size_is][out] _Outptr_result_buffer_all_(*ChangedParamCount) */ out IntPtr ChangedParam, /* [annotation][out] _Out_ */ out uint ChangedParamCount);
        
        [PreserveSig]
        HRESULT GetAllSettings(/* [in] */ IStream __MIDL__ICodecAPI0000);
        
        [PreserveSig]
        HRESULT SetAllSettings(/* [in] */ IStream __MIDL__ICodecAPI0001);
        
        [PreserveSig]
        HRESULT SetAllSettingsWithNotify(IStream __MIDL__ICodecAPI0002, /* [annotation][size_is][size_is][out] _Outptr_result_buffer_all_(*ChangedParamCount) */ out IntPtr ChangedParam, /* [annotation][out] _Out_ */ out uint ChangedParamCount);
    }
}
