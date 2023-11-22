using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.StaticStrategy
{
    public class MarkdownListStrategy : IListStrategy
    {
        public void Start(StringBuilder sb)
        {
            // markdown doesn't require a list preamble
        }

        public void End(StringBuilder sb)
        {

        }

        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" * {item}");
        }
    }

}
