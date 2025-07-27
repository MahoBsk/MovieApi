using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public GetMovieByIdQuery(int movieId)
        {
            MovieId = movieId;
        }

        public int MovieId { get; }

        public override bool Equals(object? obj)
        {
            return obj is GetMovieByIdQuery query &&
                   MovieId == query.MovieId;
        }

        public override int GetHashCode()
        {
            return MovieId.GetHashCode();
        }
    }

}
