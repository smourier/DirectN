using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIAdapter
    {
        // IDXGIObject
        [PreserveSig]
        int SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, int DataSize, IntPtr pData);

        [PreserveSig]
        int SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid Name, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        int GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, out int pDataSize, IntPtr pData);

        [PreserveSig]
        int GetParent([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);

        // IDXGIAdapter
        [PreserveSig]
        int EnumOutputs(int nOutput, out IDXGIOutput ppOutput);
        
        [PreserveSig]
        int GetDesc(out DXGI_ADAPTER_DESC pDesc);
        
        [PreserveSig]
        int CheckInterfaceSupport([MarshalAs(UnmanagedType.LPStruct)] Guid InterfaceName, out long pUMDVersion);
    }
}
