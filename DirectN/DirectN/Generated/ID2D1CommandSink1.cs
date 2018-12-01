// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_2.h(150,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This interface performs all the same functions as the existing ID2D1CommandSink interface. It also enables access to the new primitive blend modes, MIN and ADD, through its SetPrimitiveBlend1 method.
    /// </summary>
    [Guid("9eb767fd-4269-4467-b8c2-eb30cb305743"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1CommandSink1
    {
        [PreserveSig]
        HRESULT SetPrimitiveBlend1(D2D1_PRIMITIVE_BLEND primitiveBlend);
    }
}
