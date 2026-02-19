namespace SolidAPI.Resolvers;

public class OnlineTransaction: ITransaction, INotification
{
    public void ResolveTransaction()
    {
        throw new NotImplementedException();
    }

    public void CancelTransaction()
    {
        throw new NotImplementedException();
    }

    public void RollbackTransaction()
    {
        throw new NotImplementedException();
    }

    public void Notify()
    {
        throw new NotImplementedException();
    }
}