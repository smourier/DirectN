// generated from <Windows SDK Path>\shared\d3d9.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6d3bdbdc-5b02-4415-b852-ce5e8bccb289"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DPixelShader9
    {
        [PreserveSig]
        HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT GetFunction(IntPtr unnamed__0, ref uint pSizeOfData);
    }
}
