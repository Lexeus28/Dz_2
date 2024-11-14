using System;
namespace Tumak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 3.1
            Console.WriteLine(@"Упражнение 3.1. Создать перечислимый тип данных отображающий виды банковского
            счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
            значение и вывести это значение на печать.");
            Console.WriteLine("\n");

                    Account schet = Account.current_account;
                    Console.WriteLine($"Счёт: {schet}");

            Console.WriteLine("\n");
            //Упражнение 3.2
            Console.WriteLine(@"Упражнение 3.2. Создать структуру данных, которая хранит информацию о банковском
            счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
            значениями и напечатать результат.");
            Console.WriteLine("\n");

                    Schet moi = new Schet(5775, Account.savings_account, 28542);
                    moi.Print();

            Console.WriteLine("\n");
            //Домашнее задание 3.1
            Console.WriteLine(@"Домашнее задание 3.1. Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
            структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
            распечатать.");
            Console.WriteLine("\n");

                    Rab kto = new Rab();
                    kto.name = "Весна";
                    kto.sharaga = University.КАИ;
                    kto.Print();
        }
    }
    public enum Account
    {
        savings_account,
        current_account
    }
    public struct Schet
    {
        public int nomer;
        public Account type;
        public int balance;

        public Schet(int nomer, Account type, int balance)
        {
            this.nomer = nomer;
            this.type = type;
            this.balance = balance;
        }
        public void Print()

        {
            Console.WriteLine($"Номер: {nomer}\nТип: {type}\nБаланс: {balance}");
        }
    }
    enum University
    {
        КГУ,
        КАИ,
        КХТИ
    }
    struct Rab
    {
        public string name;
        public University sharaga;
        public void Print()
        {
            Console.WriteLine($"Имя: {name}\nВУЗ: {sharaga}");
        }
    }
}