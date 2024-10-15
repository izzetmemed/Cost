using HomeLandCost._01.Core.Concrete;
using HomeLandCost._03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLandCost._02.DataAccess.Concrete
{
    internal class UserModelDb : UserBaseRepository<UserModel, MyDbContext>
    {
    }
}
