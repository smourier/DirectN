// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11shader.h(493,1)
using System;
using System.Runtime.InteropServices;
using ID3DBlob = DirectN.ID3D10Blob;

namespace DirectN
{
    [Guid("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Linker
    {
        [PreserveSig]
        HRESULT Link(/* THIS_ _In_ */ ID3D11ModuleInstance pEntry, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntryName, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTargetName, /* _In_ */ uint uFlags, /* _COM_Outptr_ */ out ID3DBlob ppShaderBlob, /* optional(ID3DBlob) */ out IntPtr ppErrorBuffer);
        
        [PreserveSig]
        HRESULT UseLibrary(/* THIS_ _In_ */ ID3D11ModuleInstance pLibraryMI);
        
        [PreserveSig]
        HRESULT AddClipPlaneFromCBuffer(/* THIS_ _In_ */ uint uCBufferSlot, /* _In_ */ uint uCBufferEntry);
    }
}
