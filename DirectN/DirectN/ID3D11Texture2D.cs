using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("6f15aaf2-d208-4e89-9ab4-489535d34f9c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Texture2D
    {
        // ID3D11Resource
        [PreserveSig]
        void GetDesc(out D3D11_TEXTURE2D_DESC pDesc);
    }
}
