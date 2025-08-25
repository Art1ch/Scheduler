using MediatR;
using Scheduler.Application.Requests.Lesson;
using Scheduler.Application.Responses.Lesson;

namespace Scheduler.Application.Queries.Lesson;

public sealed record GetLessonQuery(
    GetLessonRequest Request  
) : IRequest<GetLessonResponse>;
