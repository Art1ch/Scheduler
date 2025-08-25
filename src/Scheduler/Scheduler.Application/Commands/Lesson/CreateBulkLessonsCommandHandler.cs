using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.Lesson;

internal sealed class CreateBulkLessonsCommandHandler : IRequestHandler<CreateBulkLessonsCommand, Unit>
{
    private readonly ILessonRepository _lessonRepository;
    private readonly IMapper _mapper;

    public CreateBulkLessonsCommandHandler(
        ILessonRepository lessonRepository,
        IMapper mapper
    )
    {
        _lessonRepository = lessonRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateBulkLessonsCommand command, CancellationToken cancellationToken)
    {
        var lessons = command.Request.Lessons;
        var entities = _mapper.Map<IEnumerable<LessonEntity>>(lessons);
        await _lessonRepository.AddRangeAsync(entities, cancellationToken);

        return Unit.Value;
    }
}
