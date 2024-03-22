// generated from <Windows SDK Path>\um\dxprogrammablecapture.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGraphicsAnalysis
    {
        [PreserveSig]
        void BeginCapture();

        [PreserveSig]
        void EndCapture();
    }
}
