
namespace riot.ws.shared.infrastructure
{
    public interface IObjectMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
    }

}
