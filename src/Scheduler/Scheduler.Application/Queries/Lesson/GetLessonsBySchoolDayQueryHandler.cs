using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Lesson;

namespace Scheduler.Application.Queries.Lesson;

internal sealed class GetLessonsBySchoolDayQueryHandler 
    : IRequestHandler<GetLessonsBySchoolDayQuery, IEnumerable<GetLessonResponse>>
{
    private readonly ILessonRepository _lessonRepository;
    private readonly IMapper _mapper;

    public GetLessonsBySchoolDayQueryHandler(
        ILessonRepository lessonRepository,
        IMapper mapper
    )
    {
        _lessonRepository = lessonRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetLessonResponse>> Handle(
        GetLessonsBySchoolDayQuery query,
        CancellationToken cancellationToken
    )
    {
        var schoolDayId = query.Request.SchoolDayId;
        var entities = await _lessonRepository.GetBySchoolDayIdAsync(schoolDayId, cancellationToken);
        var response = _mapper.Map<IEnumerable<GetLessonResponse>>(entities);

        return response;
    }
}
