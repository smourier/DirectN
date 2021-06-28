// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(4240,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("654a6bb3-e1a3-424a-9908-53a43a0dfda0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineSrcElementsEx : IMFMediaEngineSrcElements
    {
        // IMFMediaEngineSrcElements
        [PreserveSig]
        new uint GetLength();
        
        [PreserveSig]
        new HRESULT GetURL(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Out_ */ out IntPtr pURL);
        
        [PreserveSig]
        new HRESULT GetType(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Out_ */ out IntPtr pType);
        
        [PreserveSig]
        new HRESULT GetMedia(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Out_ */ out IntPtr pMedia);
        
        [PreserveSig]
        new HRESULT AddElement(/* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string pURL, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string pType, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string pMedia);
        
        [PreserveSig]
        new HRESULT RemoveAllElements();
        
        // IMFMediaEngineSrcElementsEx
        [PreserveSig]
        HRESULT AddElementEx(/* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string pURL, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string pType, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string pMedia, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string keySystem);
        
        [PreserveSig]
        HRESULT GetKeySystem(/* [annotation] _In_ */ uint index, /* [annotation] _Outptr_result_maybenull_ */ out IntPtr pType);
    }
}
