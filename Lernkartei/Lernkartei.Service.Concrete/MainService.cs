﻿using Lernkartei.Common.AutoMapper;
using Lernkartei.Domain.Abstraction;
using Lernkartei.Service.Abstract;

namespace Lernkartei.Service.Concrete
{
    public class MainService<Entity,Dto> : IMainService<Dto> where Entity : class,new()
        where Dto : class ,new()
        
    {
        private readonly IRepository<Entity> _repository;
        public MainService(IRepository<Entity> repository)
        {
            _repository = repository;
        }
        public Dto Add(Dto entity)
        {
            return AutoMapperMappingExtensions.MapTo<Entity, Dto>(_repository.Add(AutoMapperMappingExtensions.MapTo<Dto, Entity>(entity)));
        }
        public Dto Update(Dto entity)
        {
            return AutoMapperMappingExtensions.MapTo<Entity, Dto>(_repository.Update(AutoMapperMappingExtensions.MapTo<Dto, Entity>(entity)));
        }
        public bool Delete(dynamic id)
        {
            var entity = _repository.GetById(id);
            return _repository.Delete(entity);
        }

        public IList<Dto> GetAll()
        {
            return  _repository.GetAll().ToList().MapListTo<Entity, Dto>();
        }

        public Dto GetById(dynamic id)
        {
            return AutoMapperMappingExtensions.MapTo<Entity, Dto>(_repository.GetById(id));
        }
        
    }
}
