using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.DataAccess.Concrete.EntityFramework;
using ToDoList.DataAccess.Abstract;
using ToDoList.DataAccess.Concrete.EntityFramework.Context;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;

namespace ToDoList.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<MyDataContext, AppUser>, IAppUserDal
    {
    }
}
