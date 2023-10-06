// generated from <Windows SDK Path>\um\d2d1_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1c4820bb-5771-4518-a581-2fe4dd0ec657"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ColorContext : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1ColorContext
        [PreserveSig]
        D2D1_COLOR_SPACE GetColorSpace();
        
        [PreserveSig]
        uint GetProfileSize();
        
        [PreserveSig]
        HRESULT GetProfile(/* _Out_writes_(profileSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] profile, int profileSize);
    }
}
