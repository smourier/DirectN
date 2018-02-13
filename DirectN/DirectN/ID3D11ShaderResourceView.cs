using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("b0e06fe0-8192-4e1a-b1ca-36d7414710b2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11ShaderResourceView
    {
        // ID3D11View
        [PreserveSig]
        void GetDesc(out D3D11_SHADER_RESOURCE_VIEW_DESC pDesc);
    }
}
