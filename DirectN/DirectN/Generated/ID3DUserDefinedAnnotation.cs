// generated from <Windows SDK Path>\um\d3d11_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b2daad8b-03d4-4dbf-95eb-32ab4b63d0ab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3DUserDefinedAnnotation
    {
        [PreserveSig]
        int BeginEvent(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        [PreserveSig]
        int EndEvent();
        
        [PreserveSig]
        void SetMarker(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        [PreserveSig]
        bool GetStatus();
    }
}
