// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(208,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("26dc4561-a1ee-4ae7-96da-118a36c0ec95"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice9Video
    {
        [PreserveSig]
        HRESULT GetContentProtectionCaps([MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, [MarshalAs(UnmanagedType.LPStruct)] Guid pDecodeProfile, ref _D3DCONTENTPROTECTIONCAPS pCaps);
        
        [PreserveSig]
        HRESULT CreateAuthenticatedChannel(_D3DAUTHENTICATEDCHANNELTYPE ChannelType, IDirect3DAuthenticatedChannel9 ppAuthenticatedChannel, [MarshalAs(UnmanagedType.IUnknown)] object pChannelHandle);
        
        [PreserveSig]
        HRESULT CreateCryptoSession([MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, [MarshalAs(UnmanagedType.LPStruct)] Guid pDecodeProfile, IDirect3DCryptoSession9 ppCryptoSession, [MarshalAs(UnmanagedType.IUnknown)] object pCryptoHandle);
    }
}
