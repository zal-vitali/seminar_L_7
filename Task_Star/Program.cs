/* ### Задача со звездочкой: 
Написать программу для перевода римских чисел в десятичные арабские.

* III -> 3
* LVIII -> 58
* MCMXCIV -> 1994 */

int ConvertRomanToArabian(string romanNumber)
{
    //M - 1000; D - 500; C - 100; L - 50; X - 10; V - 5; I - 1
    int arabianNumber = 0;
    romanNumber = romanNumber.ToUpper();
    for (int i = 0; i < romanNumber.Length; i++)
    {
        if (string.Compare(romanNumber[i].ToString(),"M") == 0) arabianNumber += 1000;
        else if (string.Compare(romanNumber[i].ToString(),"D") == 0) arabianNumber += 500;
        else if (string.Compare(romanNumber[i].ToString(),"C") == 0)
        {
            if (i < (romanNumber.Length - 1))
            {
                if (string.Compare(romanNumber[i+1].ToString(),"M") == 0
                || string.Compare(romanNumber[i+1].ToString(),"D") == 0)
                    arabianNumber -= 100;
                else
                    arabianNumber += 100;
            }
            else arabianNumber += 100;
        }
        else if (string.Compare(romanNumber[i].ToString(),"L") == 0) arabianNumber += 50;
        else if (string.Compare(romanNumber[i].ToString(),"X") == 0)
        {
            if (i < (romanNumber.Length - 1))
            {
                if (string.Compare(romanNumber[i+1].ToString(),"L") == 0
                || string.Compare(romanNumber[i+1].ToString(),"C") == 0)
                    arabianNumber -= 10;
                else
                    arabianNumber += 10;
            }
            else arabianNumber += 10;
        }
        else if (string.Compare(romanNumber[i].ToString(),"V") == 0) arabianNumber += 5;
        else if (string.Compare(romanNumber[i].ToString(),"I") == 0)
        {
            if (i < (romanNumber.Length - 1))
            {
                if (string.Compare(romanNumber[i+1].ToString(),"V") == 0
                || string.Compare(romanNumber[i+1].ToString(),"X") == 0)
                    arabianNumber -= 1;
                else
                    arabianNumber += 1;
            }
            else arabianNumber += 1;
        }
        else
        {
            Console.WriteLine($"Ошибка преобразования. Символ {romanNumber[i]} не входит в римскую нотацию");
            break;
        }
    }

    return arabianNumber;
}

Console.Clear();
Console.WriteLine("Введите число в римской нотации");
string romanNumber = Console.ReadLine()!;
Console.WriteLine($"Число в арабской нотации: {ConvertRomanToArabian(romanNumber)}");