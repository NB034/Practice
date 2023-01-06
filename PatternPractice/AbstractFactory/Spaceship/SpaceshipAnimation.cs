﻿using ClassWork.PatternPractice.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.AbstractFactory.Spaceship
{
    internal class SpaceshipAnimation : IAnimation
    {
        public Object3dTypes Type => Object3dTypes.SpaceShip;

        public void Move()
        {
            // Fly
        }
    }
}
