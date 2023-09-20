// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("de5fa827-9bf9-4f26-89ff-d7f56fde3860"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12StateObjectProperties
    {
        [PreserveSig]
        void GetShaderIdentifier(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pExportName);
        
        [PreserveSig]
        ulong GetShaderStackSize(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pExportName);
        
        [PreserveSig]
        ulong GetPipelineStackSize();
        
        [PreserveSig]
        void SetPipelineStackSize(ulong PipelineStackSizeInBytes);
    }
}
