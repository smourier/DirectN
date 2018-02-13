using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("da6fea51-564c-4487-9810-f0d0f9b4e3a5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11SamplerState
    {
        // ID3D11DeviceChild
        [PreserveSig]
        void GetDesc(out D3D11_SAMPLER_DESC pDesc);
    }
}
