// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(7057,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e13af3c1-4d47-4354-b1f5-e83ae0ecae60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextFormattedText
    {
        [PreserveSig]
        HRESULT GetText(/* [annotation][out] _Outptr_result_maybenull_ */ out IntPtr text);
        
        [PreserveSig]
        uint GetSubformattingCount();
        
        [PreserveSig]
        HRESULT GetSubformatting(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Out_ */ out uint firstChar, /* [annotation][out] _Out_ */ out uint charLength, /* [annotation][out] _COM_Outptr_result_maybenull_ */ out IMFTimedTextStyle style);
    }
}
