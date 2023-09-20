// generated from <Windows SDK Path>\shared\d3d9.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("efc5557e-6265-4613-8a94-43857889eb36"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVertexShader9
    {
        [PreserveSig]
        HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT GetFunction(IntPtr unnamed__0, ref uint pSizeOfData);
    }
}
