// generated from <Windows SDK Path>\um\d2d1_1.h
namespace DirectN
{
    /// <summary>
    /// This specifies the threading mode used while simultaneously creating the device, factory, and device context.
    /// </summary>
    public enum D2D1_THREADING_MODE
    {
        /// <summary>
        /// Resources may only be invoked serially. Reference counts on resources are interlocked, however, resource and render target state is not protected from multi-threaded access
        /// </summary>
        D2D1_THREADING_MODE_SINGLE_THREADED = 0,
        
        /// <summary>
        /// Resources may be invoked from multiple threads. Resources use interlocked reference counting and their state is protected.
        /// </summary>
        D2D1_THREADING_MODE_MULTI_THREADED = 1,
        
        /// <summary>
        /// Resources may be invoked from multiple threads. Resources use interlocked reference counting and their state is protected.
        /// </summary>
        D2D1_THREADING_MODE_FORCE_DWORD = -1,
    }
}
