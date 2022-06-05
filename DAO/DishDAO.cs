using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DTO.Migrations;
using GUI;
using GUI.Maps;
using GUI.Models;

namespace DAO
{
    public class DishDAO
    {
        private static DishDAO instance;

        Context db = new Context();

        public static DishDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DishDAO();
                return DishDAO.instance;
            }
            private set => instance = value;
        }
        //--------------------------------------------

        public List<Dish> GetListDish()
        {
            return db.Dishes.ToList();
        }
        public bool addDish(Dish d)// them Dish
        {
            try
            {
                if (d != null)
                {
                    db.Dishes.Add(d);
                    db.SaveChanges();
                    return true;
                }
                return false;

            }
            catch 
            {
                return false;
            }
        }
        public bool DeleteDish(string dishId)// xóa 1 Dish boi Dish id
        {
            Dish e = db.Dishes.Where(d => d.dishId == dishId).FirstOrDefault();
            try
            {
                if (e != null)
                {
                    db.Dishes.Remove(e);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }
        public bool editDish(Dish c)// sua 1 Dish
        {
            try
            {
                if (c != null)
                {
                    Dish cTmp = db.Dishes.Where(d => d.dishId == c.dishId).FirstOrDefault();
                    if (cTmp == null)
                        return false;
                    cTmp.dishId = c.dishId;
                    cTmp.dishName = c.dishName;
                    cTmp.price = c.price;
                    cTmp.categoryId = cTmp.categoryId;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }

        public int GetDishID(string dishId, ref string error)
        {
            try
            {
                if (dishId != null)
                {
                    var x = db.Dishes.Where(n => n.dishId == dishId).FirstOrDefault();
                    error = "Get Employee Success";
                    return 1;
                }
                return -1;
            }
            catch 
            {
                return -1;
            }

        }
        public Dish FindDish(string DishId)
        {
            try
            {
                if (DishId != null)
                {
                    return db.Dishes.Where(x => x.dishId == DishId).FirstOrDefault();
                }
                return null;
            }
            catch 
            {
                return null;
            }

        }

        public List<Dish> Search(string x, int k)
        {
            try
            {
                if (k == 0)
                {
                    // Food
                    if (x != null)
                    {
                        var result = db.Dishes.Where(f => f.dishName.StartsWith(x)).ToList();
                        return result;
                    }
                    return db.Dishes.ToList();
                }
                return null;

            }
            catch
            {
                return null;
            }
        }

    }
}
