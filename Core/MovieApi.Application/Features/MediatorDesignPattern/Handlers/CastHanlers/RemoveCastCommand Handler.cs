using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handler.CastHanlers
{
    public class RemoveCastCommand_Handler : IRequestHandler<RemoveCastCommand>
    {
        private readonly MovieContext _context;
        public RemoveCastCommand_Handler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.CastId);
            //throw new NotImplementedException();
            _context.Casts.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
