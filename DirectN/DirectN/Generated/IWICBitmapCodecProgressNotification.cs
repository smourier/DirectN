// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(4635,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("64c1024e-c3cf-4462-8078-88c2b11c46d9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapCodecProgressNotification
    {
        [PreserveSig]
        HRESULT RegisterProgressNotification(/* [annotation][unique][in] _In_opt_ */ IntPtr pfnProgressNotification, /* [annotation][unique][in] _In_opt_ */ IntPtr pvData, /* [in] */ uint dwProgressFlags);
    }
}
