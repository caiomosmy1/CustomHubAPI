namespace TaskFlow.Domain.Entities;

public enum TaskStatus
{
    Pending,
    Completed
}

public class TaskItem
{
    public Guid Id { get; private set; }
    public Guid OwnerId { get; private set; }
    public string Title { get; private set; }
    public TaskStatus Status { get; private set; }

    private TaskItem() { } // EF Core

    public TaskItem(string title, Guid ownerId)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException(
                "O título é obrigatório.");

        if (ownerId == Guid.Empty)
            throw new ArgumentException(
                "Proprietário inválido.");

        Id = Guid.NewGuid();
        Title = title.Trim();
        OwnerId = ownerId;
        Status = TaskStatus.Pending;
    }

    public void Complete()
    {
        if (Status == TaskStatus.Completed)
            throw new InvalidOperationException(
                "A tarefa já foi concluída.");

        Status = TaskStatus.Completed;
    }
}
