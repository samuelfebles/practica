namespace practica
{
    public class User
    {
        public string username { get; set;}
       public string password { get; set; }

        //constructor
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        //default constructor
        public User(){
            //default constructor
        }

    }
}