namespace DirectN
{
    public partial struct tagSIZE
    {
        public tagSIZE(uint cx, uint cy)
        {
            this.cx = (int)cx;
            this.cy = (int)cy;
        }

        public tagSIZE(int cx, int cy)
        {
            this.cx = cx;
            this.cy = cy;
        }

        public override string ToString() => "CX=" + cx + ",CY=" + cy;
        public D2D_SIZE_U ToD2D_SIZE_U() => new D2D_SIZE_U(cx, cy);
    }
}
