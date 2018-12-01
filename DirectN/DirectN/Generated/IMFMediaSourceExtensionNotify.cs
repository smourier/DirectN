// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(3120,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a7901327-05dd-4469-a7b7-0e01979e361d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSourceExtensionNotify
    {
        [PreserveSig]
        void OnSourceOpen();
        
        [PreserveSig]
        void OnSourceEnded();
        
        [PreserveSig]
        void OnSourceClose();
    }
}
