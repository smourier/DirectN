namespace DirectN
{
    // note the windows type is HANDLE (IntPtr)
    public enum DPI_AWARENESS_CONTEXT
    {
        DPI_AWARENESS_CONTEXT_INVALID = 0, // not in Windows
        DPI_AWARENESS_CONTEXT_UNAWARE = -1,
        DPI_AWARENESS_CONTEXT_SYSTEM_AWARE = -2,
        DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE = -3,
        DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 = -4,
        DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED = -5,
    }
}
