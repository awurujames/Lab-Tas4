namespace MultipleNumber
{
    public class Multiple
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public Multiple(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
        public bool MultipleNum()
        {
            if (FirstNumber % SecondNumber == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}