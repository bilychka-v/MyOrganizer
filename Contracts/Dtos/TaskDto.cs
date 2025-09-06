namespace Contracts;

public record TaskDto(
    Guid Id,
    string Title,
    string Description,
    DateTime Deadline,
    string Status,
    Guid UserId,
    string Priority,
    DateTime CreatedAt,
    DateTime CompletedAt
    );