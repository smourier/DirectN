namespace DirectN
{
    public static class WindowsConstants
    {
        public const int MAPVK_VK_TO_CHAR = 2;
        public const int SIZE_MINIMIZED = 1;
        
        public const int CS_HREDRAW = 0x00000002;
        public const int CS_VREDRAW = 0x00000001;

        public const int GWL_STYLE = -16;
        public const int GWL_EXSTYLE = -20;
        public const int GW_OWNER = 4;
        public const int GWLP_USERDATA = -21;
        
        //public  const int MONITOR_DEFAULTTOPRIMARY = 0x00000001;
        //public  const int MONITOR_DEFAULTTONEAREST = 0x00000002;
        
        public const int ICON_BIG = 1;

        public const int CW_USEDEFAULT = unchecked((int)0x80000000);

        public const int SPI_GETCARETWIDTH = 0x00002006;

        public const int PM_NOREMOVE = 0;
        public const int PM_REMOVE = 1;
        public const int PM_NOYIELD = 2;
    }
}
