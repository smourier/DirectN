using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("D3EEF34C-0667-4AFC-8D13-867607B0FE91"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICompositorInterop2
    {
        [PreserveSig]
        HRESULT CheckCompositionTextureSupport(IntPtr renderingDevice, out bool supportsCompositionTextures);

        [PreserveSig]
        HRESULT CreateCompositionTexture(IntPtr d3dTexture, out IntPtr compositionTexture);
    }
}
