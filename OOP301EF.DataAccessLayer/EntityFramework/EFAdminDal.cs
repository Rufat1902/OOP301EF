using OOP301EF.DataAccessLayer.Abstract;
using OOP301EF.DataAccessLayer.Repositories;
using OOP301EF.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP301EF.DataAccessLayer.EntityFramework
{
    public class EFAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
