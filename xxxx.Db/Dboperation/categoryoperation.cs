using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xxxx.Models;

namespace xxxx.Db.Dboperation
{
    public class categoryoperation
    {
        public int savecategory(Categorymodel model) 
        {
            using (var context=new EcomdbEntities()) 
            {
                Category cc = new Category() 
                {
                Name=model.Name,
                Description=model.Description,
                ProductID=model.ProductID
                };
                context.Category.Add(cc);
                context.SaveChanges();
                return cc.Id;
            }
        }
    }
}
