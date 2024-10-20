// generated from <Windows SDK Path>\um\dxprogrammablecapture.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9f251514-9d4d-4902-9d60-18988ab7d4b5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGraphicsAnalysis
    {
        [PreserveSig]
        void BeginCapture();
        
        [PreserveSig]
        void EndCapture();
    }
}
