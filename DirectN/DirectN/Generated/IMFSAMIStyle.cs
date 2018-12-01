// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(15552,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a7e025dd-5303-4a62-89d6-e747e1efac73"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSAMIStyle
    {
        [PreserveSig]
        HRESULT GetStyleCount(/* [annotation][out] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetStyles(/* [annotation][out] _Out_ */ out PropVariant pPropVarStyleArray);
        
        [PreserveSig]
        HRESULT SetSelectedStyle(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszStyle);
        
        [PreserveSig]
        HRESULT GetSelectedStyle(/* [annotation][out] _Outptr_ */ out IntPtr ppwszStyle);
    }
}
