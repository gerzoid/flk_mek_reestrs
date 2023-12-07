using Mek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Rules
{
    public class FlkRules
    {
        private readonly List<IHandler> handlerQueue = new List<IHandler>();

        public event Action<object> Finished;

        public FlkRules(params IHandler[] handlers)
        {
            foreach (var handler in handlers)
            {
                handlerQueue.Add(handler);
            }
        }

        public void AddHandler(IHandler handler)
        {
            handlerQueue.Add(handler);
        }

        public void Start(TreatmentCase request)
        {
            foreach (var handler in handlerQueue)
            {
                handler.Handle(request);
            }
;
        }
    }

}
