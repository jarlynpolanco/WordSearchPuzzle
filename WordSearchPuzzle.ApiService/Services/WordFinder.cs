using WordSearchPuzzle.ApiService.Contracts;
using WordSearchPuzzle.ApiService.DTOs;

namespace WordSearchPuzzle.ApiService.Services
{
    public class WordFinder(IEnumerable<string> matrix) : IWordFinder
    {
        private readonly string[][] _matrix = matrix.Select(row => row.Split(" ")).ToArray();

        public IEnumerable<WordInfoResponseDto> Find(IEnumerable<string> wordStream)
        {
            var uniqueWords = new HashSet<string>(wordStream);
            foreach (var word in uniqueWords)
            {
                for (int x = 0; x < _matrix.Length; x++)
                {
                    var hWord = string.Join("", _matrix[x]);
                    var vWord = string.Join("", _matrix.Select(row => row[x]));

                    var coordinates = GetWordCoordinates(x, hWord, word, false)
                        .Concat(GetWordCoordinates(x, vWord, word, true));

                    if (coordinates.Any())
                    {
                        yield return new WordInfoResponseDto(word, coordinates.ToList());
                    }
                }
            }
        }

        private static IEnumerable<Coordinate> GetWordCoordinates(int x, string lineWord, string word, bool isVertical)
        {
            var index = lineWord.IndexOf(word);
            if (index == -1)
            {
                index = lineWord.IndexOf(string.Join("", word.Reverse()));
                if (index == -1)
                {
                    return Enumerable.Empty<Coordinate>();
                }
            }

            return Enumerable.Range(0, word.Length)
                .Select(num => new Coordinate(isVertical ? index + num : x, isVertical ? x : index + num));
        }
    }
}
