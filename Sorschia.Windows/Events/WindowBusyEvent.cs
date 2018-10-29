using Prism.Events;

namespace Sorschia.Events
{
    public sealed class WindowBusyEvent : PubSubEvent<bool>
    {
        private int Count { get; set; }

        public void Busy()
        {
            Count++;
            Change();
        }

        public void Unbusy()
        {
            if (Count > 0)
            {
                Count--;
                Change();
            }
        }

        private void Change()
        {
            Publish(Count > 0);
        }
    }
}
