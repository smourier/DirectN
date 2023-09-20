// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GETDEVICESTATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_DEVICEEXECUTION_STATE ExecutionState { get => InteropRuntime.Get<_D3DKMT_DEVICEEXECUTION_STATE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_D3DKMT_DEVICEEXECUTION_STATE>(value, __bits, 0, 32); } }
        public _D3DKMT_DEVICEPRESENT_STATE PresentState { get => InteropRuntime.Get<_D3DKMT_DEVICEPRESENT_STATE>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_D3DKMT_DEVICEPRESENT_STATE>(value, __bits, 0, 512); } }
        public _D3DKMT_DEVICERESET_STATE ResetState { get => InteropRuntime.Get<_D3DKMT_DEVICERESET_STATE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_D3DKMT_DEVICERESET_STATE>(value, __bits, 0, 32); } }
        public _D3DKMT_DEVICEPRESENT_STATE_DWM PresentStateDWM { get => InteropRuntime.Get<_D3DKMT_DEVICEPRESENT_STATE_DWM>(__bits, 0, 576); set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_D3DKMT_DEVICEPRESENT_STATE_DWM>(value, __bits, 0, 576); } }
        public _D3DKMT_DEVICEPAGEFAULT_STATE PageFaultState { get => InteropRuntime.Get<_D3DKMT_DEVICEPAGEFAULT_STATE>(__bits, 0, 256); set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_D3DKMT_DEVICEPAGEFAULT_STATE>(value, __bits, 0, 256); } }
        public _D3DKMT_DEVICEPRESENT_QUEUE_STATE PresentQueueState { get => InteropRuntime.Get<_D3DKMT_DEVICEPRESENT_QUEUE_STATE>(__bits, 0, 40); set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_D3DKMT_DEVICEPRESENT_QUEUE_STATE>(value, __bits, 0, 40); } }
    }
}
