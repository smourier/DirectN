// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(3238,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7bf80980-bf32-101a-8bbb-00aa00300cab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPicture
    {
        [PreserveSig]
        HRESULT get_Handle(/* [out] __RPC__out */ out uint pHandle);
        
        [PreserveSig]
        HRESULT get_hPal(/* [out] __RPC__out */ out uint phPal);
        
        [PreserveSig]
        HRESULT get_Type(/* [out] __RPC__out */ out short pType);
        
        [PreserveSig]
        HRESULT get_Width(/* [out] __RPC__out */ out long pWidth);
        
        [PreserveSig]
        HRESULT get_Height(/* [out] __RPC__out */ out long pHeight);
        
        [PreserveSig]
        HRESULT Render(/* [in] __RPC__in */ IntPtr hDC, /* [in] */ int x, /* [in] */ int y, /* [in] */ int cx, /* [in] */ int cy, /* [in] */ int xSrc, /* [in] */ int ySrc, /* [in] */ int cxSrc, /* [in] */ int cySrc, /* [in] __RPC__in */ IntPtr pRcWBounds);
        
        [PreserveSig]
        HRESULT set_hPal(/* [in] */ uint hPal);
        
        [PreserveSig]
        HRESULT get_CurDC(/* [out] __RPC__deref_out_opt */ out IntPtr phDC);
        
        [PreserveSig]
        HRESULT SelectPicture(/* [in] __RPC__in */ IntPtr hDCIn, /* [out] __RPC__deref_out_opt */ out IntPtr phDCOut, /* [out] __RPC__out */ out uint phBmpOut);
        
        [PreserveSig]
        HRESULT get_KeepOriginalFormat(/* [out] __RPC__out */ out bool pKeep);
        
        [PreserveSig]
        HRESULT put_KeepOriginalFormat(/* [in] */ bool keep);
        
        [PreserveSig]
        HRESULT PictureChanged();
        
        [PreserveSig]
        HRESULT SaveAsFile(/* [in] __RPC__in_opt */ IntPtr pStream, /* [in] */ bool fSaveMemCopy, /* [out] __RPC__out */ out long pCbSize);
        
        [PreserveSig]
        HRESULT get_Attributes(/* [out] __RPC__out */ out uint pDwAttr);
    }
}
