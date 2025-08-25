using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.Lesson;

internal sealed class CreateLessonCommandHandler : IRequestHandler<CreateLessonCommand, Unit>
{
    private readonly ILessonRepository _lessonRepository;
    private readonly IMapper _mapper;

    public CreateLessonCommandHandler(
        ILessonRepository lessonRepository,
        IMapper mapper
    )
    {
        _lessonRepository = lessonRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateLessonCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<LessonEntity>(request);
        await _lessonRepository.AddAsync(entity, cancellationToken);

        return Unit.Value;
    }
}
