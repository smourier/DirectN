// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(198,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d9771460-a695-4f26-bbd3-27b840b541cc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DQuery9
    {
        [PreserveSig]
        HRESULT GetDevice(IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        _D3DQUERYTYPE GetType();
        
        [PreserveSig]
        uint GetDataSize();
        
        [PreserveSig]
        HRESULT Issue(uint dwIssueFlags);
        
        [PreserveSig]
        HRESULT GetData([MarshalAs(UnmanagedType.IUnknown)] object pData, uint dwSize, uint dwGetDataFlags);
    }
}
