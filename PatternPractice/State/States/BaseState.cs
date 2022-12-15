using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.State.States
{
    internal class BaseState
    {
        public virtual void ChangeStateToUnrestricted() => Thrower();

        public virtual void ChangeStateToCenter() => Thrower();

        public virtual void ChangeStateToPositive() => Thrower();

        public virtual void ChangeStateToNegative() => Thrower();

        public virtual void Thrower()
        {
            throw new Exception("Unable to change state");
        }
    }
}
