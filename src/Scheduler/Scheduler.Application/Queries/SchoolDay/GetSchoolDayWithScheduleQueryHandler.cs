using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.SchoolDay;

namespace Scheduler.Application.Queries.SchoolDay;

internal sealed class GetSchoolDayWithScheduleQueryHandler
    : IRequestHandler<GetSchoolDayWithScheduleQuery, GetSchoolDayWithScheduleResponse>
{
    private readonly ISchoolDayRepository _schoolDayRepository;
    private readonly IMapper _mapper;

    public GetSchoolDayWithScheduleQueryHandler(
        ISchoolDayRepository schoolDayRepository,
        IMapper mapper
    )
    {
        _schoolDayRepository = schoolDayRepository;
        _mapper = mapper;
    }

    public async Task<GetSchoolDayWithScheduleResponse> Handle(
        GetSchoolDayWithScheduleQuery query,
        CancellationToken cancellationToken
    )
    {
        var id = query.Request.Id;
        var entity = await _schoolDayRepository.GetWithScheduleAsync(id, cancellationToken);
        var response = _mapper.Map<GetSchoolDayWithScheduleResponse>(entity);

        return response;
    }
}
