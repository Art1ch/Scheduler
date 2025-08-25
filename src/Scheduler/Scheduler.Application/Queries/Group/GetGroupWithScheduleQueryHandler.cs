using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Group;

namespace Scheduler.Application.Queries.Group;

internal sealed class GetGroupWithScheduleQueryHandler
    : IRequestHandler<GetGroupWithScheduleQuery, GetGroupWithScheduleResponse>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public GetGroupWithScheduleQueryHandler(
        IGroupRepository groupRepository,
        IMapper mapper
    )
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<GetGroupWithScheduleResponse> Handle(GetGroupWithScheduleQuery query, CancellationToken cancellationToken)
    {
        var id = query.Request.Id;
        var entity = await _groupRepository.GetWithScheduleAsync(id, cancellationToken);
        var response = _mapper.Map<GetGroupWithScheduleResponse>(entity);

        return response;
    }
}