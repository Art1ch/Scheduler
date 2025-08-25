using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Group;

namespace Scheduler.Application.Queries.Group;

internal sealed class GetGroupWithFacultyQueryHandler
    : IRequestHandler<GetGroupWithFacultyQuery, GetGroupWithFacultyResponse>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public GetGroupWithFacultyQueryHandler(
        IGroupRepository groupRepository,
        IMapper mapper
    )
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<GetGroupWithFacultyResponse> Handle(GetGroupWithFacultyQuery query, CancellationToken cancellationToken)
    {
        var id = query.Request.Id;
        var entity = await _groupRepository.GetWithFacultyAsync(id, cancellationToken);
        var response = _mapper.Map<GetGroupWithFacultyResponse>(entity);

        return response;
    }
}
