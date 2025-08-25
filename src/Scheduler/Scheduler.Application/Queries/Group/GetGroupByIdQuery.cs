using MediatR;

namespace Scheduler.Application.Queries.Group;

public record GetGroupByIdQuery(int Id) : IRequest<GroupResponse>;
public record GetGroupWithFacultyQuery(int Id) : IRequest<GroupWithFacultyResponse>;
public record GetGroupWithScheduleQuery(int Id) : IRequest<GroupWithScheduleResponse>;
public record GetGroupFullQuery(int Id) : IRequest<GroupFullResponse>;
public record GetGroupsByFacultyQuery(int FacultyId) : IRequest<List<GroupResponse>>;