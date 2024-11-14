using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;
using System.Runtime.InteropServices;
namespace Dz_2
{
    class Program
    {
        static void Main()
        {

            //1
            Console.WriteLine(@"Задание 1.Выведите на экран информацию о каждом типе данных в виде:
            Тип данных – максимальное значение – минимальное значение");
            Console.WriteLine("\n");

                    Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
                    Console.WriteLine($"byte – {byte.MaxValue} – {byte.MinValue}");
                    Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
                    Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
                    Console.WriteLine($"char – {char.MaxValue} – {char.MinValue}");
                    Console.WriteLine($"bool – {true} – {false}");
                    Console.WriteLine($"DateTime – {DateTime.MaxValue} – {DateTime.MinValue}");
                    Console.WriteLine($"TimeSpan – {TimeSpan.MaxValue} – {TimeSpan.MinValue}");
                    Console.WriteLine($"sbyte – {sbyte.MaxValue} – {sbyte.MinValue}");
                    Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
                    Console.WriteLine($"ushort – {ushort.MaxValue} – {ushort.MinValue}");
                    Console.WriteLine($"uint – {uint.MaxValue} – {uint.MinValue}");
                    Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
                    Console.WriteLine($"ulong – {ulong.MaxValue} – {ulong.MinValue}");
                    Console.WriteLine($"decimal – {decimal.MaxValue} – {decimal.MinValue}");

            Console.WriteLine("\n");
            //2
            Console.WriteLine(@"Задание 2. Напишите программу, в которой принимаются данные пользователя в виде имени,
            города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
            переменной, а затем распечатайте всю информацию в правильном формате.");
            Console.WriteLine("\n");

                    User smb = new User();
                    try
                    {
                        Console.WriteLine("Введите Имя пользователя");
                        smb.Name = Console.ReadLine();
                        Console.WriteLine("Введите Город");
                        smb.City = Console.ReadLine();
                        Console.WriteLine("Введите Возраст");
                        smb.Age = Convert.ToInt32((Console.ReadLine()));
                        Console.WriteLine("Введите PIN-код");
                        smb.Pin = Convert.ToInt32(Console.ReadLine());
                        smb.PrintInformation();
                    }
                    catch (Exception ex) { Console.WriteLine("Некорректный Ввод"); }

            Console.WriteLine("\n");
            //3
            Console.WriteLine(@"Задание 3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.");
            Console.WriteLine("\n");

                    char[] stroka = Console.ReadLine().ToArray();
                    for (int i = 0; i < stroka.Length; i++)
                    {
                        if (Char.IsLower(stroka[i]))
                        {
                            stroka[i] = char.ToUpper(stroka[i]);
                        }
                        else
                        {
                            stroka[i] = char.ToLower(stroka[i]);
                        }
                    }
                    Console.WriteLine(stroka);

            Console.WriteLine("\n");
            //4
            Console.WriteLine("Задание 4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.");
            Console.WriteLine("\n");

                    Console.WriteLine("Введите строку");
                    char[] strok = Console.ReadLine().ToArray();    //Вводим строку и раскладываем её на массив символов
                    Console.WriteLine("Введите подстроку");
                    string podstrok = Console.ReadLine();
                    int k = 0;
                    for (int i = 0; i <= (strok.Length - podstrok.Length); i++)     //Перемещаем правую границу, пока не посчитаем все вхождения
                    {
                        if (string.Join("", strok[i..(i + podstrok.Length)]) == podstrok)   //Проверяем, является ли взятый нами отрезок нужной нам подстрокой
                        { k++; }    // Обновляем счётчик, если вхождение обнаружено
                    }
                    Console.WriteLine($"Количество вхождений: {k}");

            Console.WriteLine("\n");
            //5
            Console.WriteLine(@"Задание 5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
            нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
            покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
            скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
            обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
            сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
            стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
            целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.");
            Console.WriteLine("\n");

                    try
                    {
                        Console.WriteLine("Введите стандартную цену бутылки виски");
                        float normPrice = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите процент скидки в Duty Free");
                        float salePrice = normPrice * (float.Parse(Console.ReadLine()) / 100);
                        Console.WriteLine("Введите стоимость отпуска");
                        float holidayPrice = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Вам нужно {(int)(holidayPrice / salePrice)} бутылок виски, чтобы экономия покрыла отпуск");
                    }
                    catch (Exception ex) { Console.WriteLine("Некорректный Ввод"); }
                    Console.WriteLine("\n");
            //6
            Console.WriteLine(@"Задание 6. Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
            рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
            выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
            студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
            различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
            (процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
            выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
            структуры: наименование типа напитка и процент спирта.");
            Console.WriteLine("\n");

                    Drink Whiskey = new Drink("Виски", 50);    //Заполняем данные о напитках
                    Drink Vodka = new Drink("Водка", 80);
                    Drink Brandy = new Drink("Бренди", 40);
                    Drink Butterbear = new Drink("Сливочное пиво", 5);
                    Student n1 = new Student("Григорий", "Чопырин", "1840", "15.10.2001", 'b', 150, Whiskey);  //Заполняем данные о студентах
                    Student n2 = new Student("Виктор", "Комаров", "1632", "19.07.1996", 'd', 0, Vodka);
                    Student n3 = new Student("Андрей", "Николенко", "1756", "03.08.1998", 'a', 400, Vodka);
                    Student n4 = new Student("Александр", "Кочерыжкин", "1835", "21.11.2000", 'c', 125, Brandy);
                    Student n5 = new Student("Гаррик", "Поттеров", "1943", "26.06.1997", 'c', 110, Butterbear);         
                    float vsegoVipili = 0, vsegoAlcVipili;    //Вводим переменные общего количества выпитой жидкости и алкоголя
                    vsegoVipili = n1.Objem + n2.Objem + n3.Objem + n4.Objem + n5.Objem;
                    vsegoAlcVipili = n1.Objem * n1.alko.Procent / 100 + n2.Objem * n2.alko.Procent / 100 + n3.Objem * n3.alko.Procent / 100 + n4.Objem * n4.alko.Procent / 100 + n5.Objem * n5.alko.Procent / 100;
                    // Считаем процент выпитой жидкости и алкоголя для каждого из студентов 
                    float GrishaLiquid = 100 / (vsegoVipili / n1.Objem);
                    float GrishaAlco = 100 / (vsegoAlcVipili / (n1.Objem * (Whiskey.Procent / 100)));
                    float ViktorLiquid = 100 / (vsegoVipili / n2.Objem);
                    float ViktorAlco = 100 / (vsegoAlcVipili / (n2.Objem * (Vodka.Procent / 100)));
                    float AndrewLiquid = 100 / (vsegoVipili / n3.Objem);
                    float AndrewAlco = 100 / (vsegoAlcVipili / (n3.Objem * (Vodka.Procent / 100)));
                    float AlexLiquid = 100 / (vsegoVipili / n4.Objem);
                    float AlexAlco = 100 / (vsegoAlcVipili / (n4.Objem * (Brandy.Procent / 100)));
                    float HarryLiquid = 100 / (vsegoVipili / n5.Objem);
                    float HarryAlco = 100 / (vsegoAlcVipili / (n5.Objem * (Butterbear.Procent / 100)));


                    n1.Print();
                    Console.WriteLine($"Процент выпитой жидкости относительно общего количества: {GrishaLiquid}");
                    Console.WriteLine($"Процент выпитого алкоголя относительно общего количества: {GrishaAlco}");
                    Console.WriteLine("\n");
                    n2.Print();
                    Console.WriteLine($"Процент выпитой жидкости относительно общего количества: {ViktorLiquid}");
                    Console.WriteLine($"Процент выпитого алкоголя относительно общего количества: {ViktorAlco}");
                    Console.WriteLine("\n");
                    n3.Print();
                    Console.WriteLine($"Процент выпитой жидкости относительно общего количества: {AndrewLiquid}");
                    Console.WriteLine($"Процент выпитого алкоголя относительно общего количества: {AndrewAlco}");
                    Console.WriteLine("\n");
                    n4.Print();
                    Console.WriteLine($"Процент выпитой жидкости относительно общего количества: {AlexLiquid}");
                    Console.WriteLine($"Процент выпитого алкоголя относительно общего количества: {AlexAlco}");
                    Console.WriteLine("\n");
                    n5.Print();
                    Console.WriteLine($"Процент выпитой жидкости относительно общего количества: {HarryLiquid}");
                    Console.WriteLine($"Процент выпитого алкоголя относительно общего количества: {HarryAlco}");
                    Console.WriteLine("\n");
                    Console.WriteLine($"Всего жидкости выпито: {vsegoVipili} грамм");
                    Console.WriteLine($"Всего алкоголя выпито: {vsegoAlcVipili} грамм");













        }

    }
    struct User
    {
        public string Name;
        public string City;
        public int Age;
        public int Pin;
        public void PrintInformation()
        {
            Console.WriteLine($"Имя: {Name}\nГород: {City}\nВозраст: {Age}\nPIN-код: {Pin}\n");
        }
    }
    struct Drink
    {
        public string Nazvanje;
        public float Procent;
        public Drink(string naz, float proc) { Nazvanje = naz; Procent = proc; }
    }
    struct Student
    {
        public string Imya;
        public string Familia;
        public string Id;
        public string BirthDate;
        public char AlcoType;
        public float Objem;
        public Drink alko;
        public Student(string name, string surname, string ID, string data, char Alc, float Amount, Drink drink)
        {
            Imya = name; Familia = surname; Id = ID; BirthDate = data; AlcoType = Alc; Objem = Amount; alko = drink;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {Imya}");
            Console.WriteLine($"Фамилия: {Familia}");
            Console.WriteLine($"Идентификатор: {Id}");
            Console.WriteLine($"Дата рождения: {BirthDate}");
            Console.WriteLine($"Категория алкоголизма: {AlcoType}");
            Console.WriteLine($"Объем выпитой жидкости: {Objem}");
            Console.WriteLine($"Напиток: {alko.Nazvanje}");
        }
    }
}

