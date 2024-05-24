namespace WebBarbellApplication.Manager
{
    public interface IAppManager
    {
        Task<List<int>> SimpleCalculateBarbell(int weight);
        Task<List<int>> CalculateBarbell(int weight);
        Task<List<string>> BarbellOutput(List<int> pancakes);
    }
}
