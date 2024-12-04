using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public void Delete(ICategoryDal entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(ICategoryDal entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ICategoryDal entity)
        {
            throw new NotImplementedException();
        }

        List<ICategoryDal> IGenericDal<ICategoryDal>.GetAll()
        {
            throw new NotImplementedException();
        }

        ICategoryDal IGenericDal<ICategoryDal>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
