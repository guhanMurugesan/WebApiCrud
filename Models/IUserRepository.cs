using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebApi.Models
{
    interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        UserModel Get(int id);
        UserModel Add(UserModel item);
        void Remove(int id);
        bool Update(UserModel item);
    }
}
