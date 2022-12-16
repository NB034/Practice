using System;

namespace ClassWork
{
    public delegate void PropertyeventHandler(object sender, PropertyEventArgs e);

    interface iPropertychanged
    {
        event PropertyeventHandler Propertychanged;
    }

    public class PropertyEventArgs : EventArgs
    {
        public PropertyEventArgs(string name)
        {
            PropertyName = name;
        }
        public string PropertyName { get; set; }
    }

    internal class WhoShows : iPropertychanged
    {
        public string Name { get; set; }
        public WhoShows()
        {
            Name = "AAAA";
        }

        public void ChangeName(string name)
        {
            Name = name;
            Propertychanged?.Invoke(this, new PropertyEventArgs(Name));
        }

        public event PropertyeventHandler Propertychanged;
    }

    internal class Subscriber : iPropertychanged
    {
        public event PropertyeventHandler Propertychanged;
        public Subscriber()
        {
            Propertychanged += Oh;
            Propertychanged(this, new PropertyEventArgs("sss"));
        }

        public void Oh(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Oh no! {this.ToString()} has changed {e.PropertyName}!");
        }

    }
}
