// generated from <Windows SDK Path>\um\d3d11shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Linker
    {
        [PreserveSig]
        HRESULT Link(/* THIS_ _In_ */ ID3D11ModuleInstance pEntry, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pEntryName, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pTargetName, /* _In_ */ uint uFlags, /* _COM_Outptr_ */ out ID3D10Blob ppShaderBlob, /* _Always_(_Outptr_opt_result_maybenull_) */ out ID3D10Blob ppErrorBuffer);
        
        [PreserveSig]
        HRESULT UseLibrary(/* THIS_ _In_ */ ID3D11ModuleInstance pLibraryMI);
        
        [PreserveSig]
        HRESULT AddClipPlaneFromCBuffer(/* THIS_ _In_ */ uint uCBufferSlot, /* _In_ */ uint uCBufferEntry);
    }
}
