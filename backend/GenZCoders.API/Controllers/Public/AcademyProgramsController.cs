using GenZCoders.API.Common;
using GenZCoders.Application.Modules.AcademyPrograms.Queries.GetAllAcademyPrograms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenZCoders.API.Controllers.Public
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademyProgramsController : BaseApiController
    {
        private readonly GetAllAcademyProgramsUseCase _getAllAcademyProgramsUseCase;

        public AcademyProgramsController(GetAllAcademyProgramsUseCase getAllAcademyProgramsUseCase)
        {
            _getAllAcademyProgramsUseCase = getAllAcademyProgramsUseCase;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAcademyPrograms()
        {
            var response = await _getAllAcademyProgramsUseCase.ExecuteAsync(new GetAllAcademyProgramsQuery());

            return OkResponse(response);
        }


    }
}
