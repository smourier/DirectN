﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(12031,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("de5fa827-9bf9-4f26-89ff-d7f56fde3860"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
