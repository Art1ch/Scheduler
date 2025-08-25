using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Faculty;

namespace Scheduler.Application.Queries.Faculty;

internal sealed class GetFacultyQueryHandler : IRequestHandler<GetFacultyQuery, GetFacultyResponse>
{
    private readonly IFacultyRepository _facultyRepository;
    private readonly IMapper _mapper;

    public GetFacultyQueryHandler(
        IFacultyRepository facultyRepository,
        IMapper mapper
    )
    {
        _facultyRepository = facultyRepository;
        _mapper = mapper;
    }

    public async Task<GetFacultyResponse> Handle(GetFacultyQuery query, CancellationToken cancellationToken)
    {
        var id = query.Request.Id;
        var entity = await _facultyRepository.GetByIdAsync(id, cancellationToken);
        var response = _mapper.Map<GetFacultyResponse>(entity);

        return response;
    }
}
