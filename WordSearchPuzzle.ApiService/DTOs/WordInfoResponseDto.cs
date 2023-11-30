namespace WordSearchPuzzle.ApiService.DTOs
{
    public class WordInfoResponseDto
    {
        public required string Word { get; set; }
        public required List<Coordinate> Coordinates { get; set; }
    }

    public class Coordinate
    {
        public required int X { get; set; }
        public required int Y { get; set; }
    }
}
