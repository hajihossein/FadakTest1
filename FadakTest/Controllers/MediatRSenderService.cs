using AutoMapper;
using FadakTest.AppService;
using MediatR;

namespace FadakTest.Controllers
{
    public interface IMediatRSenderService
    {
        Task<TApiResponse> SendWithMediator<TAppRequest, TApiRequest, TApiResponse>(TApiRequest request)
            where TAppRequest : BaseRequest;
    }
    public class MediatRSenderService : IMediatRSenderService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public MediatRSenderService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<TApiResponse> SendWithMediator<TAppRequest, TApiRequest, TApiResponse>(TApiRequest request)
            where TAppRequest : BaseRequest
        {
            var appRequest = _mapper.Map<TAppRequest>(request);

            var appResponse = await _mediator.Send(appRequest);
            var apiResponse = _mapper.Map<TApiResponse>(appResponse);
            return apiResponse;
        }

    }
}
