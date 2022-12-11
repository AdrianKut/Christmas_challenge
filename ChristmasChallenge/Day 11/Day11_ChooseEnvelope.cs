namespace ChristmasChallenge
{
    internal class Day11_ChooseEnvelope : IShowResult
    {
        readonly public Envelope SmallEnvelope = new Envelope(10, 15);
        readonly public Envelope MediumEnvelope = new Envelope(20, 30);
        readonly public Envelope BigEnvelope = new Envelope(30, 30);

        public List<Gift> PrepareGifts()
        {
            return new List<Gift>() {
                    new Gift("Parfum", 12, 30),
                    new Gift("Socks", 10, 10),
                    new Gift("Book", 30, 25),
                    new Gift("Clock", 15, 15),
                    new Gift("Wallet", 5, 10)
            };
        }

        public void CalculateEnvelopeSize(Gift gift)
        {
            if (gift.Height <= SmallEnvelope.Height && gift.Width <= SmallEnvelope.Width)
                Console.WriteLine($"For {gift.Name} you need Small Envelope.");
            else if (gift.Height <= MediumEnvelope.Height && gift.Width <= MediumEnvelope.Width)
                Console.WriteLine($"For {gift.Name} you need Medium Envelope.");
            else 
                    Console.WriteLine($"For {gift.Name} you need Big Envelope.");
        }
        public void ShowResult()
        {
            List<Gift> gifts = PrepareGifts();

            foreach (Gift gift in gifts)
                CalculateEnvelopeSize(gift);
        }
    }
}
