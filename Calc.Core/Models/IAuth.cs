namespace Calc.Models
{
    public interface IAuth
    {
        bool Login(string user, string pwd);
    }
}