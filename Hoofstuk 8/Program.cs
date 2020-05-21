using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("All eyes on me", "2pac", 27);
            var cd2 = new CD("R u still down", "2pac", 26);

            Member member = new Member("Cris Adamus", Speciality.sport);
            Member member2 = new Member("Beto Adamus", Speciality.film_music);
            Member member3 = new Member("Djelo Merian", Speciality.actuality);
            Member member4 = new Member("Nina", Speciality.fauna_flora);

            Team team1 = new Team(member, member2, member3, member4);

            FruitVendingMachine m1 = new FruitVendingMachine(50, 15);

            BankAccount account = new BankAccount("Cris Adamus", 100);
            account.MakeWithdrawal(150, DateTime.Now, "zak geld");
            account.MakeDeposit(1100, DateTime.Now, "spaar geld");

            //Console.Write("Hoeveel punten heb je gehaald: ");
            //int cijfer = int.Parse(Console.ReadLine());
            //Result cris11 = new Result(cijfer);


            //Console.WriteLine(cris11.points);
            //Console.WriteLine(cris11.FinalRaport());
            Console.WriteLine(cd2.GetCdInfo());
            Console.WriteLine(team1.PrintAllMembers());
            Console.ReadKey();
        }
    }
}
