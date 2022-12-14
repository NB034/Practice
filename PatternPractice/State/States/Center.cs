using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.State.States
{
    internal class Center : BaseState
    {
        private readonly Object3dStateDecorator _object;

        public Center(Object3dStateDecorator obj) => _object = obj;

        public override void ChangeStateToCenter()
        {
        }

        public override void ChangeStateToUnrestricted()
        {
            _object.SetState(_object.UnrestrictedState);
        }

        public override void ChangeStateToNegative()
        {
            _object.SetState(_object.NegativeState);
        }

        public override void ChangeStateToPositive()
        {
            _object.SetState(_object.PositiveState);
        }
    }
}
