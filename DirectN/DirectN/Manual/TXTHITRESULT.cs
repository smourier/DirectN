namespace DirectN
{
    public enum TXTHITRESULT
    {
        TXTHITRESULT_NOHIT = 0, //@emem	no hit
        TXTHITRESULT_TRANSPARENT = 1, //@emem point is within the text's rectangle, but in a transparent region
        TXTHITRESULT_CLOSE = 2, //@emem	point is close to the text
        TXTHITRESULT_HIT = 3, //@emem dead-on hit
    }
}
