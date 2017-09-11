using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorApp
{
    public enum IteratorType { TotalIterator, LetterIterator }

    // The abstract aggregate class
    public abstract class Aggregate : List<string>
    {
        public abstract Iterator CreateIterator(IteratorType it);
    }

    public class ConcreteAggregate : Aggregate
    {
        public override Iterator CreateIterator(IteratorType it)
        {
            Iterator retVal;
            switch(it)
            {
                case IteratorType.TotalIterator:
                    retVal = CreateTotalIterator(this);
                    break;
                case IteratorType.LetterIterator:
                    retVal = CreateTotalIterator(this);
                    break;
                default:
                    retVal = CreateTotalIterator(this);
                    break;
            }

            return retVal;
        }

        private Iterator CreateTotalIterator(Aggregate ag)
        {
            return new TotalIterator(ag);
        }

        private Iterator CreateLetterIterator(Aggregate ag)
        {
            return new LetterIterator(ag);
        }

        
    }
}
