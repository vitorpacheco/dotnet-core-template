using System;
using System.Collections.Generic;
using dotnet_core_template.Models;
using dotnet_core_template.Repository;

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
        
        public Value Update(long id, Value value)
        {
            return this.repository.Update(value);
        }
        
        public void Remove(long id)
        {
            this.repository.Delete(id);
        }
    }
}