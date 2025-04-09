using FadakTest.Messages.Author;
using Microsoft.AspNetCore.Mvc;

namespace FadakTest.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : Controller
    {
        private readonly IMediatRSenderService _mediatRSenderService;
        public AuthorsController(IMediatRSenderService mediatRSenderService)
        {
            _mediatRSenderService = mediatRSenderService;
        }

        [HttpPost("create")]
        public async Task<ActionResult<CreateAuthorResponse>> Create([FromBody] CreateAuthorRequest request, CancellationToken cancellationToken)
        {
            return await _mediatRSenderService.SendWithMediator<FadakTest.AppService.Author.Create.CreateAuthorRequest,
                    CreateAuthorRequest, CreateAuthorResponse>(request);
        }

        [HttpPut("update")]
        public async Task<ActionResult<UpdateAuthorResponse>> Update([FromBody] UpdateAuthorRequest request, CancellationToken cancellationToken)
        {
            return await _mediatRSenderService.SendWithMediator<FadakTest.AppService.Author.Update.UpdateAuthorRequest,
                    UpdateAuthorRequest, UpdateAuthorResponse>(request);
        }

        [HttpGet("get")]
        public async Task<ActionResult<GetByIdAuthorResponse>> GetById(GetByIdAuthorRequest request, CancellationToken cancellationToken)
        {
            return await _mediatRSenderService.SendWithMediator<FadakTest.AppService.Author.GetById.GetByIdAuthorRequest,
                    GetByIdAuthorRequest, GetByIdAuthorResponse>(request);
        }

        [HttpGet("getall")]
        public async Task<ActionResult<GetAllAuthorResponse>> GetAll(GetAllAuthorRequest request, CancellationToken cancellationToken)
        {
            return await _mediatRSenderService.SendWithMediator<FadakTest.AppService.Author.GetAll.GetAllAuthorRequest,
                    GetAllAuthorRequest, GetAllAuthorResponse>(request);
        }

        [HttpGet("authorsbooks")]
        public async Task<ActionResult<GetAuthorsBooksResponse>> GetAuthorsBooks(GetAuthorsBooksRequest request, CancellationToken cancellationToken)
        {
            return await _mediatRSenderService.SendWithMediator<FadakTest.AppService.Author.GetAuthorsBooks.GetAuthorsBooksRequest,
                    GetAuthorsBooksRequest, GetAuthorsBooksResponse>(request);
        }
    }
}