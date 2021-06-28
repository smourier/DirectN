// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(845,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7a5e5354-b114-4c72-b991-3131d75032ea"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineSrcElements
    {
        [PreserveSig]
        uint GetLength();
        
        [PreserveSig]
        HRESULT GetURL(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Out_ */ out IntPtr pURL);
        
        [PreserveSig]
        HRESULT GetType(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Out_ */ out IntPtr pType);
        
        [PreserveSig]
        HRESULT GetMedia(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Out_ */ out IntPtr pMedia);
        
        [PreserveSig]
        HRESULT AddElement(/* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string pURL, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string pType, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string pMedia);
        
        [PreserveSig]
        HRESULT RemoveAllElements();
    }
}
