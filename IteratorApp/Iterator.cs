using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorApp
{
    public abstract class Iterator
    {
        protected Aggregate aggregate;

        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        // Constructor
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        // Gets first iteration item
        public override object First()
        {
            return _aggregate[0];
        }

        // Gets next iteration item
        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }





    }

    //
    public class TotalIterator : Iterator
    {
        int currIndex;

        public TotalIterator(Aggregate ag)
        {
            aggregate = ag;
        }

        public override void First()
        {
            currIndex = 0;
        }

        public override void Next()
        {
            currIndex++;
        }

        public override bool IsDone()
        {
            return (currIndex >= aggregate.Count);
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate[currIndex];
            else
                throw new Exception();
        }

    }

    //
    public class LetterIterator : Iterator
    {
        int currIndex;

        public LetterIterator(Aggregate ag)
        {
            aggregate = ag;
        }

        public override void First()
        {
            currIndex = 0;
            for (int cI = 0; cI <= aggregate.Count; cI++)
            {
                if (aggregate[cI].ToLower().Contains('a'))
                    break;              
                else
                    currIndex++;
            }
        }

        public override void Next()
        {
            for (int cI = currIndex; cI <= aggregate.Count; cI++)
            {
                if (aggregate[cI].ToLower().Contains('a'))
                    break;
                else
                    currIndex++;
            }
        }

        public override bool IsDone()
        {
            return (currIndex >= aggregate.Count);
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate[currIndex];
            else
                throw new Exception();
        }
    }

}
