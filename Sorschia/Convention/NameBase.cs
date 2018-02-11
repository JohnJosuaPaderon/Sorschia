namespace Sorschia.Convention
{
    public abstract class NameBase
    {
        static NameBase()
        {
            _FullNameBuilder = new FullNameBuilder();
            _InformalFullNameBuilder = new InformalFullNameBuilder();
            _MiddleInitialsBuilder = new MiddleInitialsBuilder();
        }

        private static readonly IFullNameBuilder _FullNameBuilder;
        private static readonly IInformalFullNameBuilder _InformalFullNameBuilder;
        private static readonly IMiddleInitialsBuilder _MiddleInitialsBuilder;

        private bool FullNameRefreshRequired;
        private bool InformalFullNameRefreshRequired;
        private bool MiddleInitialsRefreshRequired;

        private string _FirstName;
        private string _MiddleName;
        private string _LastName;
        private string _NameExtension;
        private string _FullName;
        private string _InformalFullName;
        private string _MiddleInitials;

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    FullNameRefreshRequired = true;
                    InformalFullNameRefreshRequired = true;
                }
            }
        }

        public string MiddleName
        {
            get { return _MiddleName; }
            set
            {
                if (_MiddleName != value)
                {
                    _MiddleName = value;
                    FullNameRefreshRequired = true;
                    InformalFullNameRefreshRequired = true;
                    MiddleInitialsRefreshRequired = true;
                }
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    FullNameRefreshRequired = true;
                    InformalFullNameRefreshRequired = true;
                }
            }
        }

        public string NameExtension
        {
            get { return _NameExtension; }
            set
            {
                if (_NameExtension != value)
                {
                    _NameExtension = value;
                    FullNameRefreshRequired = true;
                    InformalFullNameRefreshRequired = true;
                }
            }
        }

        public string FullName
        {
            get
            {
                if (FullNameRefreshRequired)
                {
                    _FullName = _FullNameBuilder.Build(this);
                    FullNameRefreshRequired = false;
                }

                return _FullName;
            }
        }

        public string InformalFullName
        {
            get
            {
                if (InformalFullNameRefreshRequired)
                {
                    _InformalFullName = _InformalFullNameBuilder.Build(this);
                    InformalFullNameRefreshRequired = false;
                }

                return _InformalFullName;
            }
        }

        public string MiddleInitials
        {
            get
            {
                if (MiddleInitialsRefreshRequired)
                {
                    _MiddleInitials = _MiddleInitialsBuilder.Build(this);
                    MiddleInitialsRefreshRequired = false;
                }

                return _MiddleInitials;
            }
        }
    }
}
