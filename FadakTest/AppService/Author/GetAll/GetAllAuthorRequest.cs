﻿using MediatR;

namespace FadakTest.AppService.Author.GetAll
{
    public class GetAllAuthorRequest : BaseRequest, IRequest<GetAllAuthorResponse>
    {
    }
}
