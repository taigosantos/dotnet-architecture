﻿using Project.UnitOfWorkProject.Entities;
using Project.UnitOfWorkProject.Repositories;
using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Project.UnitOfWorkProject.Core
{
    public class UnitOfWork : IUnitOfWorkContextAware
    {
        private bool _disposed;
        private readonly DbContext context;
        private readonly IResolver resolver;

        public UnitOfWork(DbContext context, IResolver resolver)
        {
            Debug.Print("[UnitOfWork] Started...");

            this.context = context;
            this.resolver = resolver;
        }

        public TRepository GetRepository<TRepository>() where TRepository : IRepository
        {
            var repository = resolver.Resolve<TRepository>(typeof(TRepository));
            repository.SetUnitOfWork(this);

            return repository;
        }

        public IDbSet<TEntity> GetDbSet<TEntity>() where TEntity : Entity
        {
            return context.Set<TEntity>();
        }

        public int Commit()
        {
            return context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Debug.Print("[UnitOfWork] Disposed!");

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            _disposed = true;
        }


    }
}
