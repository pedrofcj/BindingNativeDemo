using System;
namespace BindingNativeDemo.Services
{
    public interface IMathService
    {
        int Add(int number01, int number02);
        int Subtract(int number01, int number02);
        int Multiply(int number01, int number02);
    }
}
