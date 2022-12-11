namespace ChristmasChallenge
{
    internal class Envelope
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Envelope(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
