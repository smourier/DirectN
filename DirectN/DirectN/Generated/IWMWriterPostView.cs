// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(9256,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("81e20ce4-75ef-491a-8004-fc53c45bdc3e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterPostView
    {
        [PreserveSig]
        HRESULT SetPostViewCallback(IWMWriterPostViewCallback pCallback, [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT SetReceivePostViewSamples(/* [in] */ ushort wStreamNum, /* [in] */ bool fReceivePostViewSamples);
        
        [PreserveSig]
        HRESULT GetReceivePostViewSamples(/* [in] */ ushort wStreamNum, /* [out] */ out bool pfReceivePostViewSamples);
        
        [PreserveSig]
        HRESULT GetPostViewProps(/* [in] */ ushort wStreamNumber, /* [out] */ out IWMMediaProps ppOutput);
        
        [PreserveSig]
        HRESULT SetPostViewProps(/* [in] */ ushort wStreamNumber, /* [in] */ IWMMediaProps pOutput);
        
        [PreserveSig]
        HRESULT GetPostViewFormatCount(/* [in] */ ushort wStreamNumber, /* [out] */ out uint pcFormats);
        
        [PreserveSig]
        HRESULT GetPostViewFormat(/* [in] */ ushort wStreamNumber, /* [in] */ uint dwFormatNumber, /* [out] */ out IWMMediaProps ppProps);
        
        [PreserveSig]
        HRESULT SetAllocateForPostView(/* [in] */ ushort wStreamNumber, /* [in] */ bool fAllocate);
        
        [PreserveSig]
        HRESULT GetAllocateForPostView(/* [in] */ ushort wStreamNumber, /* [out] */ out bool pfAllocate);
    }
}
