namespace DirectN
{
    // same as Windows.Storage.FileProperties.PhotoOrientation but supports lower Windows versions
    public enum PHOTO_ORIENTATION
    {
        NORMAL = 1,
        FLIPHORIZONTAL = 2,
        ROTATE180 = 3,
        FLIPVERTICAL = 4,
        TRANSPOSE = 5,
        ROTATE270 = 6,
        TRANSVERSE = 7,
        ROTATE90 = 8,
    }
}
