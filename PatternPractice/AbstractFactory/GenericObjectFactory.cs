using ClassWork.PatternPractice.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.AbstractFactory
{
    internal class GenericObjectFactory<TGameOblect, TAnimation, TPhysical> : IObjectFactory
        where TGameOblect : IGameObject, new()
        where TAnimation : IAnimation, new()
        where TPhysical : IPhysical, new()
    {
        public void LoadObject() => new TGameOblect();
        public void LoadAnimation() => new TAnimation();
        public void LoadPhysics() => new TPhysical();
    }
}
