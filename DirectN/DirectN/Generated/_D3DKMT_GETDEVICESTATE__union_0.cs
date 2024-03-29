﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GETDEVICESTATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_DEVICEEXECUTION_STATE ExecutionState {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_DEVICEEXECUTION_STATE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<_D3DKMT_DEVICEEXECUTION_STATE>(value, __bits, 0, 32); } }
        public _D3DKMT_DEVICEPRESENT_STATE PresentState {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_DEVICEPRESENT_STATE>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<_D3DKMT_DEVICEPRESENT_STATE>(value, __bits, 0, 320); } }
        public _D3DKMT_DEVICERESET_STATE ResetState {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_DEVICERESET_STATE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<_D3DKMT_DEVICERESET_STATE>(value, __bits, 0, 32); } }
        public _D3DKMT_DEVICEPRESENT_STATE_DWM PresentStateDWM {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_DEVICEPRESENT_STATE_DWM>(__bits, 0, 384);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<_D3DKMT_DEVICEPRESENT_STATE_DWM>(value, __bits, 0, 384); } }
        public _D3DKMT_DEVICEPAGEFAULT_STATE PageFaultState {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_DEVICEPAGEFAULT_STATE>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<_D3DKMT_DEVICEPAGEFAULT_STATE>(value, __bits, 0, 256); } }
        public _D3DKMT_DEVICEPRESENT_QUEUE_STATE PresentQueueState {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_DEVICEPRESENT_QUEUE_STATE>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<_D3DKMT_DEVICEPRESENT_QUEUE_STATE>(value, __bits, 0, 64); } }
    }
}
