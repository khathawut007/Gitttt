using System;
using System.Collections.Generic;
namespace CODEEE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tshirt> tshirts = new List<Tshirt>();
           {
                User jame = new User("Jame waton");
                User email = new User("jame@gmail.com");
                Tshirt one = new Tshirt(1,"L red");
                Tshirt two = new Tshirt(2,"M black");
                Tshirt price1 = new Tshirt(3,"750 บาท");
                Tshirt price2 = new Tshirt(4,"625 บาท");
                Address address = new Address("ที่อยู่ 313/75, ถนนพุธมลทล จังหวัด นครปฐม 10180");

                jame.addList(email);
                jame.addList(one);
                jame.addList(two);
                jame.addList(price1);
                jame.addList(price2);
                jame.addList(address);

                jame.getShopping();
                



            }
        }
    }

    
}
