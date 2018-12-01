// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxcapi.h(310,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ae2cd79f-cc22-453f-9b6b-b124e7a5204c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcOptimizerPass
    {
        [PreserveSig]
        HRESULT GetOptionName(/* _COM_Outptr_ */ out IntPtr ppResult);
        
        [PreserveSig]
        HRESULT GetDescription(/* _COM_Outptr_ */ out IntPtr ppResult);
        
        [PreserveSig]
        HRESULT GetOptionArgCount(/* _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetOptionArgName(uint argIndex, /* _COM_Outptr_ */ out IntPtr ppResult);
        
        [PreserveSig]
        HRESULT GetOptionArgDescription(uint argIndex, /* _COM_Outptr_ */ out IntPtr ppResult);
    }
}
