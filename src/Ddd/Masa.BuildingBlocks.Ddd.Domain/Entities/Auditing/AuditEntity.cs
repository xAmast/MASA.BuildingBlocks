namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;
public abstract class AuditEntity<TUserId> : Entity, IAuditEntity<TUserId>
{
    public TUserId Creator { get; protected set; } = default!;

    public DateTime CreationTime { get; protected set; }

    public TUserId Modifier { get; protected set; } = default!;

    public DateTime ModificationTime { get; set; }

    public AuditEntity() => Initialize();

    public void Initialize()
    {
        this.CreationTime = this.GetCurrentTime();
        this.ModificationTime = this.GetCurrentTime();
    }

    public virtual DateTime GetCurrentTime() => DateTime.UtcNow;
}

public class AuditEntity<TKey, TUserId> : Entity<TKey>, IAuditEntity<TUserId>
{
    public TUserId Creator { get; protected set; } = default!;

    public DateTime CreationTime { get; protected set; }

    public TUserId Modifier { get; protected set; } = default!;

    public DateTime ModificationTime { get; protected set; }

    public AuditEntity() => Initialize();

    public void Initialize()
    {
        this.CreationTime = this.GetCurrentTime();
        this.ModificationTime = this.GetCurrentTime();
    }

    public virtual DateTime GetCurrentTime() => DateTime.UtcNow;
}
