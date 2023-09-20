// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ecfb9a55-9298-4f49-887f-0b36206599d2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ITocParser
    {
        [PreserveSig]
        HRESULT Init(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFileName);
        
        [PreserveSig]
        HRESULT GetTocCount(/* [in] */ TOC_POS_TYPE enumTocPosType, /* [out] */ out uint pdwTocCount);
        
        [PreserveSig]
        HRESULT GetTocByIndex(/* [in] */ TOC_POS_TYPE enumTocPosType, /* [in] */ uint dwTocIndex, /* [out] */ out IToc ppToc);
        
        [PreserveSig]
        HRESULT GetTocByType(/* [in] */ TOC_POS_TYPE enumTocPosType, /* [in] */ Guid guidTocType, /* [out] */ out ITocCollection ppTocs);
        
        [PreserveSig]
        HRESULT AddToc(/* [in] */ TOC_POS_TYPE enumTocPosType, /* [in] */ IToc pToc, /* [out] */ out uint pdwTocIndex);
        
        [PreserveSig]
        HRESULT RemoveTocByIndex(/* [in] */ TOC_POS_TYPE enumTocPosType, /* [in] */ uint dwTocIndex);
        
        [PreserveSig]
        HRESULT RemoveTocByType(/* [in] */ TOC_POS_TYPE enumTocPosType, /* [in] */ Guid guidTocType);
        
        [PreserveSig]
        HRESULT Commit();
    }
}
