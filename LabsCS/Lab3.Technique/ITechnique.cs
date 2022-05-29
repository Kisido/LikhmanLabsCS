namespace Lab3.Technique
{
    public interface ITechnique
    {
        int Price { get; set; }

        bool TryBuy(int money);

        string Buy(ref int money);
    }
}
