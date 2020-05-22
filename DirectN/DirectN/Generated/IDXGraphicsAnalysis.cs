// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxprogrammablecapture.h(35,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9f251514-9d4d-4902-9d60-18988ab7d4b5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGraphicsAnalysis
    {
        [PreserveSig]
        void BeginCapture();
        
        [PreserveSig]
        void EndCapture();
    }
}
