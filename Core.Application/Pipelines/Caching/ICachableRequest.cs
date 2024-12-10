namespace Core.Application.Pipelines.Caching;

public interface ICachableRequest
{
    string CacheKey { get; }
    bool ByPassCache { get; }
    TimeSpan? SlidingExpiration { get; }
}
