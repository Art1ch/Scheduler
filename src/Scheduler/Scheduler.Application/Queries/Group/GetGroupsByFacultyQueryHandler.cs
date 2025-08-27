using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Group;

namespace Scheduler.Application.Queries.Group;

internal sealed class GetGroupsByFacultyQueryHandler
    : IRequestHandler<GetGroupsByFacultyQuery, IEnumerable<GetGroupResponse>>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public GetGroupsByFacultyQueryHandler(
        IGroupRepository groupRepository,
        IMapper mapper
    )
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetGroupResponse>> Handle(
        GetGroupsByFacultyQuery query,
        CancellationToken cancellationToken
    )
    {
        var facultyId = query.Request.FacultyId;
        var entities = await _groupRepository.GetAllGroupsByFacultyId(facultyId, cancellationToken);
        var response = _mapper.Map<List<GetGroupResponse>>(entities);

        return response;
    }
}