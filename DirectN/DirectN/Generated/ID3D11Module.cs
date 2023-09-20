// generated from <Windows SDK Path>\um\d3d11shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cac701ee-80fc-4122-8242-10b39c8cec34"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Module
    {
        [PreserveSig]
        HRESULT CreateInstance(/* THIS_ _In_opt_ */ [MarshalAs(UnmanagedType.LPStr)] string pNamespace, /* _COM_Outptr_ */ out ID3D11ModuleInstance ppModuleInstance);
    }
}
