using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.State
{
    internal static class Object3dStateDecoratorExtensions
    {
        public static void ChangeStateToUrestricted(this Object3dStateDecorator object3D)
        {
            object3D.ChangeStateToUrestricted();
        }

        public static void ChangeStateToCenter(this Object3dStateDecorator object3D)
        {
            object3D.ChangeStateToCenter();
        }

        public static void ChangeStateToPositive(this Object3dStateDecorator object3D)
        {
            object3D.ChangeStateToPositive();
        }

        public static void ChangeStateToNegative(this Object3dStateDecorator object3D)
        {
            object3D.ChangeStateToNegative();
        }
    }
}
