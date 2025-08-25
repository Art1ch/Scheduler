using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Faculty;

namespace Scheduler.Application.Queries.Faculty;

public sealed class GetFacultyWithGroupsQueryHandler : IRequestHandler<GetFacultyWithGroupsQuery, GetFacultyWithGroupsResponse>
{
    private readonly IFacultyRepository _facultyRepository;
    private readonly IMapper _mapper;

    public GetFacultyWithGroupsQueryHandler(
        IFacultyRepository facultyRepository,
        IMapper mapper
    )
    {
        _facultyRepository = facultyRepository;
        _mapper = mapper;
    }

    public async Task<GetFacultyWithGroupsResponse> Handle(GetFacultyWithGroupsQuery request, CancellationToken cancellationToken)
    {
        var id = request.Request.Id;
        var entity = await _facultyRepository.GetWithGroupsAsync(id, cancellationToken);
        var response = _mapper.Map<GetFacultyWithGroupsResponse>(entity);

        return response;
    }
}
