// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcomp.h(400,1)
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
