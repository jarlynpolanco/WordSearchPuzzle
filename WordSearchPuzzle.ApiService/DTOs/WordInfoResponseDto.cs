namespace WordSearchPuzzle.ApiService.DTOs
{
    public record WordInfoResponseDto(string Word, List<Coordinate> Coordinates);

    public record Coordinate(int X, int Y);
}
