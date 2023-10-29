using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.CompositeCommand
{
    abstract class CompositeBankAccountCommand : List<BankAccountCommand>, ICommand
    {
        public virtual void Call()
        {
            ForEach(cmd => cmd.Call());
        }

        public void Undo()
        {
            foreach (var cmd in
              ((IEnumerable<BankAccountCommand>)this).Reverse())
            {
                if (cmd.Success)cmd.Undo();
            }
        }

        public bool Success 
        {
            get { return this.All(cmd => cmd.Success); }
            set { this.All(cmd => cmd.Success = value); }
        }
    }

}
