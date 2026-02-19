namespace SolidAPI.Resolvers;

public class ResolveJoke: ITellJoke
{
    public string TellJoke()
    {
        return "knock knock...";
    }
    public void NextJoke()
    {
        //logic to retrieve next joke
    }

    public void PreviousJoke()
    {
        //logic to retrieve previous joke
    }
}