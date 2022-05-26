namespace Lab2.Diamond
{
    public class FirstLvlDiamond
    {
        public string Name { get; set; }

        public int CaratWeight { get; set; }

        public int CutQuality { get; set; }

        public  FirstLvlDiamond()
        {
            Name = "";
            CaratWeight = 0;
            CutQuality = 0;
        }

        public FirstLvlDiamond(string name, int caratWeight, int cutQuality)
        {
            Name = name;
            CaratWeight = caratWeight;
            CutQuality = cutQuality;
        }

        public virtual double Quality() => 0.4 * CaratWeight + 0.6 * CutQuality;

        public override string ToString() => "Название: " + Name + ", Вес: " + CaratWeight.ToString() + ", Качество огранки: " + CutQuality.ToString();
    }
}
