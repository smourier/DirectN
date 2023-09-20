// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ae2cd79f-cc22-453f-9b6b-b124e7a5204c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
