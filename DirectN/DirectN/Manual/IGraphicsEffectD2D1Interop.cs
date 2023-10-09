using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2FC57384-A068-44D7-A331-30982FCF7177"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGraphicsEffectD2D1Interop
    {
        [PreserveSig]
        HRESULT GetEffectId(out Guid id);

        [PreserveSig]
        HRESULT GetNamedPropertyMapping([MarshalAs(UnmanagedType.LPWStr)] string name, out uint index, out GRAPHICS_EFFECT_PROPERTY_MAPPING mapping);

        [PreserveSig]
        HRESULT GetPropertyCount(out uint count);

        // note: we cannot use IPropertyValue because CLR plays too much tricks with it
        [PreserveSig]
        HRESULT GetProperty(uint index, out IntPtr value);

        [PreserveSig]
        HRESULT GetSource(uint index, out IntPtr source);

        [PreserveSig]
        HRESULT GetSourceCount(out uint count);
    }
}
