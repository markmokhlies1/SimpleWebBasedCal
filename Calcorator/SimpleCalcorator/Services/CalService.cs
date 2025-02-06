using System.Linq.Expressions;
using System.Text;

namespace SimpleCalcorator.Services
{
    public class CalService : ICalService
    {
        public string CalResult(double op1, char op, double op2)
        {
            string result = null;
            if (op == '/' && op2 == 0)
            {
                return result="Error";
            }
            double answer = 0;
            switch (op)
            {
                case '+':
                    answer = op1 + op2;
                    break;
                case '%':
                    answer = op1 / 100;
                    break;
                case '-':
                    answer = op1 - op2;
                    break;
                case '*':
                    answer = op1 * op2;
                    break;
                case '/':
                    answer = op1 / op2;
                    break;
                case 's':
                    answer = Math.Sqrt(op1);
                    break;
                default:
                    answer = op1;
                    break;
            };
            return answer.ToString();

        }
    }
}
