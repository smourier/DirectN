// generated from <Windows SDK Path>\um\mfidl.h
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
