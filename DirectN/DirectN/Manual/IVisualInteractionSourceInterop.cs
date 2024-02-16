using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("11F62CD1-2F9D-42D3-B05F-D6790D9E9F8E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVisualInteractionSourceInterop
    {
        [PreserveSig]
        HRESULT TryRedirectForManipulation(ref POINTER_INFO pointerInfo);
    }
}
