// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11_1.h(5094,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b2daad8b-03d4-4dbf-95eb-32ab4b63d0ab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
