using WordSearchPuzzle.ApiService.Contracts;
using WordSearchPuzzle.ApiService.DTOs;

namespace WordSearchPuzzle.ApiService.Services
{
    public class WordFinder(IEnumerable<string> matrix) : IWordFinder
    {
        private readonly string[][] _matrix = matrix.Select(row => row.Split(" ")).ToArray();

        public IEnumerable<WordInfoResponseDto> Find(IEnumerable<string> wordStream)
        {
            return FindWords(wordStream);
        }

        private IEnumerable<WordInfoResponseDto> FindWords(IEnumerable<string> wordStream)
        {
            var uniqueWords = new HashSet<string>(wordStream);

            for (int x = 0; x < _matrix.Length; x++)
            {
                for (int y = 0; y < _matrix[x].Length; y++)
                {
                    foreach (var word in uniqueWords)
                    {
                        var coordinates = FindWordCoordinates(word, x, y);
                        if (coordinates != null)
                        {
                            yield return new WordInfoResponseDto { Word = word, Coordinates = coordinates };
                        }
                    }
                }
            }
        }

        private List<Coordinate>? FindWordCoordinates(string word, int startX, int startY)
        {
            for (int directionX = -1; directionX <= 1; directionX++)
            {
                for (int directionY = -1; directionY <= 1; directionY++)
                {
                    if (directionX == 0 && directionY == 0)
                    {
                        continue;
                    }

                    var coordinates = CheckWordInDirection(word, startX, startY, directionX, directionY);
                    if (coordinates != null)
                    {
                        return coordinates;
                    }
                }
            }

            return null;
        }

        private List<Coordinate>? CheckWordInDirection(string word, int startX, int startY, int directionX, int directionY)
        {
            int currentX = startX;
            int currentY = startY;

            int wordLength = word.Length;

            if (currentX + (wordLength - 1) * directionX < 0 ||
                currentX + (wordLength - 1) * directionX >= _matrix.Length ||
                currentY + (wordLength - 1) * directionY < 0 ||
                currentY + (wordLength - 1) * directionY >= _matrix[currentX].Length)
            {
                return null;
            }

            var coordinates = new List<Coordinate>();

            for (int i = 0; i < wordLength; i++)
            {
                if (word[i] == '\0' || _matrix[currentX][currentY][0] != word[i])
                {
                    return null;
                }

                coordinates.Add(new Coordinate { X = currentX, Y = currentY });

                currentX += directionX;
                currentY += directionY;
            }

            return coordinates;
        }
    }
}
