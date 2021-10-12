// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcore_interface.h(218,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("526c7776-40e9-459b-b711-f32ad76dfc28"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXCoreAdapterList
    {
        [PreserveSig]
        HRESULT GetAdapter(uint index, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);
        
        [PreserveSig]
        uint GetAdapterCount();
        
        [PreserveSig]
        void IsStale();
        
        [PreserveSig]
        HRESULT GetFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvFactory);
        
        [PreserveSig]
        HRESULT Sort(int numPreferences, /* _In_reads_(numPreferences) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] DXCoreAdapterPreference[] preferences);
        
        [PreserveSig]
        void IsAdapterPreferenceSupported(DXCoreAdapterPreference preference);
    }
}
