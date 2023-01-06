using ClassWork.PatternPractice.AbstractFactory.At_At_Walker;
using ClassWork.PatternPractice.AbstractFactory.Soldier;
using ClassWork.PatternPractice.AbstractFactory.Spaceship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.AbstractFactory
{
    internal static class FactoryMethod
    {
        public static IObjectFactory GetFactory(Object3dTypes type)
        {
            switch (type)
            {
                case Object3dTypes.At_At_Walker:
                    return new GenericObjectFactory<WalkerObject, WalkerAnimation, WalkerSpecifications>();
                case Object3dTypes.Soldier:
                    return new GenericObjectFactory<SoldierObject, SoldierAnimation, SoldierSpecifications>();
                case Object3dTypes.SpaceShip:
                    return new GenericObjectFactory<SpaceshipObject, SpaceshipAnimation, SpaceShipSpecifications>();
                default:
                    return null;
            }
        }
    }
}
