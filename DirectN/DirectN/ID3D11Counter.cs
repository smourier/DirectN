using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("6e8c49fb-a371-4770-b440-29086022b741"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Counter
    {
        // ID3D11Asynchronous
        [PreserveSig]
        void GetDesc(out D3D11_COUNTER_DESC pDesc);
    }
}
