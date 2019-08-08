using System;
using System.Collections.Generic;
using dotnet_core_template.Models;
using dotnet_core_template.Repositories;

namespace dotnet_core_template.Services
{
    public class ValueService
    {
        private readonly ValueRepository repository;
        
        public ValueService(ValueRepository repository)
        {
            this.repository = repository;
        }
        
        public List<Value> Get()
        {
            return this.repository.Get();
        }
        
        public Value Get(long id)
        {
            return this.repository.Get(id);
        }
        
        public Value Create(Value value)
        {
            return this.repository.Insert(value);
        }
        
        public void Update(long id, Value value)
        {
            this.repository.Update(value);
        }
        
        public void Remove(long id)
        {
            this.repository.Delete(id);
        }
    }
}
