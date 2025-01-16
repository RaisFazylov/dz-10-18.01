/* Домашнее задание 12.1 На перегрузку операторов. Описать класс комплексных чисел.
Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух
комплексных чисел. Переопределить метод ToString() для комплексного числа.
Протестировать на простом примере. */

namespace MathSystem
{
    public class Complex
    {
        private double real;
        private double imaginary;
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator +(Complex a, Complex b)
            => new Complex(a.real + b.real, a.imaginary + b.imaginary);
        public static bool operator ==(Complex a, Complex b)
            => a.real == b.real && a.imaginary == b.imaginary;
        public static bool operator !=(Complex a, Complex b) => !(a == b);
        public override string ToString() => $"{real} + {imaginary}i";
    }
}
