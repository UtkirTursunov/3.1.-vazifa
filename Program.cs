/*
1. Tub sonlar: Foydalanuvchidan kiritilgan sonning tub son ekanligini tekshiruvchi dastur tuzing.
Agar kiritilgan son tub bo'lsa, "Tub" degan xabar chiqaring, aks holda "Tub emas" degan xabar chiqaring. 
Input = 7; 
Output = “Tub”


System.Console.Write("Sonni kiriting: ");
int son = Convert.ToInt32(Console.ReadLine());

int sanoq = 0;
for (int i = 1; i <= son; i++)
{
    if (son % i == 0 )
    {
        sanoq ++;
    }
}
if (sanoq == 2)
{
    System.Console.WriteLine("Ushbu son tub!");
}
else 
{
    System.Console.WriteLine("Ushbu son tub emas!");
}
*/


/*
2. Bo'luvchisiz sonlar: Foydalanuvchidan son qabul qilib, shu sonni 2 dan boshlab 10 gacha bo'lgan bo'luvchilarini
hisoblovchi dastur yozing. Natijani ekranga chiqaring. Input = 20; 
Output = "Bo'luvchilari: 2, 4, 5, 10"


System.Console.Write("Sonni kiriting: " );
int son = Convert.ToInt32(Console.ReadLine());

System.Console.Write ("Bo'luvchilari: ");
for (int i = 2; i <=10; i++)
{
    if (son % i == 0)
    System.Console.Write(i + ", ");
}

*/


// 3. Daraja hisoblash: Foydalanuvchidan son va uning darajasini qabul qilib, berilgan sonni berilgan
// darajaga ko'taradigan dastur tuzing. Daraja musbat butun son bo'lishi kerak. 
// Input = 3, 4;
// Output = 81

/*
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

System.Console.Write ("Sonni kiritng: ");
double son = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Sonning darajasini kiriting: ");
double daraja = Convert.ToDouble(Console.ReadLine());

double result = Math.Pow(son, daraja);
System.Console.WriteLine($"Natija: {result}");
*/

/*
4. Harajatlar to'plamini hisoblash: Foydalanuvchidan bir nechta to'plam miqdorlar kiritilgan holda, ularni qo'shib yig'indisini
hisoblovchi dastur yozing va natijani ekranga chiqaring. 
Input = [150, 230, 80, 120]; 
Output = 580


System.Console.Write("Array nechta sondan iborat bo'lishini hohlaysiz: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] myNumbers = new int [n];

for (int i = 0; i < n; i++)
{
    System.Console.Write("Arrayning " + (i+1) + " sonini kiriting: ");
    myNumbers[i] = Convert.ToInt32(Console.ReadLine());
}
int summa = 0;
foreach(int number in myNumbers)
{
    summa += number;
}
System.Console.WriteLine("Array ichidagi sonlar yig'indisi: " + summa);
*/

/*
5. Armstrong sonlar: Foydalanuvchidan son qabul qilib, shu sonni Armstrong son ekanligini aniqlang.
Armstrong son, raqamlarining darajasiga mos keladigan sonlardir. Masalan: 
Input = 153; 
Output = "153 Armstrong son" 
153 raqamining raqamlarini darajaga olib, o'lchamalarga ko'paytirib qo'ygan holda,
1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153 bo'ladi. Bu sababli, 153 raqami Armstrong son hisoblanadi.


System.Console.Write("Butun sonni kiriting: ");
int son = Convert.ToInt32(Console.ReadLine());

int testSon = son;
int digitNumber = son.ToString().Length;
int summa = 0;

while (testSon>0)
{
    int digit = testSon % 10;
    summa += (int)Math.Pow(digit, digitNumber);
    testSon /= 10; 
}
if (summa == son)
{
    System.Console.WriteLine(son + " Armstrong son.");
}
else
{
    System.Console.WriteLine(son + " Armstrong son emas.");
}
*/

/*

6. Sifatli bo'luvchilar: Foydalanuvchidan son qabul qilib, shu sonni nechta sifatli bo'luvchilarini hisoblang.
Sifatli bo'luvchilar, faqat bittadan o'zidan keyincha bo'lgan sonlar hisoblanadi. Masalan: 
Input = 20; 
Output = 4 
20 raqamining sifatli bo'luvchilari 1, 2, 4, va 5 sonlari hisoblanadi.
*/

System.Console.Write("Sonni kiriting: ");
int son = int.Parse(Console.ReadLine());
int summa = 0;

for (int i = 2; i < son; i++)
{
    if (son % i == 0)
    {
        System.Console.Write(i + " ");
        summa++;
    }
}
System.Console.WriteLine("\nSonning sifatli bo'luvchilari miqdori: " + summa);