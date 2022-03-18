using System;
using System.Collections.Generic;

namespace DetectingDecoratorCycles.Classes.Policies
{
    public abstract class ShapeDecoratorCyclePolicy
    {
        public abstract bool TypeAdditionAllowed(Type type, IList<Type> allTypes);
        public abstract bool ApplicationAllowed(Type type, IList<Type> allTypes);

    }
}
