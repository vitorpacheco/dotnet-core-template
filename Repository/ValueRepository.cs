using System;
using System.Collections.Generic;
using System.Linq;
using dotnet_core_template.Models;

namespace dotnet_core_template.Repository
{
    public class ValueRepository
    {
        private readonly DatabaseContext context;
        
        public ValueRepository(DatabaseContext context)
        {
            this.context = context;
        }
        
        public List<Value> Get() => context.Values.ToList();
        
        public Value Get(long id) => context.Values.Where(value => value.Id == id).SingleOrDefault();
        
        public Value Insert(Value value)
        {
            context.Values.Add(value);
            return value;
        }
        
        public void Update(Value value)
        {
            context.Values.Update(value);
        }
        
        public void Delete(long id)
        {
            Value value = Get(id);
            
            context.Values.Remove(value);
        }
    }
}