using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.Lesson;

namespace Scheduler.Application.Queries.Lesson;

internal sealed class GetLessonQueryHandler : IRequestHandler<GetLessonQuery, GetLessonResponse>
{
    private readonly ILessonRepository _lessonRepository;
    private readonly IMapper _mapper;

    public GetLessonQueryHandler(
        ILessonRepository lessonRepository,
        IMapper mapper
    )
    {
        _lessonRepository = lessonRepository;
        _mapper = mapper;
    }

    public async Task<GetLessonResponse> Handle(GetLessonQuery query, CancellationToken cancellationToken)
    {
        var id = query.Request.Id;
        var entity = await _lessonRepository.GetByIdAsync(id, cancellationToken);
        var response = _mapper.Map<GetLessonResponse>(entity);

        return response;
    }
}
