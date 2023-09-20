// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bef6e002-a874-101a-8bba-00aa00300cab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFont
    {
        [PreserveSig]
        HRESULT get_Name(/* [out] __RPC__deref_out_opt */ out IntPtr pName);
        
        [PreserveSig]
        HRESULT put_Name(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.BStr)] string name);
        
        [PreserveSig]
        HRESULT get_Size(/* [out] __RPC__out */ out int pSize);
        
        [PreserveSig]
        HRESULT put_Size(/* [in] */ int size);
        
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
        HRESULT get_hFont(/* [out] __RPC__deref_out_opt */ out IntPtr phFont);
        
        [PreserveSig]
        HRESULT Clone(/* [out] __RPC__deref_out_opt */ out IFont ppFont);
        
        [PreserveSig]
        HRESULT IsEqual(/* [in] __RPC__in_opt */ IFont pFontOther);
        
        [PreserveSig]
        HRESULT SetRatio(/* [in] */ int cyLogical, /* [in] */ int cyHimetric);
        
        [PreserveSig]
        HRESULT QueryTextMetrics(/* [out] __RPC__out */ out tagTEXTMETRICW pTM);
        
        [PreserveSig]
        HRESULT AddRefHfont(/* [in] __RPC__in */ IntPtr hFont);
        
        [PreserveSig]
        HRESULT ReleaseHfont(/* [in] __RPC__in */ IntPtr hFont);
        
        [PreserveSig]
        HRESULT SetHdc(/* [in] __RPC__in */ IntPtr hDC);
    }
}
