using Nuke.Common.Tooling;

namespace Harrhp.Nuke.Extensions.Tools.Liquibase;

public partial class LiquibaseGlobalSettings
{
    public Arguments CreateArguments() => ConfigureProcessArguments(new Arguments());

    public override Action<OutputType, string> ProcessCustomLogger => throw new NotSupportedException();
}
