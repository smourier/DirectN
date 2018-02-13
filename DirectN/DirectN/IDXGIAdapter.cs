using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIAdapter
    {
        // IDXGIObject

        [PreserveSig]
        int EnumOutputs(int nOutput, out IDXGIOutput ppOutput);
        
        [PreserveSig]
        int GetDesc(out DXGI_ADAPTER_DESC pDesc);
        
        [PreserveSig]
        int CheckInterfaceSupport([MarshalAs(UnmanagedType.LPStruct)] Guid InterfaceName, out long pUMDVersion);
    }
}
