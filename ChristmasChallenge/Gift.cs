namespace ChristmasChallenge
{
    internal class Gift
    {
        public string Name { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Gift(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
        }
    }
}
