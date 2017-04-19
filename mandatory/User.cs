namespace mandatory
{
    class User
    {
        private int accessLevel;

        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password, int accessLevel)
        {
            this.Username = username;
            this.Password = password;
            this.AccessLevel = accessLevel;
        }

        public int AccessLevel
        {
            get
            {
                return this.accessLevel;
            }

            set
            {
                this.accessLevel = (value < 0) ? 0 : (value > 100) ? 100 : value;
            }
        }
    }
}
