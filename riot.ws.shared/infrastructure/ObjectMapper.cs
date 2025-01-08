
//namespace riot.ws.shared.infrastructure
//{
//    public class ObjectMapper : IObjectMapper
//    {
//        public TDestination Map<TSource, TDestination>(TSource source)
//        {
//            if (source == null)
//            {
//                throw new ArgumentNullException(nameof(source));
//            }

//            TDestination destination = Activator.CreateInstance<TDestination>();

//            foreach (var sourceProp in typeof(TSource).GetProperties())
//            {
//                var destinationProp = typeof(TDestination).GetProperty(sourceProp.Name);
//                if (destinationProp != null && destinationProp.CanWrite)
//                {
//                    destinationProp.SetValue(destination, sourceProp.GetValue(source));
//                }
//            }

//            return destination;
//        }
//    }
//}


using AutoMapper;

namespace riot.ws.shared.infrastructure
{
    public class ObjectMapper : IObjectMapper
    {
        private readonly IMapper _mapper;

        public ObjectMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TDestination>(source);
        }
    }
}
