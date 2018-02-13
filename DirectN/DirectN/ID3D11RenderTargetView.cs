using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("dfdba067-0b8d-4865-875b-d7b4516cc164"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11RenderTargetView
    {
        // ID3D11View
        [PreserveSig]
        void GetDesc(out D3D11_RENDER_TARGET_VIEW_DESC pDesc);
    }
}
