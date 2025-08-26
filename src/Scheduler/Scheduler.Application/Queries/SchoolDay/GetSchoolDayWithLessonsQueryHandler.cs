using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.SchoolDay;

namespace Scheduler.Application.Queries.SchoolDay;

internal sealed class GetSchoolDayWithLessonsQueryHandler 
    : IRequestHandler<GetSchoolDayWithLessonsQuery, GetSchoolDayWithLessonsResponse>
{
    private readonly ISchoolDayRepository _schoolDayRepository;
    private readonly IMapper _mapper;

    public GetSchoolDayWithLessonsQueryHandler(
        ISchoolDayRepository schoolDayRepository,
        IMapper mapper
    )
    {
        _schoolDayRepository = schoolDayRepository;
        _mapper = mapper;
    }

    public async Task<GetSchoolDayWithLessonsResponse> Handle(
        GetSchoolDayWithLessonsQuery query,
        CancellationToken cancellationToken
    )
    {
        var id = query.Request.Id;
        var entity = await _schoolDayRepository.GetWithLessonsAsync(id, cancellationToken);
        var response = _mapper.Map<GetSchoolDayWithLessonsResponse>(entity);

        return response;
    }
}
