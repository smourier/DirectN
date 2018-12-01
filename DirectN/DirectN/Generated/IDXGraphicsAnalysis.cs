// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxprogrammablecapture.h(35,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGraphicsAnalysis
    {
        [PreserveSig]
        void BeginCapture();
        
        [PreserveSig]
        void EndCapture();
    }
}
