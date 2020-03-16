using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SocialNetworkUser> users = new List<SocialNetworkUser>()
            {
                 new SocialNetworkUser(0, "Ilya"),
                 new SocialNetworkUser(91, "Gennadiy"),
                 new SocialNetworkUser(222, "Olga"),
                 new SocialNetworkUser(13, "Pavel"),
                 new SocialNetworkUser(4, "Svetlana"),
                 new SocialNetworkUser(26, "Igor")
            };

            SocialNetwork vk = new SocialNetwork(users);
             
            ShowCollecction(vk);
            ShowNameByCharacter(null, 'I');
            vk.InsertUser(14, "Ekaterina");

            try
            {
                vk.AddUserMain(new SocialNetworkUser(1000, "Zelenskiy"));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}\n");
            }
            catch
            {
                Console.WriteLine("Error.");
            }

            vk.SortByID();
            vk.ReplaceCharacter('G', 'P');
            ShowCollecction(vk);

            Action<object> del = o => Console.WriteLine(o.GetType());
            del.CatchException<Exception>(users);
        }

        private static void ShowCollecction(SocialNetwork network)
        {
            foreach (var user in network)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine();
        }

        private static void ShowNameByCharacter(SocialNetwork network, char ch)
        {
            string message = $"Users with char {ch} in name:";
            Console.WriteLine(message);

            try
            {
                foreach (var name in network.GetNameByCharacter(ch))
                {
                    Console.WriteLine(name);
                }

                Console.WriteLine();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"{e.Message}\n");
            }
        }
    }
}
