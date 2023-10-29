using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.PropertyDependencies
{
    public class Person : PropertyNotificationSupport
    {
        private int age;

        public int Age
        {
            get => age;
            set
            {
                if (value == age) return;
                age = value;
                OnPropertyChanged();
            }
        }

        public bool Citizen
        {
            get => citizen;
            set
            {
                if (value == citizen) return;
                citizen = value;
                OnPropertyChanged();
            }
        }

        private readonly Func<bool> canVote;
        private bool citizen;
        public bool CanVote => canVote();

        public Person()
        {
            canVote = property(nameof(CanVote), () => Citizen && Age >= 16);
        }
    }
}
