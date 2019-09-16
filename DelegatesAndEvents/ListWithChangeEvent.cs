using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DelegatesAndEvents
{
    public delegate void ChangeEventHandler(object sender, EventArgs e);
    class ListWithChangeEvent : ArrayList
    {
        public ChangeEventHandler changed;

        protected virtual void OnChanged(EventArgs e)
        {
            if (changed != null)
                changed(this, e);
        }

        public override void Add(object value)
        {
            base.Add(value);
            OnChanged(EventArgs.Empty);
        }

        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }
}
