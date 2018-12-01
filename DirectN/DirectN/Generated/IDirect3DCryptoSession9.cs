// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(210,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fa0ab799-7a9c-48ca-8c5b-237e71a54434"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DCryptoSession9
    {
        [PreserveSig]
        HRESULT GetCertificateSize(ref uint pCertificateSize);
        
        [PreserveSig]
        HRESULT GetCertificate(uint CertifacteSize, ref byte ppCertificate);
        
        [PreserveSig]
        HRESULT NegotiateKeyExchange(uint DataSize, ref IntPtr pData);
        
        [PreserveSig]
        HRESULT EncryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, ref IntPtr pIV);
        
        [PreserveSig]
        HRESULT DecryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref _D3DENCRYPTED_BLOCK_INFO pEncryptedBlockInfo, ref IntPtr pContentKey, ref IntPtr pIV);
        
        [PreserveSig]
        HRESULT GetSurfacePitch(IDirect3DSurface9 pSrcSurface, ref uint pSurfacePitch);
        
        [PreserveSig]
        HRESULT StartSessionKeyRefresh(ref IntPtr pRandomNumber, uint RandomNumberSize);
        
        [PreserveSig]
        HRESULT FinishSessionKeyRefresh();
        
        [PreserveSig]
        HRESULT GetEncryptionBltKey(ref IntPtr pReadbackKey, uint KeySize);
    }
}
