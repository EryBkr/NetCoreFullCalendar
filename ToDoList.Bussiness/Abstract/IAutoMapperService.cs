using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Bussiness.Abstract
{
    public interface IAutoMapperService
    {
        IMapper Mapper { get; }
    }
}
