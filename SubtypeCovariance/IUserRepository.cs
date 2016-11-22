using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public interface IUserRepository<TUser>
        where TUser : User
    {
        TUser GetByID(Guid id);
    }
}
