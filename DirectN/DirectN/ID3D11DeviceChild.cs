using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1841e5c8-16b0-489b-bcc8-44cfb0d5deae"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11DeviceChild
    {
        [PreserveSig]
        void GetDevice(out ID3D11Device ppDevice);

        [PreserveSig]
        int GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid guid, out int pDataSize, IntPtr pData);

        [PreserveSig]
        int SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid guid, int DataSize, IntPtr pData);

        [PreserveSig]
        int SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid guid, [MarshalAs(UnmanagedType.IUnknown)] object pData);
    }
}
