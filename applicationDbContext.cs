using WebApplication6.Data;

internal class applicationDbContext
{
    public object Categories { get; internal set; }

    public static implicit operator applicationDbContext(ApplicationDbContext v)
    {
        throw new NotImplementedException();
    }
}