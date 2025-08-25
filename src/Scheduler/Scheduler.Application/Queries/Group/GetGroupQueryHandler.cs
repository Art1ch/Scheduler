using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Group;

namespace Scheduler.Application.Queries.Group;

internal sealed class GetGroupQueryHandler : IRequestHandler<GetGroupQuery, GetGroupResponse>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public GetGroupQueryHandler(
        IGroupRepository groupRepository,
        IMapper mapper
    )
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<GetGroupResponse> Handle(GetGroupQuery query, CancellationToken cancellationToken)
    {
        var id = query.Id;
        var entity = _groupRepository.GetByIdAsync(id, cancellationToken);
        var response = _mapper.Map<GetGroupResponse>(entity);

        return response;
    }
}