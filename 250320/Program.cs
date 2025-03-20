namespace _250320_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("실 수 2개를 입력하세요.");
            Console.Write("첫 번째 수 : ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 수 : ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("계산할 부호(+, -, *, /, %)를 입력하세요 : ");
            string order = Console.ReadLine();

            switch(order)
            {
                case "+":
                    Console.WriteLine(result = input1 + input2);
                    break;
                case "-":
                    Console.WriteLine(result = input1 - input2);
                    break;
                case "*":
                    Console.WriteLine(result = input1 * input2);
                    break;
                case "/":
                    Console.WriteLine(result = input1 / input2);
                    break;
                case "%":
                    Console.WriteLine(result = input1 % input2);
                    break;
                default:
                    Console.WriteLine("잘못 입력했습니다.");
                    break;

            }
        }
    }
}
