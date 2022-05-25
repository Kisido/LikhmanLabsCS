namespace Lab1.Fractions
{
    class Number
    {
        public int Num { get; set; }

        public bool IsEven { get; set; }

        public Number()
        {
            Num = 0;
            IsEven = true;
        }

        public Number(int value)
        {
            Num = value;
            IsEven = value % 2 == 0;
        }
    }
}
