using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Schedule;

namespace Scheduler.Application.Queries.Schedule;

internal sealed class GetScheduleQueryHandler : IRequestHandler<GetScheduleQuery, GetScheduleResponse>
{
    private readonly IScheduleRepository _scheduleRepository;
    private readonly IMapper _mapper;

    public GetScheduleQueryHandler(
        IScheduleRepository scheduleRepository,
        IMapper mapper
    )
    {
        _scheduleRepository = scheduleRepository;
        _mapper = mapper;
    }

    public async Task<GetScheduleResponse> Handle(GetScheduleQuery query, CancellationToken cancellationToken)
    {
        var request = query.Request;
        var entity = await _scheduleRepository.GetByIdAsync(request.Id, cancellationToken);
        var response = _mapper.Map<GetScheduleResponse>(entity);

        return response;
    }
}
