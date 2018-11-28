using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("f8fb5c27-c6b3-4f75-a4c8-439af2ef564c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Texture1D
    {
        // ID3D11Resource
        [PreserveSig]
        void GetDesc(out D3D11_TEXTURE1D_DESC pDesc);
    }
}
