using Microsoft.AspNetCore.Mvc;
using pickamood.Services;

namespace pickamood.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoodController : ControllerBase
    {
        private readonly MoodManager _moodManager;

        public MoodController(MoodManager moodManager)
        {
            _moodManager = moodManager;
        }
        [HttpGet("/citation/{mood}")]
        public IActionResult GetCitation(string mood) 
        {
            var citation = _moodManager.GetRandomCitation(mood);
            if (citation == null)
            {
                return BadRequest("Oups, il semblerait qu'il n'y ait pas l'humeur que tu ressens aujourd'hui... ");
            }
            return Ok(citation);
        }

        [HttpGet("/activities/{mood}")]
        public IActionResult GetActivites(string mood)
        {
            var activites = _moodManager.GetListeActivites(mood);
            if (activites == null)
            {
                return BadRequest("Oups, il semblerait qu'il n'y ait pas l'humeur que tu ressens aujourd'hui... Nous ne pouvons malheureusement pas te proposer d'activités. ");
            }
            return Ok(activites); 
        }
    }
}
