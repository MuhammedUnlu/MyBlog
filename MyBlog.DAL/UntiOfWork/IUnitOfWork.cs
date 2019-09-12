using Microsoft.EntityFrameworkCore;
using MyBlog.DAL.Reposiories;
using MyBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DAL.UntiOfWork
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        TContext DbContext { get; }
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;

        int SaveChanges();
    }
}
