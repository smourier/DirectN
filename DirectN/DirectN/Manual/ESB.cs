namespace DirectN
{
    public enum ESB
    {
        ESB_ENABLE_BOTH = 0x0000,
        ESB_DISABLE_BOTH = 0x0003,
        ESB_DISABLE_LEFT = 0x0001,
        ESB_DISABLE_RIGHT = 0x0002,
        ESB_DISABLE_UP = 0x0001,
        ESB_DISABLE_DOWN = 0x0002,
        ESB_DISABLE_LTUP = ESB_DISABLE_LEFT,
        ESB_DISABLE_RTDN = ESB_DISABLE_RIGHT,
    }
}
