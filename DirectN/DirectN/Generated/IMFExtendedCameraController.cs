// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(21136,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b91ebfee-ca03-4af4-8a82-a31752f4a0fc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFExtendedCameraController
    {
        [PreserveSig]
        HRESULT GetExtendedCameraControl(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint ulPropertyId, /* [annotation][out] _COM_Outptr_ */ out IMFExtendedCameraControl ppControl);
    }
}
