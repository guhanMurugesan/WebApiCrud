using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models
{
    public class UserRepository :IUserRepository
    {
        private List<UserModel> products = new List<UserModel>();
        private int _nextId = 1;
        /// <summary>
        /// 
        /// </summary>
        public UserRepository()
        {
          Add(new UserModel(){ UserId = 100, Username = "guhan", Location = "chennai", Age = 23});
          Add(new UserModel() { UserId = 101, Username = "Bala", Location = "chennai", Age = 22 });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserModel> GetAll()
        {
            return products;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserModel Get(int id)
        {
            return products.Find(p => p.UserId == id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public UserModel Add(UserModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.UserId = _nextId++;
            products.Add(item);
            return item;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            products.RemoveAll(p => p.UserId == id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(UserModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = products.FindIndex(p => p.UserId == item.UserId);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);
            return true;
        }
    }
}