// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(986,9)
namespace DirectN
{
    /// <summary>
    /// Specifies the threading model of the created factory and all of its derived resources.
    /// </summary>
    public enum D2D1_FACTORY_TYPE
    {
        /// <summary>
        /// The resulting factory and derived resources may only be invoked serially. Reference counts on resources are interlocked, however, resource and render target state is not protected from multi-threaded access.
        /// </summary>
        D2D1_FACTORY_TYPE_SINGLE_THREADED = 0,
        
        /// <summary>
        /// The resulting factory may be invoked from multiple threads. Returned resources use interlocked reference counting and their state is protected.
        /// </summary>
        D2D1_FACTORY_TYPE_MULTI_THREADED = 1,
        
        /// <summary>
        /// The resulting factory may be invoked from multiple threads. Returned resources use interlocked reference counting and their state is protected.
        /// </summary>
        D2D1_FACTORY_TYPE_FORCE_DWORD = -1,
    }
}
