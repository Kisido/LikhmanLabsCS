using System;

namespace Lab3.Technique
{
    public abstract class Player : ITechnique
    {
        public int Price { get; set; }

        public string Color { get; set; }

        public string Model { get; set; }

        public int Memory { get; set; }

        public bool TryBuy(int money) => money >= Price;

        public string Buy(ref int money)
        {
            if (TryBuy(money))
            {
                money -= Price;
                return "Вы купили устройство.";
            }
            else 
            {
                return "Вам не хватает " + (Price - money).ToString() + " для покупки устройства.";
            }
        }

        public abstract string AskInformationFromConsultant();

        public string Rate()
        {
            Random random = new Random();
            return (random.Next(0, 200) < 95) ? "Вам не нравится этот товар." : "Вам нравится этот товар.";
        }
    }
}
