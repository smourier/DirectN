// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dcsx.h(156,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a915128c-d954-4c79-bfe1-64db923194d6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3DX11SegmentedScan
    {
        [PreserveSig]
        HRESULT SetScanDirection(D3DX11_SCAN_DIRECTION Direction);
        
        [PreserveSig]
        HRESULT SegScan(D3DX11_SCAN_DATA_TYPE ElementType, D3DX11_SCAN_OPCODE OpCode, uint ElementScanSize, /* _In_opt_ */ ID3D11UnorderedAccessView pSrc, /* _In_ */ ID3D11UnorderedAccessView pSrcElementFlags, /* _In_ */ ID3D11UnorderedAccessView pDst);
    }
}
