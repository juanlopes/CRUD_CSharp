namespace DataAccessObject
{
    public class Parametros
    {
        private string Host { get => ""; } //SET HOST MYSQL HERE
        private string User { get => ""; } //SET USER FROM DATABASE
        private string Password { get => ""; } //SET PASSWORD FROM DATABASE

        public string getHost() => Host;
        public string getUser() => User;
        public string getPassword() => Password;
    }
}
