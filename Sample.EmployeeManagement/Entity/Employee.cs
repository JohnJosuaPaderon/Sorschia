using Sorschia.Convention;
using Sorschia.Entity;

namespace EmployeeManagement.Entity
{
    public class Employee : NameBase, IEntity<long>
    {
        public long Id { get; set; }
        public Department Department { get; set; }
        public decimal Salary { get; set; }

        public static bool operator ==(Employee left, Employee right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Employee left, Employee right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is Employee value)
            {
                return (Equals(Id, default(long)) || Equals(value.Id, default(long))) ? false : Equals(Id, value.Id);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
