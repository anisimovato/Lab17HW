using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab17HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankaccount<int> bankaccount1 = new Bankaccount<int>(9, 5000, "Иванов");
            int bankaccount1Num = bankaccount1.getNum();
            float bankaccount1Ballans = bankaccount1.getBallans();
            string bankaccount1Name = bankaccount1.getName();
            Console.WriteLine($"Счет №  { bankaccount1Num}, Сумма {bankaccount1Ballans}, Имя: {bankaccount1Name}");
            

            Bankaccount<string> bankaccount2 = new Bankaccount<string>("00597", 5000, "Магнит");
            string bankaccount2Num = bankaccount2.getNum();
            float bankaccount2Ballans = bankaccount2.getBallans();
            string bankaccount2Name = bankaccount2.getName();
            Console.WriteLine($"Счет №  { bankaccount2Num}, Сумма {bankaccount2Ballans}, Имя: {bankaccount2Name}");

            Console.ReadKey();

        }
        
    }
    class Bankaccount<T>
    {
        private T num;
        private float ballans;
        private string name;

        public Bankaccount(T num, float ballans, string name)
        {
            this.num = num;
            this.ballans = ballans;
            this.name = name;

        }
        public T getNum()
        {
            return num;
        }
        public float getBallans()
        {
            return ballans;
        }
        public string getName()
        {
            return name;
        }
    }
}







//Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
//    Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
//    Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько экземпляров класса,
//    параметризированного различными типам. Заполнить его поля и вывести информацию об экземпляре класса на печать.

