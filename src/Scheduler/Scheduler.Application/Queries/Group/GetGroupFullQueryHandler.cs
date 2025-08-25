using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Group;

namespace Scheduler.Application.Queries.Group;

internal sealed class GetGroupFullQueryHandler : IRequestHandler<GetGroupFullQuery, GetGroupFullResponse>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public GetGroupFullQueryHandler(
        IGroupRepository groupRepository,
        IMapper mapper
    )
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<GetGroupFullResponse> Handle(GetGroupFullQuery query, CancellationToken cancellationToken)
    {
        var id = query.Id;
        var entity = await _groupRepository.GetFullAsync(id, cancellationToken);
        var response = _mapper.Map<GetGroupFullResponse>(entity);

        return response;
    }
}
