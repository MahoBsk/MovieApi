using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handler.CastHanlers
{
    public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieContext _Context;
        public CreateCastCommandHandler(MovieContext context)
        {
            _Context = context;
        }
        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
            await _Context.Casts.AddAsync(new Cast
            {
                Biography = request.Biography,
                ImageUrl = request.ImageUrl,
                Neme = request.Neme,
                Overview = request.Overview,
                Surname = request.Surname,
                Title = request.Title,
            });
            //throw new NotImplementedException();
            await _Context.SaveChangesAsync();
        }
    }
}
