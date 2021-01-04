using System;

namespace switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSwitch(10, 20, '+');

            TestSwitchFallThrough();
        }
        public static void TestSwitch(int op1, int op2, char opr)
        {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unknown Operator");
                    return; //return akan mengembalikan hasil dari variable result ke luar body switch
            }
            Console.WriteLine("Result: {0}", result);
            //{0} adalah format string untuk memberikan argument pertama (index 0) setelah string "Result: "
            //Format string {0} ini akan digantikan dengan nilai dari variable result (argument pertama)
            return; //return di sini tidak wajib
        }
        public static void TestSwitchFallThrough()
        {
            DateTime dt = DateTime.Today;
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is a weekday");
                    break;
                default:
                    Console.WriteLine("Today is a weekend day");
                    break;
            }
        }
    }
}
