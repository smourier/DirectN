// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;
using int64_t = System.Int64;

namespace DirectN
{
    [ComImport, Guid("61f08cf1-1ffc-40ca-a2b8-e1ab8bc5b6dc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameInputRawDeviceReport
    {
        [PreserveSig]
        void GetDevice(/* THIS_ _Outptr_ */ out IGameInputDevice device);
        
        [PreserveSig]
        GameInputRawDeviceReportInfo GetReportInfo();
        
        [PreserveSig]
        ulong GetRawDataSize();
        
        [PreserveSig]
        ulong GetRawData(/* THIS_ _In_ */ ulong bufferSize, /* _Out_writes_(bufferSize) */ IntPtr buffer);
        
        [PreserveSig]
        void SetRawData(/* THIS_ _In_ */ ulong bufferSize, /* _In_reads_(bufferSize) */ IntPtr buffer);
        
        [PreserveSig]
        void GetItemValue(/* THIS_ _In_ */ uint itemIndex, /* _Out_ */ out int64_t value);
        
        [PreserveSig]
        void SetItemValue(/* THIS_ _In_ */ uint itemIndex, /* _In_ */ long value);
        
        [PreserveSig]
        void ResetItemValue(/* THIS_ _In_ */ uint itemIndex);
        
        [PreserveSig]
        void ResetAllItems();
    }
}
