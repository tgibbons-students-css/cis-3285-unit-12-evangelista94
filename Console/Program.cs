
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubtypeCovariance;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {

            IEntityRepository<Entity> entityRepository = new EntityRepository();
            Entity myEntity = entityRepository.GetByID(Guid.NewGuid());

            myEntity.Name = "Tom";
            Console.WriteLine("New entity ID: " + myEntity.ID.ToString());
            Console.WriteLine("New entity Name: " + myEntity.Name);



            IEntityRepository<User> UserRepository = new UserRepository();
            User myUser = UserRepository.GetByID(Guid.NewGuid());

            myUser.Name = "Eva";
            myUser.EmailAddress = "echicheko@css.edu";
            Console.WriteLine("New entity ID: " + myUser.ID.ToString());
            Console.WriteLine("New entity Name: " + myUser.Name);
            Console.WriteLine("New entity EmailAddress: " + myUser.EmailAddress);
        }
    }
}
