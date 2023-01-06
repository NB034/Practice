using ClassWork.PatternPractice.Prototype;
using ClassWork.PatternPractice.State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.State
{
    internal class Object3dStateDecorator
    {
        public Object3D Obj { get; private set; }

        public BaseState CurrentState { get; private set; }
        public Unrestricted UnrestrictedState { get; private set; }
        public Center CenterState { get; private set; }
        public Positive PositiveState { get; private set; }
        public Negative NegativeState { get; private set; }


        public Object3dStateDecorator(Object3D obj)
        {
            Obj = obj;
            UnrestrictedState = new Unrestricted(this);
            CenterState = new Center(this);
            PositiveState = new Positive(this);
            NegativeState = new Negative(this);
            CurrentState = CenterState;
        }

        public void SetState(BaseState state) => CurrentState = state;
    }
}
