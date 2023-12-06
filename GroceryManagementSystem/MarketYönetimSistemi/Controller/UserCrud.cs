using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Controller
{

    public class UserCrud : ICrud<User>
    {
        DataContext db = new DataContext();
        public bool Add(User entity)
        {
            if (entity != null
                && !String.IsNullOrWhiteSpace(entity.Name)
                && !String.IsNullOrWhiteSpace(entity.Surname)
                && !String.IsNullOrWhiteSpace(entity.Description)
                && !String.IsNullOrWhiteSpace(entity.Email)
                && !String.IsNullOrWhiteSpace(entity.Password)
                )
            {
                db.User.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return db.User.Where(x => x.IsDelete == false && x.RoleId == 3).ToList();
        }

        public User GetById(int id)
        {
            var user = db.User.Find(id);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public bool Update(User entity, int id)
        {
            var existingUser = db.User.Find(id);

            if (existingUser != null
                && !String.IsNullOrWhiteSpace(entity.Name)
                && !String.IsNullOrWhiteSpace(entity.Surname)
                && !String.IsNullOrWhiteSpace(entity.Description)
                && !String.IsNullOrWhiteSpace(entity.Email)
                && !String.IsNullOrWhiteSpace(entity.Password)
                )
            {
                existingUser.Name = entity.Name;
                existingUser.Surname = entity.Surname;
                existingUser.Description = entity.Description;
                existingUser.Email = entity.Email;
                existingUser.Password = entity.Password;
                existingUser.RoleId = entity.RoleId;
                existingUser.IsStatus = entity.IsStatus;
                existingUser.Image = entity.Image;

                db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool UpdateIsDelete(int userId)
        {
            var userToUpdate = db.User.FirstOrDefault(x => x.Id == userId);

            if (userToUpdate != null)
            {
                userToUpdate.IsDelete = true;
                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
