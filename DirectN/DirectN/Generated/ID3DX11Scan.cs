// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dcsx.h(80,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5089b68f-e71d-4d38-be8e-f363b95a9405"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3DX11Scan
    {
        [PreserveSig]
        HRESULT SetScanDirection(D3DX11_SCAN_DIRECTION Direction);
        
        [PreserveSig]
        HRESULT Scan(D3DX11_SCAN_DATA_TYPE ElementType, D3DX11_SCAN_OPCODE OpCode, uint ElementScanSize, /* _In_ */ ID3D11UnorderedAccessView pSrc, /* _In_ */ ID3D11UnorderedAccessView pDst);
        
        [PreserveSig]
        HRESULT Multiscan(D3DX11_SCAN_DATA_TYPE ElementType, D3DX11_SCAN_OPCODE OpCode, uint ElementScanSize, uint ElementScanPitch, uint ScanCount, /* _In_ */ ID3D11UnorderedAccessView pSrc, /* _In_ */ ID3D11UnorderedAccessView pDst);
    }
}
