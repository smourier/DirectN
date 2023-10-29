namespace DirectN
{
    public enum TSW
    {
        SW_SCROLLCHILDREN = 0x0001, /* Scroll children within *lprcScroll. */
        SW_INVALIDATE = 0x0002, /* Invalidate after scrolling */
        SW_ERASE = 0x0004, /* If SW_INVALIDATE, don't send WM_ERASEBACKGROUND */
        SW_SMOOTHSCROLL = 0x0010, /* Use smooth scrolling */
    }
}
