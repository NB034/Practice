using ClassWork.PatternPractice.Prototype;

namespace ClassWork.PatternPractice.Decorator
{
    internal class Object3dWithRotation : IObject3D
    {
        private IObject3D object3D;

        public int AngleOfRotation { get; set; }

        public Object3dWithRotation(Object3D obj) => object3D = obj;

        public void PrepareForRender()
        {
            ResetRotation();
            object3D.PrepareForRender();
        }

        private void ResetRotation() => AngleOfRotation= 0;
    }
}
