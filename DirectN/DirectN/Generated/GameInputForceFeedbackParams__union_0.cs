// generated from <Windows SDK Path>\um\gameinput.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputForceFeedbackParams__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 104)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public GameInputForceFeedbackConstantParams constant {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackConstantParams>(__bits, 0, 640);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackConstantParams>(value, __bits, 0, 640); } }
        public GameInputForceFeedbackRampParams ramp {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackRampParams>(__bits, 0, 832);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackRampParams>(value, __bits, 0, 832); } }
        public GameInputForceFeedbackPeriodicParams sineWave {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackPeriodicParams>(__bits, 0, 704);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackPeriodicParams>(value, __bits, 0, 704); } }
        public GameInputForceFeedbackPeriodicParams squareWave {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackPeriodicParams>(__bits, 0, 704);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackPeriodicParams>(value, __bits, 0, 704); } }
        public GameInputForceFeedbackPeriodicParams triangleWave {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackPeriodicParams>(__bits, 0, 704);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackPeriodicParams>(value, __bits, 0, 704); } }
        public GameInputForceFeedbackPeriodicParams sawtoothUpWave {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackPeriodicParams>(__bits, 0, 704);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackPeriodicParams>(value, __bits, 0, 704); } }
        public GameInputForceFeedbackPeriodicParams sawtoothDownWave {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackPeriodicParams>(__bits, 0, 704);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackPeriodicParams>(value, __bits, 0, 704); } }
        public GameInputForceFeedbackConditionParams spring {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackConditionParams>(__bits, 0, 416);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackConditionParams>(value, __bits, 0, 416); } }
        public GameInputForceFeedbackConditionParams friction {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackConditionParams>(__bits, 0, 416);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackConditionParams>(value, __bits, 0, 416); } }
        public GameInputForceFeedbackConditionParams damper {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackConditionParams>(__bits, 0, 416);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackConditionParams>(value, __bits, 0, 416); } }
        public GameInputForceFeedbackConditionParams inertia {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<GameInputForceFeedbackConditionParams>(__bits, 0, 416);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[104]; InteropRuntime.Set<GameInputForceFeedbackConditionParams>(value, __bits, 0, 416); } }
    }
}
