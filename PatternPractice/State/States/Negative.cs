using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.State.States
{
    internal class Negative : BaseState
    {
        private readonly Object3dStateDecorator _object;

        public Negative(Object3dStateDecorator obj) => _object = obj;

        public override void ChangeStateToNegative()
        {
        }

        public override void ChangeStateToCenter()
        {
            _object.SetState(_object.CenterState);
        }

        public override void ChangeStateToUnrestricted()
        {
            _object.SetState(_object.UnrestrictedState);
        }
    }
}
