using System;
public class Program
{
    public static int binarioADecimal(string numero)
    {
        int sumatoriaResultado = 0;

        int resultadoPotencia;
        for (int i = numero.Length - 1, exp = 0; i >= 0; i--, exp++)
        {
            resultadoPotencia = (int)Math.Pow(2, exp);
            resultadoPotencia *= Convert.ToInt32(numero[i] - '0');
            sumatoriaResultado += resultadoPotencia;
        }
        return sumatoriaResultado;
    }
    public static int octalADecimal(string numero)
    {
        int sumatoriaResultado = 0;

        int resultadoPotencia;
        for (int i = numero.Length - 1, exp = 0; i >= 0; i--, exp++)
        {
            resultadoPotencia = (int)Math.Pow(8, exp);
            resultadoPotencia *= Convert.ToInt32(numero[i] - '0');
            sumatoriaResultado += resultadoPotencia;
        }
        return sumatoriaResultado;
    }
    public static int convertirDeHexadecimalADecimal(int numeroEntero)
    {
        if (numeroEntero == 17)
        {
            numeroEntero = 10;
        }
        else if (numeroEntero == 18)
        {
            numeroEntero = 11;
        }
        else if (numeroEntero == 19)
        {
            numeroEntero = 12;
        }
        else if (numeroEntero == 20)
        {
            numeroEntero = 13;
        }
        else if (numeroEntero == 21)
        {
            numeroEntero = 14;
        }
        else if (numeroEntero == 22)
        {
            numeroEntero = 15;
        }
        else if (numeroEntero > 22)
        {
            return -1;
        }
        return numeroEntero;
    }
    public static int hexadecimalADecimal(string numero)
    {
        int sumatoriaResultado = 0;
        int resultadoPotencia;
        for (int i = numero.Length - 1, exp = 0; i >= 0; i--, exp++)
        {
            resultadoPotencia = (int)Math.Pow(16, exp);
            resultadoPotencia *= convertirDeHexadecimalADecimal(Convert.ToInt32(numero[i] - '0'));
            sumatoriaResultado += resultadoPotencia;
        }
        return sumatoriaResultado;
    }

    public static bool verificar(string numero, int baseSistema)
    {
        if (baseSistema == 2)
        {
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] != '0' && numero[i] != '1')
                {
                    return false;
                }
            }
        }
        if (baseSistema == 8)
        {
            for (int i = 0; i < numero.Length; i++)
            {
                if ((numero[i] - '0') >= 8)
                {
                    return false;
                }
            }
        }
        if (baseSistema == 10)
        {
            for (int i = 0; i < numero.Length; i++)
            {
                if ((numero[i] - '0') >= 9)
                {
                    return false;
                }
            }
        }
        if (baseSistema == 16)
        {
            for (int i = 0; i < numero.Length; i++)
            {
                int auxNumero = convertirDeHexadecimalADecimal(Convert.ToInt32(numero[i] - '0'));
                if (auxNumero == -1)
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static char convertirDeDecimalAHexadecimal(int numeroEntero)
    {
        if (numeroEntero == 10)
        {
            numeroEntero = 'A';
        }
        else if (numeroEntero == 11)
        {
            numeroEntero = 'B';
        }
        else if (numeroEntero == 12)
        {
            numeroEntero = 'C';
        }
        else if (numeroEntero == 13)
        {
            numeroEntero = 'D';
        }
        else if (numeroEntero == 14)
        {
            numeroEntero = 'E';
        }
        else if (numeroEntero == 15)
        {
            numeroEntero = 'F';
        }
        else if (numeroEntero > 15)
        {
            return '-';
        }
        return (char)numeroEntero;
    }

    public static string conversor(string numero, int baseSistema)
    {
        if (baseSistema == 2)
        {
            if (verificar(numero, baseSistema) == true)
            {
                int auxNum1 = binarioADecimal(numero);
                int auxNum2 = binarioADecimal(numero);

                string numOctal = "";
                string numHexadecimal = "";

                for (int i = 0; auxNum1 > 0; i++)
                {
                    numOctal += auxNum1 % 8;
                    auxNum1 /= 8;
                }
                for (int i = 0; auxNum2 > 0; i++)
                {
                    numHexadecimal += convertirDeDecimalAHexadecimal(auxNum2 % 16);
                    auxNum2 /= 16;
                }
                return "Decimal: "+binarioADecimal(numero) + "\n" + "Octal: " + numOctal + "Hexadecimal: " + numHexadecimal;
            }
        }
        if (baseSistema == 8)
        {
            if (verificar(numero, baseSistema) == true)
            {
                int auxNum1 = octalADecimal(numero);
                int auxNum2 = octalADecimal(numero);


                string numBinario = "";
                string numHexadecimal = "";

                for (int i = 0; auxNum1 > 0; i++)
                {
                    numBinario += auxNum1 % 2;
                    auxNum1 /= 2;
                }
                for (int i = 0; auxNum2 > 0; i++)
                {
                    numHexadecimal += convertirDeDecimalAHexadecimal(auxNum2 % 16);
                    auxNum2 /= 16;
                }
                return "Decimal: " + binarioADecimal(numero) + "\n" + "Binario: " + numBinario + "Hexadecimal: " + numHexadecimal;
            }
        }
        if (baseSistema == 10)
        {
            if (verificar(numero, baseSistema) == true)
            {
                int auxNum1 = Convert.ToInt32(numero);
                int auxNum2 = Convert.ToInt32(numero);
                int auxNum3 = Convert.ToInt32(numero);


                string numOctal = "";
                string numBinario = "";
                string numHexadecimal = "";

                for (int i = 0; auxNum1 > 0; i++)
                {
                    numOctal += auxNum1 % 8;
                    auxNum1 /= 8;
                }
                for (int i = 0; auxNum2 > 0; i++)
                {
                    numBinario += auxNum2 % 2; ;
                    auxNum2 /= 2;
                }
                for (int i = 0; auxNum3 > 0; i++)
                {
                    numHexadecimal += convertirDeDecimalAHexadecimal(auxNum2 % 16);
                    auxNum3 /= 16;
                }
                return "Hexadecimal: " + numHexadecimal + "\n" + "Octal: " + numOctal + "binario: " + numBinario;
            }
        }
        if (baseSistema == 16)
        {
            if (verificar(numero, baseSistema) == true)
            {
                int auxNum1 = hexadecimalADecimal(numero);
                int auxNum2 = hexadecimalADecimal(numero);

                string numBinario = "";
                string numeroOctal = "";

                for (int i = 0; auxNum1 > 0; i++)
                {
                    numBinario += auxNum1 % 2;
                    auxNum1 /= 2;
                }
                for (int i = 0; auxNum2 > 0; i++)
                {
                    numeroOctal += auxNum2 % 8;
                    auxNum2 /= 8;
                }
                return "Decimal: " + binarioADecimal(numero) + "\n" + "Binario: " + numBinario + "Octal: " + numeroOctal;
            }
        }
        return "";
    }
    public static void Main(string[] args)
    {


    }
}
