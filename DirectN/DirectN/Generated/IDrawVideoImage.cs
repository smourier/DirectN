// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(15408,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("48efb120-ab49-11d2-aed2-00a0c995e8d5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDrawVideoImage
    {
        [PreserveSig]
        HRESULT DrawVideoImageBegin();
        
        [PreserveSig]
        HRESULT DrawVideoImageEnd();
        
        [PreserveSig]
        HRESULT DrawVideoImageDraw(/* [in] */ IntPtr hdc, /* [annotation][in] _In_ */ ref tagRECT lprcSrc, /* [annotation][in] _In_ */ ref tagRECT lprcDst);
    }
}
