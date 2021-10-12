// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wincodec.h(4797,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4776f9cd-9517-45fa-bf24-e89c5ec5c60c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICProgressCallback
    {
        [PreserveSig]
        HRESULT Notify(/* [in] */ uint uFrameNum, /* [in] */ WICProgressOperation operation, /* [in] */ double dblProgress);
    }
}
