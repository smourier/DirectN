// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(2907,5)
using System;
using System.Runtime.InteropServices;
using CY = DirectN.tagCY;
using TEXTMETRICOLE = DirectN.tagTEXTMETRICW;

namespace DirectN
{
    [Guid("bef6e002-a874-101a-8bba-00aa00300cab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFont
    {
        [PreserveSig]
        HRESULT get_Name(/* optional(BSTR) */ out IntPtr pName);
        
        [PreserveSig]
        HRESULT put_Name(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.BStr)] string name);
        
        [PreserveSig]
        HRESULT get_Size(/* [out] __RPC__out */ out CY pSize);
        
        [PreserveSig]
        HRESULT put_Size(/* [in] */ CY size);
        
        [PreserveSig]
        HRESULT get_Bold(/* [out] __RPC__out */ out bool pBold);
        
        [PreserveSig]
        HRESULT put_Bold(/* [in] */ bool bold);
        
        [PreserveSig]
        HRESULT get_Italic(/* [out] __RPC__out */ out bool pItalic);
        
        [PreserveSig]
        HRESULT put_Italic(/* [in] */ bool italic);
        
        [PreserveSig]
        HRESULT get_Underline(/* [out] __RPC__out */ out bool pUnderline);
        
        [PreserveSig]
        HRESULT put_Underline(/* [in] */ bool underline);
        
        [PreserveSig]
        HRESULT get_Strikethrough(/* [out] __RPC__out */ out bool pStrikethrough);
        
        [PreserveSig]
        HRESULT put_Strikethrough(/* [in] */ bool strikethrough);
        
        [PreserveSig]
        HRESULT get_Weight(/* [out] __RPC__out */ out short pWeight);
        
        [PreserveSig]
        HRESULT put_Weight(/* [in] */ short weight);
        
        [PreserveSig]
        HRESULT get_Charset(/* [out] __RPC__out */ out short pCharset);
        
        [PreserveSig]
        HRESULT put_Charset(/* [in] */ short charset);
        
        [PreserveSig]
        HRESULT get_hFont(/* optional(HFONT) */ out IntPtr phFont);
        
        [PreserveSig]
        HRESULT Clone(/* [out] __RPC__deref_out_opt */ out IFont ppFont);
        
        [PreserveSig]
        HRESULT IsEqual(/* [in] __RPC__in_opt */ IFont pFontOther);
        
        [PreserveSig]
        HRESULT SetRatio(/* [in] */ int cyLogical, /* [in] */ int cyHimetric);
        
        [PreserveSig]
        HRESULT QueryTextMetrics(/* [out] __RPC__out */ out TEXTMETRICOLE pTM);
        
        [PreserveSig]
        HRESULT AddRefHfont(/* [in] __RPC__in */ IntPtr hFont);
        
        [PreserveSig]
        HRESULT ReleaseHfont(/* [in] __RPC__in */ IntPtr hFont);
        
        [PreserveSig]
        HRESULT SetHdc(/* [in] __RPC__in */ IntPtr hDC);
    }
}
