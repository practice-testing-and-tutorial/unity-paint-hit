namespace Gupi.Infrastructure.SaveSystem
{
    public interface ISaveSystem
    {
        void Save<T>(T data);
        T Load<T>();
    }
}
