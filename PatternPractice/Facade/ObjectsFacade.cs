using ClassWork.PatternPractice.Iterator;
using ClassWork.PatternPractice.State;
using ClassWork.PatternPractice.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Facade
{
    internal class ObjectsFacade
    {
        List<Object3dStateDecorator> list = new List<Object3dStateDecorator>();


        public ObjectsFacade(Object3DCollection collection)
        {
            foreach (var obj in collection)
            {
                list.Add(new Object3dStateDecorator(obj));
            }
        }

        public void DefaultPositionAndLoad(BaseObject3dLoader loader)
        {
            foreach(var o in list)
            {
                o.ChangeStateToCenter();
                loader.LoadObject(o.Obj);
            }
        }
    }
}
