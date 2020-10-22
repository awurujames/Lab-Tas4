namespace MYHypothenus
{
    public class Hypothenuse
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public Hypothenuse(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Hypothenes()
        {
            hyp = (Num1 * Num1) + (Num2 * Num2);
            hyper = Math.Sqrt(hyp);

            return hyper;
        }
    }
}