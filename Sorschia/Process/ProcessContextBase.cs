using System;

namespace Sorschia.Process
{
    /// <summary>
    /// Base-class for process context
    /// </summary>
    public abstract class ProcessContextBase : IProcessContext
    {
        public ProcessContextBase()
        {
            Key = Guid.NewGuid();
            Status = ProcessContextStatus.NotSet;
        }

        /// <summary>
        /// Unique identifier of the <see cref="ProcessContextBase"/>
        /// </summary>
        public Guid Key { get; }

        /// <summary>
        /// Status of the process
        /// </summary>
        public ProcessContextStatus Status { get; internal set; }

        public virtual void Dispose()
        {

        }

        public static bool operator ==(ProcessContextBase left, ProcessContextBase right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProcessContextBase left, ProcessContextBase right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is ProcessContextBase value)
            {
                return (Equals(Key, default(Guid)) || Equals(value.Key, default(Guid))) ? false : Equals(Key, value.Key);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
