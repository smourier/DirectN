using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Resource
    {
        // ID3D11DeviceChild

        [PreserveSig]
        void GetType(out D3D11_RESOURCE_DIMENSION pResourceDimension);
        
        [PreserveSig]
        void SetEvictionPriority(int EvictionPriority);

        [PreserveSig]
        int GetEvictionPriority();
    }
}
