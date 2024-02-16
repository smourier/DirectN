using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("D528A265-F0A5-422F-A39D-EF62D7CD1CC4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICompositionTextureInterop
    {
        [PreserveSig]
        HRESULT GetAvailableFence(out ulong fenceValue, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, out IntPtr availableFence);
    }
}
