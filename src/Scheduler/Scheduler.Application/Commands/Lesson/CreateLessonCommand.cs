using MediatR;
using Scheduler.Application.Requests.Lesson;

namespace Scheduler.Application.Commands.Lesson;

public sealed record CreateLessonCommand(
    CreateLessonRequest Request    
) : IRequest<Unit>;