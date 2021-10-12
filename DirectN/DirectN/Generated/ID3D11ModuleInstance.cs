// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11shader.h(440,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("469e07f7-045a-48d5-aa12-68a478cdf75d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ModuleInstance
    {
        [PreserveSig]
        HRESULT BindConstantBuffer(/* THIS_ _In_ */ uint uSrcSlot, /* _In_ */ uint uDstSlot, /* _In_ */ uint cbDstOffset);
        
        [PreserveSig]
        HRESULT BindConstantBufferByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pName, /* _In_ */ uint uDstSlot, /* _In_ */ uint cbDstOffset);
        
        [PreserveSig]
        HRESULT BindResource(/* THIS_ _In_ */ uint uSrcSlot, /* _In_ */ uint uDstSlot, /* _In_ */ uint uCount);
        
        [PreserveSig]
        HRESULT BindResourceByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pName, /* _In_ */ uint uDstSlot, /* _In_ */ uint uCount);
        
        [PreserveSig]
        HRESULT BindSampler(/* THIS_ _In_ */ uint uSrcSlot, /* _In_ */ uint uDstSlot, /* _In_ */ uint uCount);
        
        [PreserveSig]
        HRESULT BindSamplerByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pName, /* _In_ */ uint uDstSlot, /* _In_ */ uint uCount);
        
        [PreserveSig]
        HRESULT BindUnorderedAccessView(/* THIS_ _In_ */ uint uSrcSlot, /* _In_ */ uint uDstSlot, /* _In_ */ uint uCount);
        
        [PreserveSig]
        HRESULT BindUnorderedAccessViewByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pName, /* _In_ */ uint uDstSlot, /* _In_ */ uint uCount);
        
        [PreserveSig]
        HRESULT BindResourceAsUnorderedAccessView(/* THIS_ _In_ */ uint uSrcSrvSlot, /* _In_ */ uint uDstUavSlot, /* _In_ */ uint uCount);
        
        [PreserveSig]
        HRESULT BindResourceAsUnorderedAccessViewByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pSrvName, /* _In_ */ uint uDstUavSlot, /* _In_ */ uint uCount);
    }
}
