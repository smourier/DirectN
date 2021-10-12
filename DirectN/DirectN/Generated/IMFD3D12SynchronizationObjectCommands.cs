// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfd3d12.h(95,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("09d0f835-92ff-4e53-8efa-40faa551f233"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFD3D12SynchronizationObjectCommands
    {
        [PreserveSig]
        HRESULT EnqueueResourceReady(/* [annotation][in] _In_ */ ID3D12CommandQueue pProducerCommandQueue);
        
        [PreserveSig]
        HRESULT EnqueueResourceReadyWait(/* [annotation][in] _In_ */ ID3D12CommandQueue pConsumerCommandQueue);
        
        [PreserveSig]
        HRESULT SignalEventOnResourceReady(IntPtr hEvent);
        
        [PreserveSig]
        HRESULT EnqueueResourceRelease(/* [annotation][in] _In_ */ ID3D12CommandQueue pConsumerCommandQueue);
    }
}
