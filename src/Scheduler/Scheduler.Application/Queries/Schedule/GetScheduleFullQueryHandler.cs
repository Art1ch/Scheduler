using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Schedule;

namespace Scheduler.Application.Queries.Schedule;

internal sealed class GetScheduleFullQueryHandler : IRequestHandler<GetScheduleFullQuery, GetScheduleFullResponse>
{
    private readonly IScheduleRepository _scheduleRepository;
    private readonly IMapper _mapper;

    public GetScheduleFullQueryHandler(
        IScheduleRepository scheduleRepository,
        IMapper mapper
    )
    {
        _scheduleRepository = scheduleRepository;
        _mapper = mapper;
    }

    public async Task<GetScheduleFullResponse> Handle(GetScheduleFullQuery query, CancellationToken cancellationToken)
    {
        var request = query.Request;
        var entity = await _scheduleRepository.GetFullAsync(request.Id, cancellationToken);
        var response = _mapper.Map<GetScheduleFullResponse>(entity);

        return response;
    }
}
