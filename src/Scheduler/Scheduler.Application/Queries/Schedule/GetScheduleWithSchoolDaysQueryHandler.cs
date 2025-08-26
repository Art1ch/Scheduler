using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Schedule;

namespace Scheduler.Application.Queries.Schedule;

internal sealed class GetScheduleWithSchoolDaysQueryHandler
    : IRequestHandler<GetScheduleWithSchoolDaysQuery, GetScheduleWithSchoolDaysResponse>
{
    private readonly IScheduleRepository _scheduleRepository;
    private readonly IMapper _mapper;

    public GetScheduleWithSchoolDaysQueryHandler(
        IScheduleRepository scheduleRepository,
        IMapper mapper
    )
    {
        _scheduleRepository = scheduleRepository;
        _mapper = mapper;
    }

    public async Task<GetScheduleWithSchoolDaysResponse> Handle(
        GetScheduleWithSchoolDaysQuery query,
        CancellationToken cancellationToken
    )
    {
        var request = query.Request;
        var entity = await _scheduleRepository.GetWithSchoolDaysAsync(request.Id, cancellationToken);
        var response = _mapper.Map<GetScheduleWithSchoolDaysResponse>(entity);

        return response;
    }
}