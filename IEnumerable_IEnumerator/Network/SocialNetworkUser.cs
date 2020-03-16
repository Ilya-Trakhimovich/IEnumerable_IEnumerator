using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IEnumerable_IEnumerator
{
    public class SocialNetworkUser : IComparable<SocialNetworkUser>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SocialNetworkUser(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int CompareTo([AllowNull] SocialNetworkUser other)
        {
            return this.Id.CompareTo(other?.Id);
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
