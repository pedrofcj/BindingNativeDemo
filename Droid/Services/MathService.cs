using System;
using BindingNativeDemo.Droid.Services;
using BindingNativeDemo.Services;
using Com.Nigelcardozo.Mathlibrary;
using Xamarin.Forms;

[assembly: Dependency(typeof(MathService))]
namespace BindingNativeDemo.Droid.Services
{
    public class MathService : IMathService
    {
        private MathX _mathX;

        public MathService() 
        {
            _mathX = new MathX();
        }

        public int Add(int number01, int number02)
        {
            return _mathX.AddX(number01, number02);
        }

        public int Multiply(int number01, int number02)
        {
            return _mathX.MultiplyX(number01, number02);
        }

        public int Subtract(int number01, int number02)
        {
            return _mathX.SubtractX(number01, number02);
        }
    }
}
