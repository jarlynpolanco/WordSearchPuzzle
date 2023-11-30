namespace WordSearchPuzzle.ApiService.Contracts
{
    public interface IWordFinderFactory
    {
        IWordFinder Create(IEnumerable<string> wordStream);
    }
}
