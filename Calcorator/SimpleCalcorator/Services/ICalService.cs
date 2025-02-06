using System.Linq.Expressions;

namespace SimpleCalcorator.Services
{
    public interface ICalService
    {
        public string CalResult(double op1, char op, double op2);
    }
}
