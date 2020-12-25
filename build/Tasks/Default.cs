using Cake.Frosting;

namespace Build.Tasks
{
    [Dependency(typeof(Publish))]
    public sealed class Default : FrostingTask<BuildContext>
    {
    }
}