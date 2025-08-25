using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;

namespace Scheduler.Application.Commands.Lesson;

internal sealed class DeleteLessonCommandHandler : IRequestHandler<DeleteLessonCommand, Unit>
{
    private readonly ILessonRepository _lessonRepository;
    private readonly IMapper _mapper;

    public DeleteLessonCommandHandler(
        ILessonRepository lessonRepository,
        IMapper mapper
    )
    {
        _lessonRepository = lessonRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteLessonCommand command, CancellationToken cancellationToken)
    {
        var id = command.Request.Id;
        await _lessonRepository.DeleteAsync(id, cancellationToken);

        return Unit.Value;
    }
}