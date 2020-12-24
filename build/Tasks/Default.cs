using Cake.Frosting;

namespace Build.Tasks
{
    [Dependency(typeof(Test))]
    public sealed class Default : FrostingTask<BuildContext>
    {
    }
}