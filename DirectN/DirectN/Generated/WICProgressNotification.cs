namespace DirectN
{
    public enum WICProgressNotification
    {
        WICProgressNotificationBegin = 0x00010000,
        WICProgressNotificationEnd = 0x00020000,
        WICProgressNotificationFrequent = 0x00040000,
        WICProgressNotificationAll = unchecked((int)0xFFFF0000)
    }
}
