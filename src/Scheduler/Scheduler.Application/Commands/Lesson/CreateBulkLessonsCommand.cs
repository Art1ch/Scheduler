using MediatR;
using Scheduler.Application.Requests.Lesson;

namespace Scheduler.Application.Commands.Lesson;

public sealed record CreateBulkLessonsCommand(
    CreateBulkLessonsRequest Request
) : IRequest<Unit>;