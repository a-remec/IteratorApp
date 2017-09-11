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
        public abstract string CurrentItem();
    }

    public class ConcreteIterator : Iterator
    {
        int currIndex;

        public ConcreteIterator(Aggregate ag)
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
