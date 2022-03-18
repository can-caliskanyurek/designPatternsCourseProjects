using System;
using System.Collections.Generic;

namespace DetectingDecoratorCycles.Classes.Policies
{
    public class CyclesAllowedPolicy : ShapeDecoratorCyclePolicy
    {
        public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
        {
            return true;
        }

        public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
        {
            return true;
        }
    }
}
