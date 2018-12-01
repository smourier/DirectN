// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor_1.h(59,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The internal context handed to effect authors to create transforms from effects and any other operation tied to context which is not useful to the application facing API.
    /// </summary>
    [Guid("577ad2a0-9fc7-4dda-8b18-dab810140052"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1EffectContext2 : ID2D1EffectContext1
    {
        // ID2D1EffectContext1
        [PreserveSig]
        new HRESULT CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, /* _In_reads_(3) */ [MarshalAs(UnmanagedType.LPArray)] uint[] extents, /* _In_reads_(dataCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, uint dataCount, /* _In_reads_(2) */ [MarshalAs(UnmanagedType.LPArray)] uint[] strides, /* _COM_Outptr_ */ out ID2D1LookupTable3D lookupTable);
        
        // ID2D1EffectContext2
        [PreserveSig]
        HRESULT CreateColorContextFromDxgiColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace, /* _COM_Outptr_ */ out ID2D1ColorContext1 colorContext);
        
        [PreserveSig]
        HRESULT CreateColorContextFromSimpleColorProfile(/* _In_ */ ref D2D1_SIMPLE_COLOR_PROFILE simpleProfile, /* _COM_Outptr_ */ out ID2D1ColorContext1 colorContext);
    }
}
