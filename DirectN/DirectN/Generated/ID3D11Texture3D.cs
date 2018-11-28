using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("037e866e-f56d-4357-a8af-9dabbe6e250e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Texture3D
    {
        // ID3D11Resource
        [PreserveSig]
        void GetDesc(out D3D11_TEXTURE3D_DESC pDesc);
    }
}
