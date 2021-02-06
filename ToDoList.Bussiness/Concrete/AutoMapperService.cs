using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Bussiness.Abstract;
using ToDoList.Bussiness.EntityMapper.AutoMapper;

namespace ToDoList.Bussiness.Concrete
{
    public class AutoMapperService : IAutoMapperService
    {
        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }
    }
}
