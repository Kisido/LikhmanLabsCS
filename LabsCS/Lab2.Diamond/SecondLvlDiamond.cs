namespace Lab2.Diamond
{
    public class SecondLvlDiamond : FirstLvlDiamond
    {
        public string Color { get; set; }

        public SecondLvlDiamond() => Color = "";

        public SecondLvlDiamond(string name, int caratWeight, int cutQuality, string color) : base(name, caratWeight, cutQuality) => Color = color;

        public override double Quality()
        {
            if (Color.ToLower() == "голубой")
                return base.Quality() + 1;
            else if (Color.ToLower() == "желтый" || Color.ToLower() == "жёлтый")
                return base.Quality() - 0.5;
            else
                return base.Quality();
        }

        public override string ToString() => base.ToString() + ", Цвет: " + Color;
    }
}
