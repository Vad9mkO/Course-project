using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronomicalDirectory
{
    public class CurrentState
    {
        List<int> previous;
        int before;//переключатель
        int current;  
        int after;
        List<int> next;
        bool undoDone;

        internal CurrentState() : this(new List<int>() {0}, 0, 0, 0, new List<int>() {0}, false){}

        internal CurrentState(List<int> previous, int f, int cur, int l, List<int> next, bool undo)
        {
            this.previous = previous;
            this.next = next;
            current = cur;
            before = f;
            after = l;
            undoDone = false;
        }

        internal List<int> Previous
        {
            get { return previous; }
            set { previous = value; }
        }
        internal int Before
        {
            get { return before; }
            set { before = value; }
        }
        internal int Current
        {
            get { return current; }
            set { current = value; }
        }
        internal int After
        {
            get { return after; }
            set { after = value; }
        }
        internal List<int> Next
        {
            get { return next; }
            set { next = value; }
        }
        internal bool UndoDone
        {
            get { return undoDone; }
            set { undoDone = value; }
        }
    }
}
