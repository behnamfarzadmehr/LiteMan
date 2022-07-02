using AutoMapper;
using System.Collections.Generic;

namespace Lernkartei.Common.AutoMapper
{
    public static class AutoMapperMappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TSource, TDestination>();
            });
            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TSource, TDestination>();
            });
            IMapper iMapper = config.CreateMapper();
            return iMapper.Map(source, destination);
        }
        public static List<TDestination> MapListTo<TSource, TDestination>(this List<TSource> source)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TSource, TDestination>();
            });
            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<List<TSource>, List<TDestination>>(source);
        }
        public static IList<TDestination> MapListTo<TSource, TDestination>(this IList<TSource> source)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TSource, TDestination>();
            });
            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<IList<TSource>, IList<TDestination>>(source);
        }
    }
}
