// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("eacdd04c-117e-4e17-88f4-d1b12b0e3d89"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionTarget
    {
        [PreserveSig]
        HRESULT SetRoot(/* THIS_ _In_opt_ */ IDCompositionVisual visual);
    }
}
