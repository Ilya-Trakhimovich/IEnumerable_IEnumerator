using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumerable_IEnumerator
{
    public partial class SocialNetwork
    {
        partial void AddUser(int id, string name)
        {
            int capacity = _users.Count + 1;
            var temp = new List<SocialNetworkUser>(capacity);

            for (var i = 0; i < temp.Count; i++)
            {
                temp[i] = _users[i];
            }

            try
            {
                temp[capacity] = new SocialNetworkUser(id, name);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}");
                throw;
            }
        }
    }
}
