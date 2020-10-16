using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Facebook
{
    public class List
    {
        public class Query : IRequest<List<Facebook>> {}
        public class Handler : IRequestHandler<Query, List<Facebook>>
        {
            private readonly DataContext context;
            public Handler(DataContext context) => this.context = context;

            public Task<List<Facebook>> Handle(Query request, CancellationToken cancellationToken)
            {
                return this.context.Facebook.ToListAsync();
            }
        }
    }
}