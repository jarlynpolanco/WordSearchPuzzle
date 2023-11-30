using WordSearchPuzzle.ApiService.Contracts;

namespace WordSearchPuzzle.ApiService.Services
{
    public class WordFinderFactory : IWordFinderFactory
    {
        public IWordFinder Create(IEnumerable<string> wordStream) => new WordFinder(wordStream);
    }
}
