using System.ComponentModel.DataAnnotations;

namespace WordSearchPuzzle.ApiService.DTOs
{
    public class WordFinderDto
    {
        [Required(ErrorMessage = "The [Matrix] field is required.")]
        public required IEnumerable<string> Matrix { get; set; }

        [Required(ErrorMessage = "The [WordStream] field is required.")]
        [Length(1, int.MaxValue, ErrorMessage = "There must be at least 1 word in the list.")]
        public required IEnumerable<string> WordStream { get; set; }
    }
}
