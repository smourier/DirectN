// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(2544,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("688e1a58-5094-47c8-adc8-fbcea60ae92b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextAnalysisSource
    {
        [PreserveSig]
        HRESULT GetTextAtPosition(uint textPosition, /* _Outptr_result_buffer_(*textLength) */ out IntPtr textString, /* _Out_ */ out uint textLength);
        
        [PreserveSig]
        HRESULT GetTextBeforePosition(uint textPosition, /* _Outptr_result_buffer_(*textLength) */ out IntPtr textString, /* _Out_ */ out uint textLength);
        
        [PreserveSig]
        DWRITE_READING_DIRECTION GetParagraphReadingDirection();
        
        [PreserveSig]
        HRESULT GetLocaleName(uint textPosition, /* _Out_ */ out uint textLength, /* _Outptr_result_z_ */ out IntPtr localeName);
        
        [PreserveSig]
        HRESULT GetNumberSubstitution(uint textPosition, /* _Out_ */ out uint textLength, /* _COM_Outptr_ */ out IDWriteNumberSubstitution numberSubstitution);
    }
}
