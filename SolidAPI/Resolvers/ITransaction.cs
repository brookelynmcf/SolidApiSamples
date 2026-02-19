namespace SolidAPI.Resolvers;

public interface ITransaction
{
    public void ResolveTransaction();
    public void CancelTransaction();
    public void RollbackTransaction();
}