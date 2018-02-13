using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("4b35d0cd-1e15-4258-9c98-1b1333f6dd3b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Asynchronous
    {
        // ID3D11DeviceChild
        [PreserveSig]
        int GetDataSize();
    }
}
