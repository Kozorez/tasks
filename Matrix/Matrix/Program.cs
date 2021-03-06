﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Rational
    {
        int sign;
        int intPart;
        int numerator;
        int denominator;

        public Rational(int n, int d, int i = 0, int s = 1)
        {
            if (d != 0)
            {
                sign = s;
                intPart = i;
                numerator = n;
                denominator = d;
                GetMixedView();
            }
            else
            {
                throw new DivideByZeroException();
            }
        }

        public Rational()
        {
            sign = 1;
            intPart = 0;
            numerator = 0;
            denominator = 1;
        }

        void GetMixedView()
        {
            Cancellation();
            GetIntPart();
        }

        void Cancellation()
        {
            if (numerator != 0)
            {
                int m = denominator;
                int n = numerator;
                int ost = m % n;
                while (ost != 0)
                {
                    m = n;
                    n = ost;
                    ost = m % n;
                }
                int nod = n;
                if (nod != 1)
                {
                    numerator /= nod;
                    denominator /= nod;
                }
            }
        }

        void GetIntPart()
        {
            if (numerator >= denominator)
            {
                intPart += (numerator / denominator);
                numerator %= denominator;
            }
        }

        public static Rational operator +(Rational ob1, Rational ob2)
        {
            Rational res = new Rational();
            res.numerator = ob1.sign * (ob1.intPart * ob1.denominator + ob1.numerator) * ob2.denominator + ob2.sign * (ob2.intPart * ob2.denominator + ob2.numerator) * ob1.denominator;
            res.denominator = ob1.denominator * ob2.denominator;
            if (res.numerator < 0)
            {
                res.numerator *= -1;
                res.sign = -1;
            }
            res.GetMixedView();
            return res;
        }

        public static Rational operator +(Rational ob1, int a)
        {
            if (a == 0)
            {
                return new Rational(ob1.numerator, ob1.denominator, ob1.intPart, ob1.sign);
            }
            Rational ob2 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            Rational res = ob1 + ob2;
            return res;
        }

        public static Rational operator +(int a, Rational ob1)
        {
            if (a == 0)
            {
                return new Rational(ob1.numerator, ob1.denominator, ob1.intPart, ob1.sign);
            }
            Rational ob2 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            Rational res = ob1 + ob2;
            return res;
        }

        public static Rational operator -(Rational ob1, Rational ob2)
        {
            Rational res = new Rational();
            res.numerator = ob1.sign * (ob1.intPart * ob1.denominator + ob1.numerator) * ob2.denominator - ob2.sign * (ob2.intPart * ob2.denominator + ob2.numerator) * ob1.denominator;
            res.denominator = ob1.denominator * ob2.denominator;
            if (res.numerator < 0)
            {
                res.numerator *= -1;
                res.sign = -1;
            }
            res.GetMixedView();
            return res;
        }

        public static Rational operator -(Rational ob1, int a)
        {
            if (a == 0)
            {
                return new Rational(ob1.numerator, ob1.denominator, ob1.intPart, ob1.sign);
            }
            Rational ob2 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            Rational res = ob1 - ob2;
            return res;
        }

        public static Rational operator -(int a, Rational ob1)
        {
            if (a == 0)
            {
                return new Rational(ob1.numerator, ob1.denominator, ob1.intPart, ob1.sign * -1);
            }
            Rational ob2 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            Rational res = ob2 - ob1;
            return res;
        }

        public static Rational operator *(Rational ob1, Rational ob2)
        {
            Rational res = new Rational();
            res.numerator = ob1.sign * (ob1.intPart * ob1.denominator + ob1.numerator) * ob2.sign * (ob2.intPart * ob2.denominator + ob2.numerator);
            res.denominator = ob1.denominator * ob2.denominator;
            if (res.numerator < 0)
            {
                res.numerator *= -1;
                res.sign = -1;
            }
            res.GetMixedView();
            return res;
        }

        public static Rational operator *(Rational ob1, int a)
        {
            if (a == 0)
            {
                return new Rational(0, 1, 0, 1);
            }
            Rational ob2 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            Rational res = ob1 * ob2;
            return res;
        }

        public static Rational operator *(int a, Rational ob1)
        {
            if (a == 0)
            {
                return new Rational(0, 1, 0, 1);
            }
            Rational ob2 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            Rational res = ob1 * ob2;
            return res;
        }

        public static Rational operator /(Rational ob1, Rational ob2)
        {
            Rational res = new Rational();
            res.numerator = ob1.sign * (ob1.intPart * ob1.denominator + ob1.numerator) * ob2.denominator;
            res.denominator = ob2.sign * (ob2.intPart * ob2.denominator + ob2.numerator) * ob1.denominator;
            if (res.numerator < 0)
            {
                res.numerator *= -1;
                res.sign = -1;
                if (res.denominator < 0)
                {
                    res.denominator *= -1;
                    res.sign = 1;
                }
            }
            else if (res.denominator < 0)
            {
                res.denominator *= -1;
                res.sign = -1;
            }
            res.GetMixedView();
            return res;
        }

        public static Rational operator /(Rational ob1, int a)
        {
            if (a == 0)
            {
                throw new System.DivideByZeroException();
            }
            Rational ob2 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            Rational res = ob1 / ob2;
            return res;
        }

        public static Rational operator /(int a, Rational ob1)
        {
            if (a == 0)
            {
                return new Rational(0, 1, 0, 1);
            }
            Rational ob2 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            Rational res = ob2 / ob1;
            return res;
        }

        public static bool operator ==(Rational ob1, Rational ob2)
        {
            Rational res = ob1 - ob2;
            if (res.numerator == 0 && res.intPart == 0)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Rational ob1, int a)
        {
            if (a == 0)
            {
                Rational ob2 = new Rational(0, 1, 0, 1);
                return (ob1 == ob2);
            }
            Rational ob3 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            return (ob1 == ob3);
        }

        public static bool operator ==(int a, Rational ob1)
        {
            if (a == 0)
            {
                Rational ob2 = new Rational(0, 1, 0, 1);
                return (ob1 == ob2);
            }
            Rational ob3 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            return (ob1 == ob3);
        }

        public static bool operator !=(Rational ob1, Rational ob2)
        {
            return (!(ob1 == ob2));
        }

        public static bool operator !=(Rational ob1, int a)
        {
            return (!(ob1 == a));
        }

        public static bool operator !=(int a, Rational ob1)
        {
            return (!(a == ob1));
        }

        public static bool operator >(Rational ob1, Rational ob2)
        {
            Rational res = ob1 - ob2;
            if (res.sign == 1)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Rational ob1, int a)
        {
            if (a == 0)
            {
                Rational ob2 = new Rational(0, 1, 0, 1);
                return (ob1 > ob2);
            }
            Rational ob3 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            return (ob1 > ob3);
        }

        public static bool operator >(int a, Rational ob1)
        {
            if (a == 0)
            {
                Rational ob2 = new Rational(0, 1, 0, 1);
                return (ob1 > ob2);
            }
            Rational ob3 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            return (ob1 > ob3);
        }

        public static bool operator <(Rational ob1, Rational ob2)
        {
            Rational res = ob1 - ob2;
            if (res.sign == -1)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Rational ob1, int a)
        {
            if (a == 0)
            {
                Rational ob2 = new Rational(0, 1, 0, 1);
                return (ob1 < ob2);
            }
            Rational ob3 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            return (ob1 < ob3);
        }

        public static bool operator <(int a, Rational ob1)
        {
            if (a == 0)
            {
                Rational ob2 = new Rational(0, 1, 0, 1);
                return (ob1 < ob2);
            }
            Rational ob3 = new Rational(0, 1, Math.Abs(a), a / Math.Abs(a));
            return (ob1 < ob3);
        }

        public static bool operator >=(Rational ob1, Rational ob2)
        {
            if (ob1 > ob2 || ob1 == ob2)
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(Rational ob1, int a)
        {
            if (ob1 > a || ob1 == a)
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(int a, Rational ob1)
        {
            if (a > ob1 || a == ob1)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(Rational ob1, Rational ob2)
        {
            if (ob1 < ob2 || ob1 == ob2)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(Rational ob1, int a)
        {
            if (ob1 < a || ob1 == a)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(int a, Rational ob1)
        {
            if (a < ob1 || a == ob1)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object ob1)
        {
            return ob1 is Rational && this == (Rational)ob1;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(numerator, denominator, intPart, sign).GetHashCode();
        }

        public static Rational Parse(string s)
        {
            int pointPos, slashPos;
            int sign = 1;
            int numerator, denominator, intPart;
            pointPos = slashPos = 0;

            if (s[0] == '-')
            {
                sign = -1;
                s = s.Substring(1);
            }

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '.' || s[i] == ',')
                {
                    if (pointPos == 0 && slashPos == 0)
                        pointPos = i;
                    else
                        throw new FormatException();
                }
                else if (s[i] == '/')
                {
                    if (slashPos == 0)
                        slashPos = i;
                    else
                        throw new FormatException();
                }

                if (!char.IsDigit(s[i]) && s[i] != ',' && s[i] != '.' && s[i] != '/')
                    throw new FormatException();
            }

            string[] fraction = s.Split('.', ',', '/', '-');

            if (pointPos != 0)
            {
                if (slashPos != 0)
                {
                    intPart = int.Parse(fraction[0]);
                    numerator = int.Parse(fraction[1]);
                    denominator = int.Parse(fraction[2]);
                }
                else
                {
                    intPart = int.Parse(fraction[0]);
                    numerator = int.Parse(fraction[1]);
                    denominator = (int)Math.Pow(10, fraction[1].Length);
                }
            }
            else if (slashPos != 0)
            {
                intPart = 0;
                numerator = int.Parse(fraction[0]);
                denominator = int.Parse(fraction[1]);
            }
            else
            {
                intPart = int.Parse(fraction[0]);
                numerator = 0;
                denominator = 1;
            }

            if (denominator == 0)
                throw new DivideByZeroException();

            return new Rational(numerator, denominator, intPart, sign);
        }

        public bool Compare_To_Zero()
        {
            if (intPart == 0 && numerator == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public Rational Long_To_Fraction(long i)
        {
            if (i == 0)
            {
                return new Rational();
            }
            else
            {
                return new Rational(0, 1, Convert.ToInt32(Math.Abs(i)), Convert.ToInt32(i / Math.Abs(i)));
            }
        }

        void show()
        {
            Console.WriteLine(numerator);
            Console.WriteLine(denominator);
            Console.WriteLine(intPart);
            Console.WriteLine(sign);
        }
    }

    class Matrix
    {
        double[,] array;
        int rows;
        int columns;

        static int counter = 0;
        static string[] newarray;

        public Matrix(int r, int c)
        {
            rows = r;
            columns = c;
            array = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] stroka = Console.ReadLine().Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToDouble(stroka[j]);
                }
            }
        }

        public Matrix(int r, int c, string empty)
        {
            rows = r;
            columns = c;
            array = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = 0;
                }
            }
        }

        bool Is_Square(Matrix ob1)
        {
            if (rows == ob1.rows && columns == ob1.columns)
            {
                return true;
            }
            return false;
        }

        void Show()
        {
            Console.WriteLine("Результат:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }

        public static Matrix operator +(Matrix ob1, Matrix ob2)
        {
            if (ob1.Is_Square(ob2))
            {
                Matrix result = new Matrix(ob1.rows, ob1.columns, "empty");
                for (int i = 0; i < result.rows; i++)
                {
                    for (int j = 0; j < result.columns; j++)
                    {
                        result.array[i, j] = ob1.array[i, j] + ob2.array[i, j];
                    }
                }
                return result;
            }
            throw new IndexOutOfRangeException();
        }

        public static Matrix operator -(Matrix ob1, Matrix ob2)
        {
            if (ob1.Is_Square(ob2))
            {
                Matrix result = new Matrix(ob1.rows, ob1.columns, "empty");
                for (int i = 0; i < result.rows; i++)
                {
                    for (int j = 0; j < result.columns; j++)
                    {
                        result.array[i, j] = ob1.array[i, j] - ob2.array[i, j];
                    }
                }
                return result;
            }
            throw new IndexOutOfRangeException();
        }

        public static Matrix operator *(Matrix ob1, Matrix ob2)
        {
            if (ob1.columns == ob2.rows)
            {
                Matrix result = new Matrix(ob1.rows, ob2.columns, "empty");
                for (int i = 0; i < result.rows; i++)
                {
                    for (int j = 0; j < result.columns; j++)
                    {
                        for (int k = 0; k < ob2.rows; k++)
                        {
                            result.array[i, j] += ob1.array[i, k] * ob2.array[k, j];
                        }
                    }
                }
                return result;
            }
            throw new IndexOutOfRangeException();
        }

        public static Matrix operator *(Matrix ob1, int a)
        {
            Matrix result = new Matrix(ob1.rows, ob1.columns, "empty");
            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.columns; j++)
                {
                    result.array[i, j] = ob1.array[i, j] * a;
                }
            }
            return result;
        }

        public static Matrix operator *(int a, Matrix ob1)
        {
            Matrix result = new Matrix(ob1.rows, ob1.columns, "empty");
            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.columns; j++)
                {
                    result.array[i, j] = a * ob1.array[i, j];
                }
            }
            return result;
        }

        //Обчислення визначника матриці (порядок не перевищує 6) за теоремою Лапласа

        double Determinant_Laplace()
        {
            double determinant = 0;
            if (rows == columns)
            {
                if (columns == 1)
                {
                    determinant = array[0, 0];
                }
                else
                {
                    Matrix newmatrix = new Matrix(rows - 1, columns - 1, "empty");
                    for (int i = 0; i < columns; i++)
                    {
                        for (int j = 1; j < rows; j++)
                        {
                            int h = 0;
                            for (int k = 0; k < columns; k++)
                            {
                                if (k == i)
                                {
                                    continue;
                                }
                                else
                                {
                                    newmatrix.array[j - 1, h] = array[j, k];
                                    h++;
                                }
                            }
                        }
                        determinant += array[0, i] * Math.Pow(-1, 2 + i) * newmatrix.Determinant_Laplace();
                    }
                }
                return determinant;
            }
            else
            {
                throw new ArithmeticException("Введена матриця не є квадратною!");
            }
        }

        //Обчислення визначника матриці методом зведення її до трикутної форми

        double Determinant_Triangle()
        {
            Matrix newmatrix = new Matrix(rows, columns, "empty");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newmatrix.array[i, j] = array[i, j];
                }
            }
            double determinant = 1;
            if (rows == columns)
            {
                for (int k = 0; k < newmatrix.rows - 1; k++)
                {
                    if (newmatrix.array[k, k] != 0)
                    {
                        for (int i = k + 1; i < newmatrix.rows; i++)
                        {
                            for (i = k + 1; i < newmatrix.rows; i++)
                            {
                                double temp = newmatrix.array[i, k] / newmatrix.array[k, k];
                                for (int j = 0; j < newmatrix.rows; j++)
                                {
                                    newmatrix.array[i, j] = newmatrix.array[i, j] - temp * newmatrix.array[k, j];
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new ArithmeticException("Під час роботи програми якийсь з діагональніх елементів став нулем. Отже, визначник дорівнює нулеві.");
                    }
                }
                newmatrix.Show();
                for (int q = 0; q < rows; q++)
                {
                    determinant *= newmatrix.array[q, q];
                }
                return determinant;
            }
            else
            {
                throw new ArithmeticException("Введена матриця не є квадратною!");
            }
        }

        //Обчислення визначника матриці (порядок не перевищує 5) за означенням

        double Determinant_Definition()
        {
            if (rows == columns)
            {
                double determinant = 0;
                int result = 1;
                string line = "";
                for (int i = 1; i < columns + 1; i++)
                {
                    line += i;
                }
                for (int j = 2; j < line.Length + 1; j++)
                {
                    result *= j;
                }
                newarray = new string[result];
                Combinations(line, "");
                for (int k = 0; k < counter; k++)
                {
                    double temp = 1;
                    for (int l = 0; l < columns; l++)
                    {
                        int n = Convert.ToInt32(newarray[k][l]);
                        temp *= array[l, n - '1'];
                    }
                    determinant += Sort(newarray[k]) * temp;
                }
                return determinant;
            }
            else
            {
                throw new ArithmeticException("Введена матриця не є квадратною!");
            }
        }

        void Combinations(string line, string result)
        {
            if (line == "")
            {
                newarray[counter] = result;
                counter++;
            }
            for (int i = 0; i < line.Length; i++)
            {
                Combinations(line.Remove(i, 1), result + line[i]);
            }
        }

        double Sort(string line)
        {
            char[] symbol = line.ToCharArray();
            int result = 1;
            for (int i = symbol.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (symbol[j] > symbol[j + 1])
                    {
                        char temp = symbol[j];
                        symbol[j] = symbol[j + 1];
                        symbol[j + 1] = temp;
                        result *= -1;
                    }
                }
            }
            return result;
        }

        //Множення матриць

        static Matrix Matrix_Product(Matrix ob1, Matrix ob2)
        {
            if (ob1.columns == ob2.rows)
            {
                Matrix result = new Matrix(ob1.rows, ob2.columns, "empty");
                for (int i = 0; i < result.rows; i++)
                {
                    for (int j = 0; j < result.columns; j++)
                    {
                        for (int k = 0; k < ob2.rows; k++)
                        {
                            result.array[i, j] += ob1.array[i, k] * ob2.array[k, j];
                        }
                    }
                }
                return result;
            }
            else
            {
                throw new ArithmeticException("Розміри введених матриць не відповідають вимогам задачі!");
            }
        }

        //Обчислення оберненої матриці (порядок не перевищує 5) за теоремою про існування оберненої

        Matrix Get_Inversed_Matrix_By_Theorem()
        {
            if (rows == columns)
            {
                double determinant = Determinant_Laplace();
                if (determinant != 0)
                {
                    Matrix transpose_matrix = Transpose();
                    Matrix united_matrix = new Matrix(rows, columns, "empty");
                    Matrix result = new Matrix(columns, rows, "empty");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            united_matrix.array[i, j] = transpose_matrix.Get_Cofactors(i, j);
                            result.array[i, j] = united_matrix.array[i, j] / determinant;
                        }
                    }
                    return result;
                }
                else
                {
                    throw new ArithmeticException("Детермінант матриці дорівнює нулеві. Оберненої матриці не існує!");
                }
            }
            else
            {
                throw new ArithmeticException("Введена матриця не є квадратною!");
            }
        }

        Matrix Transpose()
        {
            Matrix result = new Matrix(columns, rows, "empty");
            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.columns; j++)
                {
                    result.array[i, j] = array[j, i];
                }
            }
            return result;
        }

        double Get_Cofactors(int r, int c)
        {
            double cofactor = 0;
            if (rows == columns)
            {
                if (columns == 1)
                {
                    cofactor = array[0, 0];
                }
                else
                {
                    Matrix newmatrix = new Matrix(rows - 1, columns - 1, "empty");
                    int q = 0;
                    int h = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (i == r || j == c)
                            {
                                continue;
                            }
                            else
                            {
                                newmatrix.array[q, h] = array[i, j];
                                if (h == newmatrix.columns - 1)
                                {
                                    h = 0;
                                    q++;
                                }
                                else
                                {
                                    h++;
                                }
                            }
                        }
                    }
                    cofactor += Math.Pow(-1, r + c) * newmatrix.Determinant_Laplace();
                }
                return cofactor;
            }
            else
            {
                throw new ArithmeticException("Введена матриця не є квадратною!");
            }
        }

        //Обчислення оберненої матриці за допомогою еквівалентних перетворень рядків

        Matrix Get_Inversed_Matrix_By_Equivalent_Changes()
        {
            if (rows == columns)
            {
                double determinant = Determinant_Laplace();
                if (determinant != 0)
                {
                    Matrix newmatrix = new Matrix(rows, columns * 2, "empty");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            newmatrix.array[i, j] = array[i, j];
                        }
                    }
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = columns; j < newmatrix.columns; j++)
                        {
                            if (j - i == rows)
                            {
                                newmatrix.array[i, j] = 1;
                            }
                        }
                    }
                    for (int k = 0; k < rows - 1; k++)
                    {
                        for (int i = k + 1; i < rows; i++)
                        {
                            for (i = k + 1; i < rows; i++)
                            {
                                double temp = newmatrix.array[i, k] / newmatrix.array[k, k];
                                for (int j = 0; j < newmatrix.columns; j++)
                                {
                                    newmatrix.array[i, j] = newmatrix.array[i, j] - temp * newmatrix.array[k, j];
                                }
                            }
                        }
                    }
                    for (int k = rows - 1; k > 0; k--)
                    {
                        for (int i = k - 1; i > -1; i--)
                        {
                            for (i = k - 1; i > -1; i--)
                            {
                                double temp = newmatrix.array[i, k] / newmatrix.array[k, k];
                                for (int j = newmatrix.columns - 1; j > -1; j--)
                                {
                                    newmatrix.array[i, j] = newmatrix.array[i, j] - temp * newmatrix.array[k, j];
                                }
                            }
                        }
                    }
                    for (int i = 0; i < rows; i++)
                    {
                        double temp = newmatrix.array[i, i];
                        for (int j = 0; j < newmatrix.columns; j++)
                        {
                            newmatrix.array[i, j] = newmatrix.array[i, j] / temp;
                        }
                    }
                    Matrix result = new Matrix(rows, columns, "empty");
                    for (int i = 0; i < rows; i++)
                    {
                        double temp = newmatrix.array[i, i];
                        for (int j = 0; j < newmatrix.columns; j++)
                        {
                            newmatrix.array[i, j] = newmatrix.array[i, j] / temp;
                        }
                    }
                    for (int i = 0, j = 0; i < rows; i++, j++)
                    {
                        for (int m = 0, n = columns; m < columns; m++, n++)
                        {
                            result.array[i, m] = newmatrix.array[j, n];
                        }
                    }
                    return result;
                }
                else
                {
                    throw new ArithmeticException("Детермінант матриці дорівнює нулеві. Оберненої матриці не існує!");
                }
            }
            else
            {
                throw new ArithmeticException("Введена матриця не є квадратною!");
            }
        }

        //Визначення рангу матриці (максимальний з розмірів не перевищує 6) методом обвідних мінорів

        int Get_The_Rank_By_Bypass_Minors()
        {
            Matrix newmatrix = this;
            int rank = 0;
        label:
            for (int i = rank; i < rows; i++)
            {
                for (int j = rank; j < columns; j++)
                {
                    if (newmatrix.Get_The_Minors(rank, i, j) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        newmatrix = Matrix.Permutate_Rows(Matrix.Permutate_Columns(this, rank, j), rank, i);
                        rank++;
                        goto label;
                    }
                }
            }
            return rank;
        }

        double Get_The_Minors(int current_rank, int r, int c)
        {
            if (current_rank == 0)
            {
                return array[r, c];
            }
            else
            {
                Matrix newmatrix = new Matrix(current_rank + 1, current_rank + 1, "empty");
                for (int i = 0; i < current_rank; i++)
                {
                    for (int j = 0; j < current_rank; j++)
                    {
                        newmatrix.array[i, j] = array[i, j];
                    }
                }
                for (int i = 0; i < current_rank; i++)
                {
                    newmatrix.array[current_rank, i] = array[r, i];
                    newmatrix.array[i, current_rank] = array[i, c];
                }
                newmatrix.array[current_rank, current_rank] = array[r, c];
                return newmatrix.Determinant_Laplace();
            }
        }

        static Matrix Permutate_Rows(Matrix matrix, int r1, int r2)
        {
            Matrix newmatrix = new Matrix(matrix.rows, matrix.columns, "empty");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < matrix.columns; j++)
                {
                    newmatrix.array[i, j] = matrix.array[i, j];
                }
            }
            for (int i = 0; i < matrix.columns; i++)
            {
                newmatrix.array[r1, i] = matrix.array[r2, i];
                newmatrix.array[r2, i] = matrix.array[r1, i];
            }
            for (int i = r1 + 1; i < matrix.rows; i++)
            {
                if (i != r2)
                {
                    for (int j = 0; j < matrix.columns; j++)
                    {
                        newmatrix.array[i, j] = matrix.array[i, j];
                    }
                }
            }
            return newmatrix;
        }

        static Matrix Permutate_Columns(Matrix matrix, int c1, int c2)
        {
            Matrix newmatrix = new Matrix(matrix.rows, matrix.columns, "empty");
            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < matrix.rows; j++)
                {
                    newmatrix.array[j, i] = matrix.array[j, i];
                }
            }
            for (int i = 0; i < matrix.rows; i++)
            {
                newmatrix.array[i, c1] = matrix.array[i, c2];
                newmatrix.array[i, c2] = matrix.array[i, c1];
            }
            for (int i = c1 + 1; i < matrix.columns; i++)
            {
                if (i != c2)
                {
                    for (int j = 0; j < matrix.rows; j++)
                    {
                        newmatrix.array[j, i] = matrix.array[j, i];
                    }
                }
            }
            return newmatrix;
        }

        //Визначення рангу матриці за допомогою зведення до трапецевидної форми

        int Get_The_Rank_By_Trapezoidal_Form()
        {
            int rank = 0;
            Rational[,] rational_array = new Rational[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rational_array[i, j] = new Rational(0, 1, (int)array[i, j]);
                }
            }
            for (int i = 0; i < rational_array.GetLength(0) - 1; i++)
            {
                Rational diagonal_element = rational_array[i, i];
                if (diagonal_element != 0)
                {
                    for (int j = i + 1; j < rational_array.GetLength(0); j++)
                    {
                        if (rational_array[j, i] != 0)
                        {
                            Rational temp = rational_array[j, i] / diagonal_element * (-1);
                            for (int k = i; k < rational_array.GetLength(1); k++)
                            {
                                rational_array[j, k] += rational_array[i, k] * temp;
                            }
                        }
                    }
                }
            }
            Rational[,] cut = Matrix.Get_Similar_Rows(rational_array);
            for (int i = 0; i < cut.GetLength(0); i++)
            {
                int counter = 0;
                for (int j = 0; j < cut.GetLength(1); j++)
                {
                    if (cut[i, j] == 0)
                    {
                        counter++;
                    }
                }
                if (counter != cut.GetLength(1))
                {
                    rank++;
                }
            }
            return rank;
        }

        static Rational[,] Get_Similar_Rows(Rational[,] rational_array)
        {
            if (rational_array.GetLength(0) == 1)
            {
                return rational_array;
            }
            else
            {
                int i = 0;
            label:
                for (; i < rational_array.GetLength(0) - 1; i++)
                {
                    Rational temp = new Rational(0, 1);
                    int j;
                    for (j = 0; j < rational_array.GetLength(1); j++)
                    {
                        if (rational_array[i, j] == 0 && rational_array[i + 1, j] != 0)
                        {
                            i++;
                            goto label;
                        }
                        else if (rational_array[i + 1, j] == 0 && rational_array[i, j] != 0)
                        {
                            i++;
                            goto label;
                        }
                        else if (rational_array[i + 1, j] == 0 && rational_array[i, j] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            temp = rational_array[i, j] / rational_array[i + 1, j];
                            break;
                        }
                    }
                    int counter = j;
                    for (int k = j; k < rational_array.GetLength(1); k++)
                    {
                        if (rational_array[i, k] / temp == rational_array[i + 1, k])
                        {
                            counter++;
                        }
                    }
                    if (counter == rational_array.GetLength(1))
                    {
                        break;
                    }
                }
                if (i == rational_array.GetLength(0) - 1)
                {
                    return rational_array;
                }
                else
                {
                    Rational[,] cut = new Rational[rational_array.GetLength(0) - 1, rational_array.GetLength(1)];
                    int count = 0;
                    for (int j = 0; j < rational_array.GetLength(0); j++)
                    {
                        if (j == i)
                        {
                            count++;
                        }
                        else
                        {
                            for (int k = 0; k < rational_array.GetLength(1); k++)
                            {
                                cut[j - count, k] = rational_array[j, k];
                            }
                        }
                    }
                    return Matrix.Get_Similar_Rows(cut);
                }
            }
        }

        static Rational[,] Get_Null_Rows(Rational[,] rational_array)
        {
            if (rational_array.GetLength(0) == 1)
            {
                return rational_array;
            }
            else
            {
                for (int i = 0; i < rational_array.GetLength(0); i++)
                {
                    bool flag = false;
                    for (int j = 0; j < rational_array.GetLength(1); j++)
                    {
                        if (rational_array[i, j] != 0)
                        {
                            flag = true;
                        }
                    }
                    if (flag == true)
                    {
                        continue;
                    }
                    else
                    {
                        Rational[,] newrational = new Rational[rational_array.GetLength(0) - 1, rational_array.GetLength(1)];
                        for (int m = 0; m < rational_array.GetLength(0); m++)
                        {
                            for (int n = 0; n < rational_array.GetLength(1); n++)
                            {
                                if (m == i)
                                {
                                    continue;
                                }
                                else
                                {
                                    newrational[m, n] = rational_array[m, n];
                                }
                            }
                        }
                        return newrational;
                    }
                }
            }
            return rational_array;
        }

        public Matrix Get_Similar_Rows()
        {
            if (rows == 1)
            {
                return this;
            }
            else
            {
                int i;
                for (i = 0; i < rows - 1; i++)
                {
                    double temp = 0;
                    int j;
                    for (j = 0; j < columns; j++)
                    {
                        if (array[i, j] == 0 || array[i + 1, j] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            temp = array[i, j] / array[i + 1, j];
                            break;
                        }
                    }
                    int counter = j + 1;
                    for (int k = j + 1; k < columns; k++)
                    {
                        if (array[i, k] / temp == array[i + 1, k])
                        {
                            counter++;
                        }
                    }
                    if (counter == columns)
                    {
                        break;
                    }
                }
                if (i == rows - 1)
                {
                    return this;
                }
                else
                {
                    Matrix cut = new Matrix(rows - 1, columns, "empty");
                    int count = 0;
                    for (int j = 0; j < rows; j++)
                    {
                        if (j == i)
                        {
                            count++;
                        }
                        else
                        {
                            for (int k = 0; k < cut.columns; k++)
                            {
                                cut.array[j - count, k] = array[j, k];
                            }
                        }
                    }
                    return cut.Get_Similar_Rows();
                }
            }
        }

        //Розв’язання СЛАР за теоремою Крамера

        double[] Cramer()
        {
            double[] determinants = new double[rows];
            double[] free_coeffs = new double[rows];
            double[] result = new double[rows];
            Matrix general = new Matrix(rows, columns - 1, "empty");
            double general_determinant = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    general.array[i, j] = array[i, j];
                }
            }
            general_determinant = general.Determinant_Laplace();
            for (int i = 0; i < rows; i++)
            {
                free_coeffs[i] = array[i, rows];
            }
            int h = 0;
            for (int i = 0; i < rows; i++)
            {
                Matrix temp = new Matrix(rows, columns - 1, "empty");
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < rows; k++)
                    {
                        if (h == j)
                        {
                            temp.array[k, h] = free_coeffs[k];
                        }
                        else
                        {
                            temp.array[k, j] = array[k, j];
                        }
                    }
                }
                h++;
                determinants[i] = temp.Determinant_Laplace();
            }
            if (general_determinant != 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    result[i] = determinants[i] / general_determinant;
                }
                return result;
            }
            else
            {
                bool flag = false;
                for (int i = 0; i < rows; i++)
                {
                    if (determinants[i] != 0)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    throw new ArithmeticException("Задана система лінійних алгебраїчних рівнянь є несумісною (коренів немає)");
                }
                else
                {
                    throw new ArithmeticException("Задана система лінійних алгебраїчних рівнянь є невизначеною (має безліч розв'язків)");
                }
            }
        }

        //Розв’язання СЛАР методом Жордана-Гаусса

        double[] Jordan_Gauss()
        {
            if (rows + 1 == columns)
            {
                double[] result = new double[rows];
                Matrix newmatrix = new Matrix(rows, columns, "empty");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        newmatrix.array[i, j] = array[i, j];
                    }
                }
                for (int k = 0; k < rows - 1; k++)
                {
                    for (int i = k + 1; i < rows; i++)
                    {
                        for (i = k + 1; i < rows; i++)
                        {
                            double temp = newmatrix.array[i, k] / newmatrix.array[k, k];
                            for (int j = 0; j < columns; j++)
                            {
                                newmatrix.array[i, j] = newmatrix.array[i, j] - temp * newmatrix.array[k, j];
                            }
                        }
                    }
                }
                for (int k = rows - 1; k > 0; k--)
                {
                    for (int i = k - 1; i > -1; i--)
                    {
                        for (i = k - 1; i > -1; i--)
                        {
                            double temp = newmatrix.array[i, k] / newmatrix.array[k, k];
                            for (int j = columns - 1; j > -1; j--)
                            {
                                newmatrix.array[i, j] = newmatrix.array[i, j] - temp * newmatrix.array[k, j];
                            }
                        }
                    }
                }
                for (int i = 0; i < rows; i++)
                {
                    double temp = newmatrix.array[i, i];
                    for (int j = 0; j < columns; j++)
                    {
                        newmatrix.array[i, j] = newmatrix.array[i, j] / temp;
                    }
                }
                for (int i = 0; i < rows; i++)
                {
                    result[i] = newmatrix.array[i, columns - 1];
                }
                return result;
            }
            else
            {
                throw new ArithmeticException("Розміри введеної матриці не відповідають вимогам задачі!");
            }
        }

        //Розв’язання СЛАР матричним методом

        static double[] Matrix_Method(Matrix ob1, Matrix ob2)
        {
            if (ob1.rows == ob1.columns && ob2.rows == ob1.rows && ob2.columns == 1)
            {
                double determinant = ob1.Determinant_Laplace();
                if (determinant != 0)
                {
                    Matrix ob1_transpose = new Matrix(ob1.rows, ob1.columns, "empty");
                    Matrix temp = new Matrix(ob2.rows, ob2.columns, "empty");
                    double[] result = new double[ob2.rows];
                    ob1_transpose = ob1.Get_Inversed_Matrix_By_Equivalent_Changes();
                    temp = ob1_transpose * ob2;
                    for (int i = 0; i < ob1.rows; i++)
                    {
                        result[i] = temp.array[i, 0];
                    }
                    return result;
                }
                else
                {
                    throw new ArithmeticException("Детермінант матриці дорівнює нулеві. Оберненої матриці не існує!");
                }
            }
            else
            {
                throw new ArithmeticException("Розміри введеної матриці не відповідають вимогам задачі!");
            }
        }

        //Побудова фундаментальної системи розв’язків однорідної СЛАР

        Rational[,] Get_Fundamental_System()
        {
            int rank = 0;
            Rational[,] rational_array = new Rational[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rational_array[i, j] = new Rational(0, 1, (int)array[i, j]);
                }
            }
            for (int i = 0; i < rational_array.GetLength(0) - 1; i++)
            {
                Rational diagonal_element = rational_array[i, i];
                if (diagonal_element != 0)
                {
                    for (int j = i + 1; j < rational_array.GetLength(0); j++)
                    {
                        if (rational_array[j, i] != 0)
                        {
                            Rational temp = rational_array[j, i] / diagonal_element * (-1);
                            for (int k = i; k < rational_array.GetLength(1); k++)
                            {
                                rational_array[j, k] += rational_array[i, k] * temp;
                            }
                        }
                    }
                }
            }
            Rational[,] cut = Get_Similar_Rows(rational_array);
            cut = Get_Null_Rows(cut);
            for (int i = 0; i < cut.GetLength(0); i++)
            {
                int counter = 0;
                for (int j = 0; j < cut.GetLength(1); j++)
                {
                    if (cut[i, j] == 0)
                    {
                        counter++;
                    }
                }
                if (counter != cut.GetLength(1))
                {
                    rank++;
                }
            }
            for (int k = 0; k < cut.GetLength(0) - 1; k++)
            {
                for (int i = k + 1; i < cut.GetLength(0); i++)
                {
                    for (i = k + 1; i < cut.GetLength(0); i++)
                    {
                        Rational temp = cut[i, k] / cut[k, k];
                        for (int j = 0; j < cut.GetLength(1); j++)
                        {
                            cut[i, j] = cut[i, j] - temp * cut[k, j];
                        }
                    }
                }
            }
            for (int k = cut.GetLength(0) - 1; k > 0; k--)
            {
                for (int i = k - 1; i > -1; i--)
                {
                    for (i = k - 1; i > -1; i--)
                    {
                        Rational temp = cut[i, k] / cut[k, k];
                        for (int j = cut.GetLength(1) - 1; j > -1; j--)
                        {
                            cut[i, j] = cut[i, j] - temp * cut[k, j];
                        }
                    }
                }
            }
            for (int i = 0; i < cut.GetLength(0); i++)
            {
                Rational temp = cut[i, i];
                for (int j = 0; j < cut.GetLength(1); j++)
                {
                    cut[i, j] = cut[i, j] / temp;
                }
            }
            Rational[,] result = new Rational[cut.GetLength(0), cut.GetLength(1) - rank];
            for (int i = cut.GetLength(1) - 1; i > rank - 1; i--)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < cut.GetLength(1) - 1; k++)
                    {
                        result[k, j] = cut[k, i];
                    }
                }
            }
            return result;
        }

        //Знаходження загального розв’язку неоднорідної СЛАР

        Rational[,] Get_General_Solution()
        {
            Rational[,] fundamental_system = Get_Fundamental_System_For_General_Solution();

            int rank = 0;
            Rational[,] rational_array = new Rational[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rational_array[i, j] = new Rational(0, 1, (int)array[i, j]);
                }
            }
            for (int i = 0; i < rational_array.GetLength(0) - 1; i++)
            {
                Rational diagonal_element = rational_array[i, i];
                if (diagonal_element != 0)
                {
                    for (int j = i + 1; j < rational_array.GetLength(0); j++)
                    {
                        if (rational_array[j, i] != 0)
                        {
                            Rational temp = rational_array[j, i] / diagonal_element * (-1);
                            for (int k = i; k < rational_array.GetLength(1); k++)
                            {
                                rational_array[j, k] += rational_array[i, k] * temp;
                            }
                        }
                    }
                }
            }
            Rational[,] cut = Get_Similar_Rows(rational_array);
            cut = Get_Null_Rows(cut);
            for (int i = 0; i < cut.GetLength(0); i++)
            {
                int counter = 0;
                for (int j = 0; j < cut.GetLength(1); j++)
                {
                    if (cut[i, j] == 0)
                    {
                        counter++;
                    }
                }
                if (counter != cut.GetLength(1))
                {
                    rank++;
                }
            }
            for (int k = 0; k < cut.GetLength(0) - 1; k++)
            {
                for (int i = k + 1; i < cut.GetLength(0); i++)
                {
                    for (i = k + 1; i < cut.GetLength(0); i++)
                    {
                        Rational temp = cut[i, k] / cut[k, k];
                        for (int j = 0; j < cut.GetLength(1); j++)
                        {
                            cut[i, j] = cut[i, j] - temp * cut[k, j];
                        }
                    }
                }
            }
            for (int k = cut.GetLength(0) - 1; k > 0; k--)
            {
                for (int i = k - 1; i > -1; i--)
                {
                    for (i = k - 1; i > -1; i--)
                    {
                        Rational temp = cut[i, k] / cut[k, k];
                        for (int j = cut.GetLength(1) - 1; j > -1; j--)
                        {
                            cut[i, j] = cut[i, j] - temp * cut[k, j];
                        }
                    }
                }
            }
            for (int i = 0; i < cut.GetLength(0); i++)
            {
                Rational temp = cut[i, i];
                for (int j = 0; j < cut.GetLength(1); j++)
                {
                    cut[i, j] = cut[i, j] / temp;
                }
            }
            Rational[,] result = new Rational[cut.GetLength(0), 1];
            for (int i = 0; i < cut.GetLength(0); i++)
            {
                result[i, 0] = cut[i, cut.GetLength(1) - 1];
            }
            return result;
        }

        Rational[,] Get_Fundamental_System_For_General_Solution()
        {
            int rank = 0;
            Rational[,] rational_array = new Rational[rows, columns - 1];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns - 1; j++)
                {
                    rational_array[i, j] = new Rational(0, 1, (int)array[i, j]);
                }
            }
            for (int i = 0; i < rational_array.GetLength(0) - 1; i++)
            {
                Rational diagonal_element = rational_array[i, i];
                if (diagonal_element != 0)
                {
                    for (int j = i + 1; j < rational_array.GetLength(0); j++)
                    {
                        if (rational_array[j, i] != 0)
                        {
                            Rational temp = rational_array[j, i] / diagonal_element * (-1);
                            for (int k = i; k < rational_array.GetLength(1); k++)
                            {
                                rational_array[j, k] += rational_array[i, k] * temp;
                            }
                        }
                    }
                }
            }
            Rational[,] cut = Get_Similar_Rows(rational_array);
            cut = Get_Null_Rows(cut);
            for (int i = 0; i < cut.GetLength(0); i++)
            {
                int counter = 0;
                for (int j = 0; j < cut.GetLength(1); j++)
                {
                    if (cut[i, j] == 0)
                    {
                        counter++;
                    }
                }
                if (counter != cut.GetLength(1))
                {
                    rank++;
                }
            }
            for (int k = 0; k < cut.GetLength(0) - 1; k++)
            {
                for (int i = k + 1; i < cut.GetLength(0); i++)
                {
                    for (i = k + 1; i < cut.GetLength(0); i++)
                    {
                        Rational temp = cut[i, k] / cut[k, k];
                        for (int j = 0; j < cut.GetLength(1); j++)
                        {
                            cut[i, j] = cut[i, j] - temp * cut[k, j];
                        }
                    }
                }
            }
            for (int k = cut.GetLength(0) - 1; k > 0; k--)
            {
                for (int i = k - 1; i > -1; i--)
                {
                    for (i = k - 1; i > -1; i--)
                    {
                        Rational temp = cut[i, k] / cut[k, k];
                        for (int j = cut.GetLength(1) - 1; j > -1; j--)
                        {
                            cut[i, j] = cut[i, j] - temp * cut[k, j];
                        }
                    }
                }
            }
            for (int i = 0; i < cut.GetLength(0); i++)
            {
                Rational temp = cut[i, i];
                for (int j = 0; j < cut.GetLength(1); j++)
                {
                    cut[i, j] = cut[i, j] / temp;
                }
            }
            return cut;
        }

        //За допомогою визначника Грама з’ясувати, чи є задана система векторів, що задані своїми координатами в отронормованому базисі, лінійно залежною

        public bool Gram_Determinant()
        {
            int size = rows;
            Matrix new_matrix = new Matrix(size, size, "empty");
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        new_matrix.array[i, j] += array[i, k] * array[j, k];
                    }
                }
            }

            if (new_matrix.Determinant_Laplace() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Виходячи з заданого базису евклідового простору та використовуючи процес ортогоналізації, побудувати ортонормований базис за заданою матрицею Грама

        public string Ortonormalized_Gram_Basis()
        {
            int size = columns;

            string result = "";
            string vector1 = "e1";
            string vector2 = "";
            string vector3 = "";
            string vector4 = "";

            Rational alpha1 = new Rational();
            Rational alpha2 = new Rational();
            Rational alpha3 = new Rational();
            Rational beta2 = new Rational();
            Rational beta3 = new Rational();
            Rational gamma3 = new Rational();
            
            Rational e11 = new Rational(),
                     e12 = new Rational(), 
                     e13 = new Rational(), 
                     e14 = new Rational(), 
                     e22 = new Rational(), 
                     e23 = new Rational(), 
                     e24 = new Rational(), 
                     e33 = new Rational(), 
                     e34 = new Rational();

            if (size == 2)
            {
                e11 = new Rational(0, 1, (int)array[0, 0]);
                e12 = new Rational(0, 1, (int)array[0, 1]);
                e22 = new Rational(0, 1, (int)array[1, 1]);
            }

            if (size == 3)
            {
                e11 = new Rational(0, 1, (int)array[0, 0]);
                e12 = new Rational(0, 1, (int)array[0, 1]);
                e13 = new Rational(0, 1, (int)array[0, 2]);
                e22 = new Rational(0, 1, (int)array[1, 1]);
                e23 = new Rational(0, 1, (int)array[1, 2]);
                e33 = new Rational(0, 1, (int)array[2, 2]);
            }

            if (size == 4)
            {
                e11 = new Rational(0, 1, (int)array[0, 0]);
                e12 = new Rational(0, 1, (int)array[0, 1]);
                e13 = new Rational(0, 1, (int)array[0, 2]);
                e14 = new Rational(0, 1, (int)array[0, 3]);
                e22 = new Rational(0, 1, (int)array[1, 1]);
                e23 = new Rational(0, 1, (int)array[1, 2]);
                e24 = new Rational(0, 1, (int)array[1, 3]);
                e33 = new Rational(0, 1, (int)array[2, 2]);
                e34 = new Rational(0, 1, (int)array[2, 3]);
            }

            alpha1 = e12 / e11 * (-1);
            vector2 = string.Format("e2 {0}{1}*e1", alpha1 > 0 ? "+ " : "", alpha1);
            result = string.Format("{0}; {1}", vector1, vector2);

            if (size == 2)
            {
                return result;
            }

            alpha2 = e13 / e11 * (-1);
            beta2 = ((-1) * (e23 + alpha1 * e13)) / (e22 + 2 * alpha1 * e12 + alpha1 * alpha1 * e11);
            Rational Prom = alpha2 + alpha1 * beta2;
            vector3 = string.Format("e3 {0}{1}*e1 {2}{3}*e2", Prom > 0 ? "+ " : "", Prom, beta2 > 0 ? "+ " : "", beta2);
            result += string.Format("; {0}", vector3);

            if (size == 3)
            {
                return result;
            }

            alpha3 = e14 * e11 * (-1);
            beta3 = ((-1) * (e24 + alpha1 * e14)) / (e22 + 2 * alpha1 * e12 + alpha1 * alpha1 * e11);
            gamma3 = ((-1) * (e34 + Prom * e14 + beta2 * e24)) / (e33 + 2 * Prom * e13 + 2 * beta2 * e23 + Prom * Prom * e11 + 2 * Prom * beta2 * e12 + beta2 * beta2 * e22);
            Rational Prom1 = alpha3 + beta3 * alpha1 + gamma3;
            Rational Prom2 = beta3 + gamma3 * beta2;
            vector4 = string.Format("e4 {0}{1}*e1 {2}{3}*e2 {4}{5}*e3", Prom1 > 0 ? "+ " : "", Prom1, Prom2 > 0 ? "+ " : "", Prom2, gamma3 > 0 ? "+ " : "", gamma3);
            result += string.Format("; {0}", vector4);

            if (size == 4)
            {
                return result;
            }
            
            return "";
        }

        //Побудова ортонормованого базису простору, що породжений заданою системою векторів (з застосуванням процесу ортогоналізації)

        delegate int f4(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4);

        public double[,] Ortonormalized_Basis_System()
        {
            f4 formula = (x1, x2, x3, x4, y1, y2, y3, y4) => 2 * x1 * y1 - 5 * x2 * y2 + x1 * y4 + x4 * y1 - y2 * x4 - y4 * x2;
            Matrix gram = new Matrix(4, 4, "empty");

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    gram.array[i, j] = formula((int)array[i, 0], (int)array[i, 1], (int)array[i, 2], (int)array[i, 3], (int)array[j, 0], (int)array[j, 1], (int)array[j, 2], (int)array[j, 3]);
                }
            }

            double a11 = array[0, 0];
            double a12 = array[0, 1];
            double a13 = array[0, 2];
            double a14 = array[0, 3];
            double a22 = array[1, 1];
            double a23 = array[1, 2];
            double a24 = array[1, 3];
            double a33 = array[2, 2];
            double a34 = array[2, 3];

            double alpha1 = a12 / a11 * (-1);
            double alpha2 = a13 / a11 * (-1);
            double beta2 = ((-1) * (a23 + alpha1 * a13)) / (a22 + 2 * alpha1 * a12 + alpha1 * alpha1 * a11);
            double prom = alpha2 + alpha1 * beta2;
            double alpha3 = a14 * a11 * (-1);
            double beta3 = ((-1) * (a24 + alpha1 * a14)) / (a22 + 2 * alpha1 * a12 + alpha1 * alpha1 * a11);
            double gamma3 = ((-1) * (a34 + prom * a14 + beta2 * a24)) / (a33 + 2 * prom * a13 + 2 * beta2 * a23 + prom * prom * a11 + 2 * prom * beta2 * a12 + beta2 * beta2 * a22);
            double prom1 = alpha3 + beta3 * alpha1 + gamma3;
            double prom2 = beta3 + gamma3 * beta2;
            double[,] result = new double[4, 4];
            double c1 = 0, c2 = 0, c3 = 0, c4 = 0;

            for (int i = 0; i < 4; ++i)
            {
                result[0, i] = array[0, i];
                c1 += Math.Pow(result[0, i], 2);
                result[1, i] = array[1, i] + alpha1 * array[0, i];
                c2 += Math.Pow(result[1, i], 2);
                result[2, i] = array[2, i] + prom * array[0, i] + beta2 * array[1, i];
                c3 += Math.Pow(result[2, i], 2);
                result[3, i] = array[3, i] + prom1 * array[0, i] + prom2 * array[1, i] + gamma3 * array[2, i];
                c4 += Math.Pow(result[3, i], 2);
            }

            c1 = Math.Sqrt(c1);
            c2 = Math.Sqrt(c2);
            c3 = Math.Sqrt(c3);
            c4 = Math.Sqrt(c4);

            for (int i = 0; i < 4; ++i)
            {
                result[0, i] /= c1;
                result[1, i] /= c2;
                result[2, i] /= c3;
                result[3, i] /= c4;
            }

            return result;
        }

        //Знаходження базису ортогонального доповнення підпростору, що породжений заданою системою векторів

        public double[,] Ortohonalized_Addition()
        {
            double[,] result = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = array[i, j];
                }
            }

            for (int i = 0; i < result.GetLength(0) - 1; i++)
            {
                double element = result[i, i];

                for (int j = i + 1; j < result.GetLength(0); j++)
                {
                    if (result[j, i] != 0)
                    {
                        double MN = -(result[j, i] / element);

                        for (int k = i; k < result.GetLength(1); k++)
                        {
                            result[j, k] += result[i, k] * MN;
                        }
                    }
                }
            }
            
            for (int i = 0; i < result.GetLength(0); i++)
            {
                if (result[i, i] != 1)
                {
                    double divider = result[i, i];
                    
                    for (int j = i; j < result.GetLength(1); j++)
                    {
                        result[i, j] /= divider;
                    }
                }
            }
            
            for (int i = result.GetLength(0) - 1; i > 0; i--)
            {
                double element = result[i, i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (result[j, i] != 0)
                    {
                        double MN = -(result[j, i] / element);

                        for (int k = i; k < result.GetLength(1); k++)
                        {
                            result[j, k] += result[i, k] * MN;
                        }
                    }
                }
            }

            double[,] FSR = new double[columns, result.GetLength(1) - result.GetLength(0)];

            for (int i = result.GetLength(0); i < result.GetLength(1); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    FSR[j, i - result.GetLength(0)] = result[j, i] * (-1);
                }

                for (int t = result.GetLength(0); t < FSR.GetLength(0); t++)
                {
                    if (t == i)
                    {
                        FSR[t, i - result.GetLength(0)] = 1;
                    }
                    else
                    {
                        FSR[t, i - result.GetLength(0)] = 0;
                    }
                }
            }
            
            return FSR;
        }

        //Знаходження векторів, що доповнюють задану систему векторів до ортонормованого базису  4-вимірного простору

        public double[,] Four_Dimensioned_Basis()
        {
            double[,] result = new double[4, 4];
            double c1 = 0, c2 = 0, c3 = 0, c4 = 0;

            for (int i = 0; i < 4; ++i)
            {
                c1 += Math.Pow(array[0, i], 2);
                c2 += Math.Pow(array[1, i], 2);
            }

            c1 = Math.Sqrt(c1);
            c2 = Math.Sqrt(c2);
            double[,] system1 = new double[2, 4];
            double[,] system2 = new double[3, 4];

            for (int i = 0; i < 4; ++i)
            {
                result[0, i] = array[0, i] / c1;
                system1[0, i] = result[0, i];
                system2[0, i] = result[0, i];
                result[1, i] = array[1, i] / c2;
                system1[1, i] = result[1, i];
                system2[1, i] = result[1, i];
            }

            double[] vector3 = Matrix.OSLAR_OneVector(system1);

            for (int i = 0; i < 4; ++i)
            {
                c3 += Math.Pow(vector3[i], 2);
            }

            c3 = Math.Sqrt(c3);

            for (int i = 0; i < 4; ++i)
            {
                result[2, i] = vector3[i] / c3;
                system2[2, i] = result[2, i];
            }

            double[] vector4 = Matrix.OSLAR_OneVector(system2);

            for (int i = 0; i < 4; ++i)
            {
                c4 += Math.Pow(vector4[i], 2);
            }

            c4 = Math.Sqrt(c4);

            for (int i = 0; i < 4; ++i)
            {
                result[3, i] = vector4[i] / c4;
            }

            return result;
        }

        static public double[] OSLAR_OneVector(double[,] system)
        {
            double[,] result = new double[system.GetLength(0), system.GetLength(1)];

            for (int i = 0; i < system.GetLength(0); i++)
            {
                for (int j = 0; j < system.GetLength(1); j++)
                {
                    result[i, j] = system[i, j];
                }
            }

            for (int i = 0; i < result.GetLength(0) - 1; i++)
            {
                double element = result[i, i];

                for (int j = i + 1; j < result.GetLength(0); j++)
                {
                    if (result[j, i] != 0)
                    {
                        double MN = -(result[j, i] / element);

                        for (int k = i; k < result.GetLength(1); k++)
                        {
                            result[j, k] += result[i, k] * MN;
                        }
                    }
                }
            }

            for (int i = 0; i < result.GetLength(0); i++)
            {
                if (result[i, i] != 1)
                {
                    double divider = result[i, i];

                    for (int j = i; j < result.GetLength(1); j++)
                    {
                        result[i, j] /= divider;
                    }
                }
            }

            for (int i = result.GetLength(0) - 1; i > 0; i--)
            {
                double element = result[i, i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (result[j, i] != 0)
                    {
                        double MN = -(result[j, i] / element);

                        for (int k = i; k < result.GetLength(1); k++)
                        {
                            result[j, k] += result[i, k] * MN;
                        }
                    }
                }
            }

            double[,] FSR = new double[system.GetLength(1), result.GetLength(1) - result.GetLength(0)];

            for (int i = result.GetLength(0); i < result.GetLength(1); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    FSR[j, i - result.GetLength(0)] = result[j, i] * (-1);
                }

                for (int t = result.GetLength(0); t < FSR.GetLength(0); t++)
                {
                    if (t == i)
                    {
                        FSR[t, i - result.GetLength(0)] = 1;
                    }
                    else
                    {
                        FSR[t, i - result.GetLength(0)] = 0;
                    }
                }
            }

            double[] vector = new double[system.GetLength(1)];

            for (int i = 0; i < system.GetLength(1); ++i)
            {
                vector[i] = FSR[i, 0];
            }

            return vector;
        }

        //Знаходження матриці лінійного оператора, що відображає вектори відповідно у вектори в тому ж базисі, в якому задано координати всіх векторів

        static public Matrix Get_Linear_Operator_Matrix(Matrix a, Matrix b)
        {
            return b.Transpose() * a.Transpose().Get_Inversed_Matrix_By_Theorem();
        }

        //Знаходження матриці лінійного оператора в базисі, якщо вона задана в базисі та відомий зв'язок базисів
        //Лінійний оператор простору має в базисі матрицю. Перевірити, чи система векторів утворює базис та знайти матрицю оператора в цьому базисі, якщо задано зв'язок

        static public Matrix Get_Linear_Operator_Matrix_With_Connection(Matrix a, Matrix system)
        {
            Matrix t = system.Transpose();

            if (t.Determinant_Laplace() == 0)
            {
                return null;
            }
            else
            {
                return t.Get_Inversed_Matrix_By_Theorem() * a * t;
            }
        }

        //Знаходження ядра та образу лінійного оператора

        public void Get_Core_Image()
        {
            Rational[,] coreBasic = OSLAR_FSR();
            
            for (int i = 0; i < coreBasic.GetLength(0); ++i)
            {
                for (int j = 0; j < coreBasic.GetLength(1); ++j)
                {
                    Console.Write(coreBasic[i, j] + " ");
                }

                Console.WriteLine();
            }

            Rational[,] prom = new Rational[rows, columns];

            for (int i = 0; i < prom.GetLength(0); ++i)
            {
                for (int j = 0; j < prom.GetLength(1); ++j)
                {
                    prom[i, j] = Rational.Long_To_Fraction((long)array[i, j]);
                }
            }

            Rational[,] imageBasic = Find_Similar_Rows(prom);

            for (int i = 0; i < imageBasic.GetLength(0); ++i)
            {
                for (int j = 0; j < imageBasic.GetLength(1); ++j)
                {
                    Console.Write(imageBasic[i, j] + " ");
                }
                
                Console.WriteLine();
            }
        }

        public Rational[,] OSLAR_FSR()
        {
            Rational[,] result = new Rational[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Rational.Long_To_Fraction((long)array[i, j]);
                }
            }

            for (int i = 0; i < result.GetLength(0) - 1; i++)
            {
                Rational element = result[i, i];

                for (int j = i + 1; j < result.GetLength(0); j++)
                {
                    if (!(result[j, i].Compare_To_Zero()))
                    {
                        Rational MN = (result[j, i] / element) * (-1);

                        for (int k = i; k < result.GetLength(1); k++)
                        {
                            result[j, k] += result[i, k] * MN;
                        }
                    }

                    result = Find_Similar_Rows(result);
                }
            }

            for (int i = 0; i < result.GetLength(0); i++)
            {
                if (result[i, i] != 1)
                {
                    Rational divider = result[i, i];

                    for (int j = i; j < result.GetLength(1); j++)
                    {
                        result[i, j] /= divider;
                    }
                }
            }

            for (int i = result.GetLength(0) - 1; i > 0; i--)
            {
                Rational element = result[i, i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (!(result[j, i].Compare_To_Zero()))
                    {
                        Rational MN = (result[j, i] / element) * (-1);

                        for (int k = i; k < result.GetLength(1); k++)
                        {
                            result[j, k] += result[i, k] * MN;
                        }
                    }
                    
                    result = Find_Similar_Rows(result);
                }
            }

            Rational[,] FSR = new Rational[columns, result.GetLength(1) - result.GetLength(0)];

            for (int i = result.GetLength(0); i < result.GetLength(1); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    FSR[j, i - result.GetLength(0)] = result[j, i] * (-1);
                }

                for (int t = result.GetLength(0); t < FSR.GetLength(0); t++)
                {
                    if (t == i)
                    {
                        FSR[t, i - result.GetLength(0)] = Rational.Long_To_Fraction(1);
                    }
                    else
                    {
                        FSR[t, i - result.GetLength(0)] = new Rational();
                    }
                }
            }
            
            return FSR;
        }

        public static Rational[,] Find_Similar_Rows(Rational[,] array)
        {
            if (array.GetLength(0) == 1)
            {
                return array;
            }
            else
            {
                int i = 0;

            label:
                
                for (; i < array.GetLength(0) - 1; i++)
                {
                    Rational div = new Rational(0, 1);
                    int j;

                    for (j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j].Compare_To_Zero() && !array[i + 1, j].Compare_To_Zero())
                        {
                            i++;
                            goto label;
                        }
                        else if (array[i + 1, j].Compare_To_Zero() && !array[i, j].Compare_To_Zero())
                        {
                            i++;
                            goto label;
                        }
                        else if (array[i + 1, j].Compare_To_Zero() && array[i, j].Compare_To_Zero())
                        {
                            continue;
                        }
                        else
                        {
                            div = array[i, j] / array[i + 1, j];
                            break;
                        }
                    }

                    int counter = j;

                    for (int k = j; k < array.GetLength(1); k++)
                    {
                        if (array[i, k] / div == array[i + 1, k])
                        {
                            counter++;
                        }
                    }

                    if (counter == array.GetLength(1))
                    {
                        break;
                    }
                }
                
                if (i == array.GetLength(0) - 1)
                {
                    return array;
                }
                
                else
                {
                    Rational[,] cut = new Rational[array.GetLength(0) - 1, array.GetLength(1)];
                    int count = 0;
                    
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        if (j == i)
                        {
                            count++;
                        }
                        else
                        {
                            for (int k = 0; k < array.GetLength(1); k++)
                            {
                                cut[j - count, k] = array[j, k];
                            }
                        }
                }

                return Matrix.Find_Similar_Rows(cut);
            }
            }
        }

        static void Main(string[] args)
        { }
    }

    class VectorSystem
    {
        public Rational[][] matrix;
        public int[] numbersOfVariables;
        public int[] numbersOfVectors;

        public VectorSystem(Rational[][] vectors)
        {
            numbersOfVectors = new int[vectors.Length];
            for (int i = 0; i < vectors.Length; ++i)
                numbersOfVectors[i] = i;

            numbersOfVariables = new int[vectors[0].Length];
            for (int i = 0; i < numbersOfVariables.Length; ++i)
                numbersOfVariables[i] = i;

            matrix = vectors;
        }

        public static VectorSystem Parse(string inputString)
        {
            string[] strings = inputString.Split('\n');
            string[][] input = new string[strings.Length][];

            int length = 0;

            for (int i = 0; i < strings.Length; ++i)
            {
                strings[i] = strings[i].Trim();
                input[i] = strings[i].Split(' ');
                if (length == 0)
                    length = input[i].Length;
            }

            Rational[][] matrix = new Rational[strings.Length][];

            for (int i = 0; i < strings.Length; ++i)
                matrix[i] = new Rational[length];

            for (int i = 0; i < strings.Length; ++i)
                for (int j = 0; j < length; ++j)
                    matrix[i][j] = Rational.Parse(input[i][j]);

            return new VectorSystem(matrix);
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < matrix.Length - 1; ++i)
            {
                for (int j = 0; j < matrix[i].Length - 1; ++j)
                    result += matrix[i][j].ToString() + " ";

                result += matrix[i][matrix[i].Length - 1].ToString() + "\r\n";
            }

            for (int j = 0; j < matrix[matrix.Length - 1].Length - 1; ++j)
                result += matrix[matrix.Length - 1][j].ToString() + " ";

            result += matrix[matrix.Length - 1][matrix[matrix.Length - 1].Length - 1].ToString();

            return result;
        }

        private void RowMinusRow(int deminishing, int subtrahend, Rational coefficient)
        {
            for (int i = 0; i < matrix[deminishing].Length; ++i)
                matrix[deminishing][i] -= matrix[subtrahend][i] * coefficient;
        }

        private void ReplaceRows(int row1, int row2)
        {
            object temp = matrix[row1];
            matrix[row1] = matrix[row2];
            matrix[row2] = (Rational[])temp;

            int tmp = numbersOfVectors[row1];
            numbersOfVectors[row1] = numbersOfVectors[row2];
            numbersOfVectors[row2] = tmp;
        }

        private void ReplaceColumns(int column1, int column2)
        {
            int tmp = numbersOfVariables[column1];
            numbersOfVariables[column1] = numbersOfVariables[column2];
            numbersOfVariables[column2] = tmp;

            for (int i = 0; i < matrix.Length; ++i)
            {
                Rational temp = matrix[i][column1];
                matrix[i][column1] = matrix[i][column2];
                matrix[i][column2] = temp;
            }
        }

        private void SortColumns()
        {
            for (int i = 0; i < numbersOfVariables.Length - 1; ++i)
                for (int j = i + 1; j < numbersOfVariables.Length; ++j)
                    if (numbersOfVariables[i] > numbersOfVariables[j])
                        ReplaceColumns(i, j);
        }

        private void DivideRow(int row, Rational coefficient)
        {
            for (int i = 0; i < matrix[row].Length; ++i)
                if (matrix[row][i] != 0)
                    matrix[row][i] = matrix[row][i] / coefficient;
        }

        public void ToTrapezoidal()
        {
            int row = 0, column = 0;

            while (row < matrix.Length - 1 && column < matrix[row].Length)
            {
                if (matrix[row][column] == 0)
                {
                    int i = 0;
                    for (i = row + 1; i < matrix.Length; ++i)
                        if (matrix[i][column] != 0)
                        {
                            ReplaceRows(row, i);
                            break;
                        }
                    if (i >= matrix.Length)
                    {
                        ++column;
                        continue;
                    }
                }

                for (int i = row + 1; i < matrix.Length; ++i)
                    if (matrix[i][column] != 0)
                    {
                        Rational coefficient = matrix[i][column] / matrix[row][column];
                        RowMinusRow(i, row, coefficient);
                    }

                ++row;
                ++column;
            }
        }

        private int ContainsOneElement(int row)
        {
            for (int i = row + 1; i < matrix[row].Length; ++i)
                if (matrix[row][i] != 0)
                    return i;

            return -1;
        }

        public void ToFundamental()
        {
            ToTrapezoidal();

            for (int i = 0; i < matrix.Length; ++i)
            {
                int pos = ContainsOneElement(i);
                if (pos > -1 && pos != i)
                    ReplaceColumns(i, pos);
            }

            for (int i = 0; i < matrix.Length; ++i)
                if (matrix[i][i] != 1)
                    DivideRow(i, matrix[i][i]);

            for (int i = matrix.Length - 1; i > 0; --i)
                for (int j = i - 1; j >= 0; --j)
                    if (matrix[j][i] != 0)
                    {
                        Rational coefficient = matrix[j][i] / matrix[i][i];
                        RowMinusRow(j, i, coefficient);
                    }

            SortColumns();
        }

        public bool IsZero(int row)
        {
            for (int i = 0; i < matrix[row].Length; ++i)
                if (matrix[row][i] != 0)
                    return false;

            return true;
        }

        private int FirstElement(int row)
        {
            for (int i = row + 1; i < matrix[row].Length; ++i)
                if (matrix[row][i] != 0)
                    return i;

            return -1;
        }

        public VectorSystem TransitionMatrix()
        {
            ToTrapezoidal();
            for (int i = 0; i < matrix.Length; ++i)
                if (matrix[i][i] != 1)
                    DivideRow(i, matrix[i][i]);

            for (int i = matrix.Length - 1; i > 0; --i)
                for (int j = i - 1; j >= 0; --j)
                    if (matrix[j][i] != 0)
                    {
                        Rational coefficient = matrix[j][i] / matrix[i][i];
                        RowMinusRow(j, i, coefficient);
                    }

            Rational[][] m = new Rational[matrix.Length][];
            for (int i = 0; i < matrix.Length; ++i)
                m[i] = new Rational[matrix[i].Length / 2];

            for (int i = 0; i < m.Length; ++i)
                for (int j = 0; j < m[i].Length; ++j)
                    m[i][j] = matrix[i][m.Length + j];

            return new VectorSystem(m);
        }

        public VectorSystem Multiply(Rational[][] system1, Rational[][] system2)
        {
            Rational[][] r = new Rational[system1.Length][];
            for (int i = 0; i < system1.Length; ++i)
                r[i] = new Rational[system2[i].Length];

            for (int i = 0; i < r.Length; ++i)
                for (int j = 0; j < r[i].Length; ++j)
                {
                    r[i][j] = new Rational();

                    for (int k = 0; k < system1[i].Length; ++k)
                        r[i][j] += system1[i][k] * system2[k][j];
                }

            return new VectorSystem(r);
        }

        //Визначення базису та розмірності простору, що є лінійною оболонкою заданої системи векторів

        public string Get_Basis_Dimensions()
        {
            string result = "";
            ToTrapezoidal();

            int dimension = 0;

            for (int i = 0; i < matrix.Length; ++i)
            {
                if (!IsZero(i))
                {
                    ++dimension;
                }
            }

            result += "A dimension of the subspace: " + dimension + "\r\n";
            result += "Basis can be formed by these vectors: ";

            for (int i = 0; i < dimension; ++i)
            {
                result += numbersOfVectors[i] + 1 + ", ";
            }

            return result.Remove(result.Length - 2);
        }

        //Перевірка того, що задана система векторів є базисом простору

        public string Is_Basis()
        {
            ToTrapezoidal();
            int dimensions = 0;

            for (int i = 0; i < matrix.Length; ++i)
            {
                if (!IsZero(i))
                {
                    ++dimensions;
                }
            }

            if (dimensions == 3)
            {
                return string.Format("A given system of the vectors is a basis of the three-dimensional space.");
            }
            else
            {
                return string.Format("A given system of the vectors is not a basis of the three-dimensional space.");
            }
        }

        //Знаходження матриці переходу від базису до базису

        public string Get_Transition_Matrix()
        {
            return TransitionMatrix().ToString();
        }

        //Знаходження координат вектора в заданому базисі, якщо відомі його координати в стандартному базисі

        public string Get_Coordinates()
        {
            Rational[][] basis = new Rational[matrix.Length - 1][];

            for (int i = 0; i < basis.Length; ++i)
            {
                basis[i] = new Rational[matrix[i].Length];
            }

            Rational[][] vector = new Rational[matrix[matrix.Length - 1].Length][];

            for (int i = 0; i < vector.Length; ++i)
            {
                vector[i] = new Rational[1];
            }

            for (int i = 0; i < matrix.Length - 1; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    basis[i][j] = matrix[i][j];
                }
            }

            for (int i = 0; i < vector.Length; ++i)
            {
                vector[i][0] = matrix[matrix.Length - 1][i];
            }

            return Multiply(basis, vector).ToString();
        }

        private bool IsBasic(int column)
        {
            bool only1 = false;

            for (int i = 0; i < matrix.GetLength(0); ++i)
                if (matrix[i][column] != 0 && matrix[i][column] != 1)
                    return false;
                else if (matrix[i][column] == 1 && !only1)
                    only1 = true;
                else if (matrix[i][column] == 1 && only1)
                    return false;

            return true;
        }

        //Знаходження базису суми та перетину лінійних оболонок векторів

        public static string Get_Sum_Cross_Basis(VectorSystem s1, VectorSystem s2)
        {
            string result = "";

            Rational[][] sum = new Rational[s1.matrix.Length + s2.matrix.Length][];
            Rational[][] transposed = new Rational[s1.matrix[0].Length][];

            for (int i = 0; i < sum.Length; ++i)
            {
                sum[i] = new Rational[s1.matrix[0].Length];
            }

            for (int i = 0; i < transposed.Length; ++i)
            {
                transposed[i] = new Rational[s1.matrix.Length + s2.matrix.Length];
            }

            for (int i = 0; i < s1.matrix.Length; ++i)
            {
                for (int j = 0; j < s1.matrix[i].Length; ++j)
                {
                    transposed[j][i] = sum[i][j] = s1.matrix[i][j];
                }
            }

            for (int i = 0; i < s2.matrix.Length; ++i)
            {
                for (int j = 0; j < s2.matrix[i].Length; ++j)
                {
                    transposed[j][i + s1.matrix.Length] = ((sum[i + s1.matrix.Length][j] = s2.matrix[i][j]) * (-1));
                }
            }

            VectorSystem summ = new VectorSystem(sum);
            summ.ToTrapezoidal();

            int dimension = 0;

            for (int i = 0; i < sum.Length; ++i)
            {
                if (!summ.IsZero(i))
                {
                    ++dimension;
                }
            }

            result += "A dimension of the sum of linear vectors shell: " + dimension + "\r\n";
            result += "Basis of a sum can be formed by these vectors: ";

            for (int i = 0; i < dimension; ++i)
            {
                result += summ.numbersOfVectors[i] + 1 + ", ";
            }

            VectorSystem transp = new VectorSystem(transposed);
            transp.ToFundamental();

            for (int i = 0; i < transp.matrix.Length; ++i)
            {
                int pos = transp.FirstElement(i);
                if (pos >= 0)
                {
                    transp.DivideRow(i, transp.matrix[i][pos]);
                }
            }

            for (int i = transp.matrix.Length - 1; i > 0; --i)
            {
                int pos = transp.FirstElement(i);
                if (pos >= 0)
                {
                    for (int j = i - 1; j >= 0; --j)
                    {
                        for (int k = 0; k < transp.matrix.Length; ++k)
                        {
                            transp.matrix[j][k] -= transp.matrix[i][k] * transp.matrix[j][pos] / transp.matrix[i][pos];
                        }
                    }
                }
            }

            int free = 0;

            for (int i = 0; i < transp.matrix[0].Length; ++i)
            {
                if (!transp.IsBasic(i))
                {
                    ++free;
                }
            }

            Rational[][] resultMatrix = new Rational[free][];

            for (int i = 0; i < resultMatrix.Length; ++i)
            {
                resultMatrix[i] = new Rational[transp.matrix[0].Length];
            }

            for (int i = 0; i < free; ++i)
            {
                for (int j = 0; j < transp.matrix[0].Length; ++j)
                {
                    resultMatrix[i][j] = new Rational();
                }
            }

            int lastFree = -1;

            for (int i = 0; i < free; ++i)
            {
                for (int j = lastFree + 1; j < transp.matrix[0].Length; ++j)
                {
                    if (!transp.IsBasic(j))
                    {
                        lastFree = j;
                        break;
                    }
                }
                resultMatrix[i][lastFree] = new Rational(0, 1, 1);
            }

            for (int i = 0; i < free; ++i)
            {
                for (int j = 0; j < transp.matrix[0].Length; ++j)
                {
                    if (transp.IsBasic(j))
                    {
                        for (int k = 0; k < transp.matrix[0].Length; ++k)
                        {
                            if (j != k)
                            {
                                resultMatrix[i][j] -= transp.matrix[i][k] * resultMatrix[i][k];
                            }
                        }
                    }
                }
            }

            result += "\r\nCross vectors:\r\n" + (new VectorSystem(resultMatrix)).ToString();

            return result;
        }
    }
}