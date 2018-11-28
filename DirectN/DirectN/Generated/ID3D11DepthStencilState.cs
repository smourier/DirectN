using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("03823efb-8d8f-4e1c-9aa2-f64bb2cbfdf1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11DepthStencilState
    {
        // ID3D11DeviceChild
        [PreserveSig]
        void GetDesc(out D3D11_DEPTH_STENCIL_DESC pDesc);
    }
}
