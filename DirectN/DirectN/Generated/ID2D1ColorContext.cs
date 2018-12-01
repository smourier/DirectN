// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(1414,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a color context that can be used with an ID2D1Bitmap1 object.
    /// </summary>
    [Guid("1c4820bb-5771-4518-a581-2fe4dd0ec657"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ColorContext
    {
        [PreserveSig]
        D2D1_COLOR_SPACE GetColorSpace();
        
        [PreserveSig]
        uint GetProfileSize();
        
        [PreserveSig]
        HRESULT GetProfile(/* _Out_writes_(profileSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] profile, uint profileSize);
    }
}
