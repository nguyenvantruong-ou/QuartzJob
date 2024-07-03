namespace Quartz.NET.Quartz
{
    public interface IJob
    {
        Task Execute();
    }
}
