using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Interceptors
{
    public class EntityIdInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            SetIds(eventData.Context);
            return base.SavingChanges(eventData, result);
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            SetIds(eventData.Context);
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        private static void SetIds(DbContext context)
        {
            foreach (EntityEntry entry in context.ChangeTracker.Entries())
            {
                if (entry.Entity is IEntity entity && entry.State == EntityState.Added && entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
            }
        }
    }
}