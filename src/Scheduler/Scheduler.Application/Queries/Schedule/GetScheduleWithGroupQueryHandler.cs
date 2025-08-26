using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Schedule;

namespace Scheduler.Application.Queries.Schedule;

internal sealed class GetScheduleWithGroupQueryHandler
    : IRequestHandler<GetScheduleWithGroupQuery, GetScheduleWithGroupResponse>
{
    private readonly IScheduleRepository _scheduleRepository;
    private readonly IMapper _mapper;

    public GetScheduleWithGroupQueryHandler(
        IScheduleRepository scheduleRepository,
        IMapper mapper
    )
    {
        _scheduleRepository = scheduleRepository;
        _mapper = mapper;
    }

    public async Task<GetScheduleWithGroupResponse> Handle(
        GetScheduleWithGroupQuery query,
        CancellationToken cancellationToken
    )
    {
        var request = query.Request;
        var entity = await _scheduleRepository.GetWithGroupAsync(request.Id, cancellationToken);
        var response = _mapper.Map<GetScheduleWithGroupResponse>(entity);

        return response;
    }
}
