using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handler.CastHanlers
{
    public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        private readonly MovieContext _context;
        public GetCastQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.ToListAsync();
            return values.Select(x => new GetCastQueryResult
            {
                Biography=x.Biography,
                CastId=x.CastId,
                ImageUrl=x.ImageUrl,
                Neme=x.Neme,
                Overview=x.Overview,
                Surname=x.Surname,
                Title=x.Title
            }).ToList();
            //throw new NotImplementedException();
        }
    }
}
