using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DirectN
{
    [Guid("28acf509-7f5c-48f6-8611-f316010a6380"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11UnorderedAccessView
    {
        // ID3D11View
        [PreserveSig]
        void GetDesc(out D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc);
    }
}
