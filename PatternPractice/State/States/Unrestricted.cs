using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.State.States
{
    internal class Unrestricted : BaseState
    {
        private readonly Object3dStateDecorator _object;

        public Unrestricted(Object3dStateDecorator obj) => _object = obj;

        public override void ChangeStateToUnrestricted()
        {
        }

        public override void ChangeStateToCenter()
        {
            _object.SetState(_object.CenterState);
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
