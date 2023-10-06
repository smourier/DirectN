using System.Runtime.InteropServices;

namespace DirectN
{
    public static class DispatcherQueueController
    {
        public static IDispatcherQueueController Create(bool throwOnError = true)
        {
            var options = new DispatcherQueueOptions
            {
                apartmentType = DISPATCHERQUEUE_THREAD_APARTMENTTYPE.DQTAT_COM_STA,
                threadType = DISPATCHERQUEUE_THREAD_TYPE.DQTYPE_THREAD_CURRENT,
                dwSize = Marshal.SizeOf<DispatcherQueueOptions>()
            };

            var hr = CreateDispatcherQueueController(options, out var controller);
            if (throwOnError && hr != 0)
            {
                const int RPC_E_WRONG_THREAD = unchecked((int)0x8001010E); // DispatcherQueueController is already created on this thread
                if (hr != RPC_E_WRONG_THREAD)
                {
                    Marshal.ThrowExceptionForHR(hr);
                }
            }
            return controller;
        }

        private enum DISPATCHERQUEUE_THREAD_APARTMENTTYPE
        {
            DQTAT_COM_NONE = 0,
            DQTAT_COM_ASTA = 1,
            DQTAT_COM_STA = 2
        }

        private enum DISPATCHERQUEUE_THREAD_TYPE
        {
            DQTYPE_THREAD_DEDICATED = 1,
            DQTYPE_THREAD_CURRENT = 2,
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct DispatcherQueueOptions
        {
            public int dwSize;
            public DISPATCHERQUEUE_THREAD_TYPE threadType;
            public DISPATCHERQUEUE_THREAD_APARTMENTTYPE apartmentType;
        }

        [DllImport("coremessaging", CharSet = CharSet.Unicode)]
        private static extern int CreateDispatcherQueueController(DispatcherQueueOptions options, out IDispatcherQueueController dispatcherQueueController);
    }
}
