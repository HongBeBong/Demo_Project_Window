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
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        Context db = new Context();

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return CategoryDAO.instance;
            }
            private set => instance = value;
        }
        //--------------------------------------------

        public List<Category> getListCategory()
        {
            return db.Categories.ToList();
        }

        public bool addCategory(Category a)// them Category
        {
            try
            {


                if (a != null)
                {
                    db.Categories.Add(a);
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
        public bool DeleteCategory(string CategoryId)// xóa 1 Category boi category id
        {
            Category e = db.Categories.Where(d => d.CategoryId == CategoryId).FirstOrDefault();
            try
            {
                if (e != null)
                {
                    db.Categories.Remove(e);
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
        public bool editCategory(Category c)// sua 1 Category
        {
            try
            {
                if (c != null)
                {
                    Category cTmp = db.Categories.Where(d => d.CategoryId == c.CategoryId).FirstOrDefault();
                    if (cTmp == null)
                        return false;
                    cTmp.CategoryId = c.CategoryId;
                    cTmp.CategoryName = c.CategoryName;
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

        public int GetCategoryID(string CategoryId, ref string error)
        {
            try
            {
                if (CategoryId != null)
                {
                    var x = db.Categories.Where(n => n.CategoryId == CategoryId).FirstOrDefault();
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

        public Category FindCategory(string CategoryId)
        {
            try
            {
                if (CategoryId != null)
                {
                    return db.Categories.Where(x => x.CategoryId == CategoryId).FirstOrDefault();
                }
                return null;
            }
            catch 
            {
                return null;
            }

        }
        public List<Category> Search(string x, int k)
        {
            try
            {
                if (k == 0)
                {
                    // Food
                    if (x != null)
                    {
                        var result = db.Categories.Where(f => f.CategoryName.StartsWith(x)).ToList();
                        return result;
                    }
                    return db.Categories.ToList();
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
