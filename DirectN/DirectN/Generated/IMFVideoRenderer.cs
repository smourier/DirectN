// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(1230,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dfdfd197-a9ca-43d8-b341-6af3503792cd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoRenderer
    {
        [PreserveSig]
        HRESULT InitializeRenderer(/* [annotation][unique][in] _In_opt_ */ IMFTransform pVideoMixer, /* [annotation][unique][in] _In_opt_ */ IMFVideoPresenter pVideoPresenter);
    }
}
