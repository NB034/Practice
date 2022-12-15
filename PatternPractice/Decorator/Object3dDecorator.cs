using ClassWork.PatternPractice.Prototype;

namespace ClassWork.PatternPractice.Decorator
{
    internal class Object3dDecorator : IObject3D
    {
        private Object3D object3D;

        public int AngleOfRotation { get; set; }

        public Object3dDecorator(Object3D obj) => object3D = obj;

        public void ChangeX(int x) =>
            object3D.ObjectLocation = new Location(x, object3D.ObjectLocation.Y, object3D.ObjectLocation.Z);

        public void ChangeY(int y) =>
            object3D.ObjectLocation = new Location(object3D.ObjectLocation.X, y, object3D.ObjectLocation.Z);

        public void ChangeZ(int z) =>
            object3D.ObjectLocation = new Location(object3D.ObjectLocation.X, object3D.ObjectLocation.Y, z);

        public void PrepareForRender()
        {
            ResetRotation();
            object3D.PrepareForRender();
        }

        private void ResetRotation() => AngleOfRotation= 0;
    }
}
