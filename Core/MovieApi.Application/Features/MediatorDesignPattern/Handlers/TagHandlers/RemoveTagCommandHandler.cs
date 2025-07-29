using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class RemoveTagCommand_Handler : IRequestHandler<RemoveTagCommand>
    {
        private readonly MovieContext _context;
        public RemoveTagCommand_Handler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var tag = await _context.Tags.FindAsync(request.TagId);
            if (tag == null)
            {
                // Hata fırlatılabilir ya da sessizce dönülebilir. Burada özel hata fırlatıyoruz:
                throw new Exception($"Etiket bulunamadı. Id: {request.TagId}");
            }

            _context.Tags.Remove(tag);
            await _context.SaveChangesAsync();
        }
    }

}
