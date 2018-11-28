using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("9fdac92a-1876-48c3-afad-25b94f84a9b6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11DepthStencilView
    {
        // ID3D11View
        [PreserveSig]
        void GetDesc(out D3D11_DEPTH_STENCIL_VIEW_DESC pDesc);
    }
}
