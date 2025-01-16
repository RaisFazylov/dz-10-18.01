/* Упражнение 12.2 Создать класс рациональных чисел. В классе два поля – числитель и
знаменатель. Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <,
>, <=, >=, +, – , ++, --. Переопределить метод ToString() для вывода дроби. Определить
операторы преобразования типов между типом дробь, float, int. Определить операторы *, /,
%. */
namespace MathSystem
{
    public class Rational
    {
        private int numerator;
        private int denominator;
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static bool operator ==(Rational a, Rational b) => a.numerator * b.denominator == b.numerator * a.denominator;
        public static bool operator !=(Rational a, Rational b) => !(a == b);
        public override string ToString() => $"{numerator}/{denominator}";
    }
}
