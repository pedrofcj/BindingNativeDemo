using System;
using BindingNativeDemo.iOS.Services;
using Xamarin.Forms;
using BindingNativeDemo.Services;
using NativeIosLibrary;

[assembly: Dependency(typeof(MathService))]
namespace BindingNativeDemo.iOS.Services
{
    public class MathService : IMathService
    {
        public MathService()
        {
        }

        public int Add(int number01, int number02)
        {
            return MathX.AddX(number01, number02);

        }

        public int Multiply(int number01, int number02)
        {
            return MathX.MultiplyX(number01, number02);
       
        }

        public int Subtract(int number01, int number02)
        {
            return MathX.SubtractX(number01, number02);
       
        }
    }
}
