using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEnumerable_IEnumerator
{
    class SocialNetworkEnumerator : IEnumerator<SocialNetworkUser>
    {
        public SocialNetworkEnumerator(List<SocialNetworkUser> users)
        {
            this._users = users;
        }

        public bool MoveNext()
        {
            bool hasNext = false;

            if (_position < _users.Count - 1)
            {
                _position++;
                hasNext = true;
            }

            return hasNext;
        }

        public SocialNetworkUser Current
        {
            get
            {
                SocialNetworkUser user = null;

                if (_position == -1 || _position >= _users.Count)
                {
                    Console.WriteLine("Error.");
                }
                else
                {
                    user = _users[_position];
                }

                return user;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                string info = $"{this?.Current?.Id} - {this?.Current?.Name}";
                return info;
            }
        }

        public void Dispose() { }

        public void Reset()
        {
            _position = -1;
        }

        private readonly List<SocialNetworkUser> _users;
        private int _position = -1;
    }
}
