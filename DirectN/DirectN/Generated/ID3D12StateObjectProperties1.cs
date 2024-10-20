// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("460caac7-1d24-446a-a184-ca67db494138"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12StateObjectProperties1 : ID3D12StateObjectProperties
    {
        // ID3D12StateObjectProperties
        [PreserveSig]
        new void GetShaderIdentifier(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pExportName);
        
        [PreserveSig]
        new ulong GetShaderStackSize(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pExportName);
        
        [PreserveSig]
        new ulong GetPipelineStackSize();
        
        [PreserveSig]
        new void SetPipelineStackSize(ulong PipelineStackSizeInBytes);
        
        // ID3D12StateObjectProperties1
        [PreserveSig]
        D3D12_PROGRAM_IDENTIFIER GetProgramIdentifier([MarshalAs(UnmanagedType.LPWStr)] string pProgramName);
    }
}
