using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private ICollection<IObserver<AbstractStringSubject>> observers;

        private string item;
        public string Item
        {
            get => item;
            protected set
            {
                item = value;
                foreach (var obs in observers)
                {
                    obs.Update(this);
                }
            }
        }

        protected AbstractStringSubject()
        {
            observers = new List<IObserver<AbstractStringSubject>>(); 
        }


        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Remove(obs);
        }
    }
}