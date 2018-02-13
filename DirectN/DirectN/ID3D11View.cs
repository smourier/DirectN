using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("839d1216-bb2e-412b-b7f4-a9dbebe08ed1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11View
    {
        // ID3D11DeviceChild
        [PreserveSig]
        void GetResource(out ID3D11Resource ppResource);
    }
}
