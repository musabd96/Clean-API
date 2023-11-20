using Application.Queries.Dogs;
using Application.Queries.Dogs.GetDogById;
using Application.Queries.Dogs.UpdateDogById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        internal readonly IMediator _mediatR;

        public DogsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }



        // Det är API endpooint där vi håmta alla hunder from MockDatabase 
        [HttpGet]
        [Route("getAllDog")]
        public async Task<IActionResult> GetAllDogs()
        {
            return Ok(await _mediatR.Send(new GetAllDogsQuery()));
        }


        [HttpGet]
        [Route("getDogById/{dogId}")]
        public async Task<IActionResult> GetDogById(Guid dogId)
        {
            return Ok(await _mediatR.Send(new GetDogByIdQuery(dogId)));
        }


        [HttpPost]
        [Route("updateDogById/{id}")]
        public async Task<IActionResult> UpdateDogById(Guid dogId, string name)
        {
            return Ok(await _mediatR.Send(new UpdateDogByIdQuery(dogId, name)));
        }






        //// POST api/<DogsController>
        //[HttpPost]
        //[Route("updateDogById/{id}")]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<DogsController>/5
        //[HttpPut]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<DogsController>/5
        //[HttpDelete]
        //[Route("deleteDogById/{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
