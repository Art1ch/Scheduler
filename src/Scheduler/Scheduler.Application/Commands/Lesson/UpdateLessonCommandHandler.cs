using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.Lesson;

internal sealed class UpdateLessonCommandHandler : IRequestHandler<UpdateLessonCommand, Unit>
{
    private readonly ILessonRepository _lessonRepository;
    private readonly IMapper _mapper;

    public UpdateLessonCommandHandler(
        ILessonRepository lessonRepository,
        IMapper mapper
    )
    {
        _lessonRepository = lessonRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateLessonCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<LessonEntity>(request);
        await _lessonRepository.UpdateAsync(entity, cancellationToken);

        return Unit.Value;
    }
}
