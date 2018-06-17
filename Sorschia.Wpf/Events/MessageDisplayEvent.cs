using Prism.Events;
using Sorschia.Models;

namespace Sorschia.Events
{
    public sealed class MessageDisplayEvent : PubSubEvent<MMessageDisplay>
    {
        public void Raise(string message)
        {
            Publish(new MMessageDisplay(message));
        }

        public void Raise(string header, string message)
        {
            Publish(new MMessageDisplay(header, message));
        }
    }
}
