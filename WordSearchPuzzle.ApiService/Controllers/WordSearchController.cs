using Microsoft.AspNetCore.Mvc;
using WordSearchPuzzle.ApiService.Contracts;
using WordSearchPuzzle.ApiService.DTOs;

namespace WordSearchPuzzle.ApiService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WordSearchController(IWordFinderFactory wordFinderFactory) : ControllerBase
    {
        [HttpPost]
        public ActionResult<IEnumerable<WordInfoResponseDto>> Find(WordFinderDto wordFinderDto) 
        {
            return Ok(wordFinderFactory.Create(wordFinderDto.Matrix).Find(wordFinderDto.WordStream));
        }

    }
}
