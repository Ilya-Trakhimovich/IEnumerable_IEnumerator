using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IEnumerable_IEnumerator
{
    public partial class SocialNetwork
    {
        public List<SocialNetworkUser> Users 
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
            }
        }

        public SocialNetwork(List<SocialNetworkUser> users)
        {
            this._users = users;
        }

        public IEnumerator GetEnumerator()
        {
            return new SocialNetworkEnumerator(_users);
        }

        public IEnumerable GetNameByCharacter(char ch)
        {
            for (var i = 0; i < _users.Count; i++)
            {
                if (_users[i].Name.Contains(ch))
                {
                    yield return _users[i].Name;
                }
            }
        }

        public void SortByID()
        {
            for (var i = 0; i < _users.Count; i++)
            {
                for (var j = 0; j < _users.Count-1; j++)
                {
                    if (_users[i]?.Id < _users[j]?.Id)
                    {
                        var temp = _users[i];
                        _users[i] = _users[j];
                        _users[j] = temp;
                    }
                }
            }
        }

        public void AddUserMain(SocialNetworkUser user) 
        {
            //_users.Add(user);
            AddUser(123, "Khf");
        }

        public void InsertUser(int id, string name)
        {
            try
            {
                _users[id] = new SocialNetworkUser(id, name);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.Message}\n");
            }
            finally
            {
                _users.Add(new SocialNetworkUser(id, name));
            }
        }

        partial void AddUser(int id, string name);

        private List<SocialNetworkUser> _users;
    }
}
