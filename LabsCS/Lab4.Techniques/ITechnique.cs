namespace Lab4.Techniques
{
    public interface ITechnique
    {
        int Price { get; set; }

        bool TryBuy(int money);

        string Buy(ref int money);
    }
}

