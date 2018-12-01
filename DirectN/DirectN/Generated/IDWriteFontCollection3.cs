// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(3508,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a4d055a6-f9e3-4e25-93b7-9e309f3af8e9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontCollection3 : IDWriteFontCollection2
    {
        // IDWriteFontCollection1
        [PreserveSig]
        new HRESULT GetFontSet(/* _COM_Outptr_ */ out IDWriteFontSet fontSet);
        
        [PreserveSig]
        new HRESULT GetFontFamily(uint index, /* _COM_Outptr_ */ out IDWriteFontFamily1 fontFamily);
        
        // IDWriteFontCollection2
        [PreserveSig]
        new HRESULT GetFontFamily(uint index, /* _COM_Outptr_ */ out IDWriteFontFamily2 fontFamily);
        
        [PreserveSig]
        new HRESULT GetMatchingFonts(/* _In_z_ */ ref char familyName, /* _In_reads_(fontAxisValueCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, /* _COM_Outptr_ */ out IDWriteFontList2 fontList);
        
        [PreserveSig]
        new DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel();
        
        [PreserveSig]
        new HRESULT GetFontSet(/* _COM_Outptr_ */ out IDWriteFontSet1 fontSet);
        
        // IDWriteFontCollection3
        [PreserveSig]
        IntPtr GetExpirationEvent();
    }
}
