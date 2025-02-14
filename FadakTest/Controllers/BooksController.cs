using FadakTest.Messages.Book;
using Microsoft.AspNetCore.Mvc;


namespace FadakTest.Controllers
{
    public class BooksController : Controller
    {
        private readonly IMediatRSenderService _mediatRSenderService;
        public BooksController(IMediatRSenderService mediatRSenderService)
        {
            _mediatRSenderService = mediatRSenderService;
        }


        [HttpPost("create")]
        public async Task<ActionResult<CreateBookResponse>> Create([FromBody] CreateBookRequest request, CancellationToken cancellationToken)
        {
            return await _mediatRSenderService.SendWithMediator<FadakTest.AppService.Book.Create.CreateBookRequest,
                    CreateBookRequest, CreateBookResponse>(request);
        }

        [HttpPut("update")]
        public async Task<ActionResult<UpdateBookResponse>> Update([FromBody] UpdateBookRequest request, CancellationToken cancellationToken)
        {
            return await _mediatRSenderService.SendWithMediator<FadakTest.AppService.Book.Update.UpdateBookRequest,
                    UpdateBookRequest, UpdateBookResponse>(request);
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<GetByIdBookResponse>> GetById(GetByIdBookRequest request, CancellationToken cancellationToken)
        {
            return await _mediatRSenderService.SendWithMediator<FadakTest.AppService.Book.GetById.GetByIdBookRequest,
                    GetByIdBookRequest, GetByIdBookResponse>(request);
        }

        [HttpGet("books")]
        public async Task<ActionResult<GetAllBookResponse>> GetAll(GetAllBookRequest request, CancellationToken cancellationToken)
        {
            return await _mediatRSenderService.SendWithMediator<FadakTest.AppService.Book.GetAll.GetAllBookRequest,
                    GetAllBookRequest, GetAllBookResponse>(request);
        }

    }
}