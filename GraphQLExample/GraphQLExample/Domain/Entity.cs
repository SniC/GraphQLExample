using System;

namespace GraphQLExample.Domain
{
    public abstract class Entity
    {
        protected Entity() { /* EF Core Constructor */ }

        public Guid Id { get; set; }
    }
}
