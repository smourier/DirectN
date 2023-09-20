// generated from <Windows SDK Path>\shared\d3d9.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d9771460-a695-4f26-bbd3-27b840b541cc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DQuery9
    {
        [PreserveSig]
        HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        _D3DQUERYTYPE GetType();
        
        [PreserveSig]
        uint GetDataSize();
        
        [PreserveSig]
        HRESULT Issue(uint dwIssueFlags);
        
        [PreserveSig]
        HRESULT GetData(IntPtr pData, uint dwSize, uint dwGetDataFlags);
    }
}
