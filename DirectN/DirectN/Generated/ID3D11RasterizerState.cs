using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("9bb4ab81-ab1a-4d8f-b506-fc04200b6ee7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11RasterizerState
    {
        // ID3D11DeviceChild
        [PreserveSig]
        void GetDesc(out D3D11_RASTERIZER_DESC pDesc);
    }
}
