﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        void Add();
        void Update(T customer);
        void Delete(T customer);
    }
}