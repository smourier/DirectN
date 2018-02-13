using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("75b68faa-347d-4159-8f45-a0640f01cd9a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11BlendState
    {
        // ID3D11DeviceChild

        [PreserveSig]
        void GetDesc(out D3D11_BLEND_DESC pDesc);
    }
}
