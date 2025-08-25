using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Lesson;

namespace Scheduler.Application.Queries.Lesson;

internal sealed class GetLessonWithSchoolDayQueryHandler
    : IRequestHandler<GetLessonWithSchoolDayQuery, GetLessonWithSchoolDayResponse>
{
    private readonly ILessonRepository _lessonRepository;
    private readonly IMapper _mapper;

    public GetLessonWithSchoolDayQueryHandler(
        ILessonRepository lessonRepository,
        IMapper mapper
    )
    {
        _lessonRepository = lessonRepository;
        _mapper = mapper;
    }

    public async Task<GetLessonWithSchoolDayResponse> Handle(
        GetLessonWithSchoolDayQuery query,
        CancellationToken cancellationToken
    )
    {
        var id = query.Request.Id;
        var entity = await _lessonRepository.GetWithSchoolDayAsync(id, cancellationToken);
        var response = _mapper.Map<GetLessonWithSchoolDayResponse>(entity);

        return response;
    }
}
