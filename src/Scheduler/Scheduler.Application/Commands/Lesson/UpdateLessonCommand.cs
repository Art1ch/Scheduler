using MediatR;
using Scheduler.Application.Requests.Lesson;

namespace Scheduler.Application.Commands.Lesson;

public sealed record UpdateLessonCommand(
    UpdateLessonRequest Request
) : IRequest<Unit>;
