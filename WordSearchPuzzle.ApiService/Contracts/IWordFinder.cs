using WordSearchPuzzle.ApiService.DTOs;

namespace WordSearchPuzzle.ApiService.Contracts
{
    public interface IWordFinder
    { 
        public IEnumerable<WordInfoResponseDto> Find(IEnumerable<string> wordStream);
    }
}
