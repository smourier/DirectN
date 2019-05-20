// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2772,4)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_POWER_COMPONENT_MAPPING__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public DXGK_POWER_COMPONENT_ENGINE_DESC EngineDesc { get => InteropRuntime.Get<DXGK_POWER_COMPONENT_ENGINE_DESC>(__bits, 0, 32); set => InteropRuntime.Set<DXGK_POWER_COMPONENT_ENGINE_DESC>(value, __bits, 0, 32); }
        public DXGK_POWER_COMPONENT_MONITOR_REFRESH_DESC MonitorRefreshDesc { get => InteropRuntime.Get<DXGK_POWER_COMPONENT_MONITOR_REFRESH_DESC>(__bits, 0, 32); set => InteropRuntime.Set<DXGK_POWER_COMPONENT_MONITOR_REFRESH_DESC>(value, __bits, 0, 32); }
        public DXGK_POWER_COMPONENT_MONITOR_DESC MonitorDesc { get => InteropRuntime.Get<DXGK_POWER_COMPONENT_MONITOR_DESC>(__bits, 0, 32); set => InteropRuntime.Set<DXGK_POWER_COMPONENT_MONITOR_DESC>(value, __bits, 0, 32); }
        public DXGK_POWER_COMPONENT_MEMORY_DESC MemoryDesc { get => InteropRuntime.Get<DXGK_POWER_COMPONENT_MEMORY_DESC>(__bits, 0, 32); set => InteropRuntime.Set<DXGK_POWER_COMPONENT_MEMORY_DESC>(value, __bits, 0, 32); }
        public DXGK_POWER_COMPONENT_SHARED_DESC SharedDesc { get => InteropRuntime.Get<DXGK_POWER_COMPONENT_SHARED_DESC>(__bits, 0, 32); set => InteropRuntime.Set<DXGK_POWER_COMPONENT_SHARED_DESC>(value, __bits, 0, 32); }
    }
}
