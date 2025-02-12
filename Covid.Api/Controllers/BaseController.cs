﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Covid.Api.Controllers
{
  #nullable disable
    public class BaseController : Controller
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
