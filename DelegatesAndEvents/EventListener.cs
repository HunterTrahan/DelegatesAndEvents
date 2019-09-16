using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class EventListener
    {
        private ListWithChangeEvent List;

        public EventListener(ListWithChangeEvent list)
        {
            List = list;
            List.changed += new ChangeEventHandler(OnListChanged);
        }

        private void OnListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("list changed event received");
        }

        public void Detatch()
        {
            List.changed -= new ChangeEventHandler(OnListChanged);
            List = null;
        }
    }
}
