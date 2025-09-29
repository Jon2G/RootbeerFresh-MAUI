using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootBeerFresh
{
    [AttributeUsage(AttributeTargets.All)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class PreserveAttribute : Attribute
    {
        public bool AllMembers;
        public bool Conditional;

        public PreserveAttribute(bool allMembers, bool conditional)
        {
            AllMembers = allMembers;
            Conditional = conditional;
        }
        public PreserveAttribute()
        {
        }
    }
}
