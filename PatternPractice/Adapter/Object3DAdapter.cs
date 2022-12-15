using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Adapter
{
    internal class Object3DAdapter
    {
        private Object3D object3D;

        public Object3DAdapter(Object3D obj) 
        { 
            object3D= obj;
        }

        public void SetLocationWithString(string str)
        {
            string[] strings = str.Split(new char[] { ',' });
            if (strings.Length != 3) Thrower();
            try
            {
                int x = int.Parse(strings[0]);
                int y = int.Parse(strings[1]);
                int z = int.Parse(strings[2]);
                object3D.ObjectLocation = new Location(x, y, z);
            }
            catch (Exception ex)
            {
                Thrower(ex);
            }
        }

        private void Thrower()
        {
            throw new Exception("Wrong format");
        }

        private void Thrower(Exception ex)
        {
            throw new Exception($"Wrong format: {ex.Message}");
        }
    }
}
