using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumerable_IEnumerator
{
    public static class SocNetworkExtension
    {
        public static void ReplaceCharacter(this SocialNetwork network, char ch1, char ch2)
        {
            var users = network?.Users;

            foreach (var user in users)
            {
                if (user.Name.Contains(ch1))
                {
                    user.Name = user.Name.Replace(ch1, ch2);
                }
            }
        }

        public static void CatchException<TException>(this Action<object> d, object o) where TException : Exception
        {
            try
            {
                d(o);
            }
            catch (TException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
