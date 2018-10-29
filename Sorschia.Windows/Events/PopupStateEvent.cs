using Prism.Events;

namespace Sorschia.Events
{
    public sealed class PopupStateEvent : PubSubEvent<bool>
    {
        private int Count { get; set; }

        public void Open()
        {
            Count++;
            Change();
        }

        public void Close()
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
