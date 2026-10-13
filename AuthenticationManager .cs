namespace E_Commerce
{
    public class AuthenticationManager
    {
        private List<User> _users;

        public AuthenticationManager()
        {
            Role adminRole = new Role { ID = 1, Name = "Admin" };
            Role userRole = new Role { ID = 2, Name = "User" };
            _users = new List<User> {
             new User { ID = 1, Name = "Mohammed", Email = "Mohammed@gmail.com", Password = "sa1234", Role = adminRole },
             new User { ID = 2, Name = "Ahmed", Email = "Ahmed@gmail.com", Password = "1234", Role = userRole },
             new User { ID = 3, Name = "Ali", Email = "Ali@gmail.com", Password = "1234", Role = userRole }
            };
        }

        public User Login(string email, string password)
        {
            foreach (User user in _users) {
                if (user.Email == email && user.Password == password) {
                    return user;
                }
            }
            return null!;
        }

    }
}
