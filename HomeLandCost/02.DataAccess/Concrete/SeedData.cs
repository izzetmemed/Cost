using HomeLandCost._02.DataAccess.Concrete;
using HomeLandCost._03.Model;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeLandCost
{
    public class SeedData
    {
        private static UserModelDb _userModelAccess = new UserModelDb();

        public static async Task SeedMembershipAsync()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build();
            string password = configuration["PasswordLogin:Login"];

            if (!_userModelAccess.GetAll().Any())
                {
                   
                    CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

                    var newUser = new UserModel
                    {
                        UserName = "HomeIzzet",
                        PasswordHash = passwordHash,
                        PasswordSalt = passwordSalt,
                        FirstName = "Izzet",
                        LastName = "Memmedov",
                        EmailConfirmed = true
                    };

                    _userModelAccess.Add(newUser);
                }
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
