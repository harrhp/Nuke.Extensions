using Nuke.Common.Tooling;

namespace Harrhp.Nuke.Extensions.Tools.Liquibase;

[Serializable]
public abstract class LiquibaseSettingsBase : ToolSettings
{
    public LiquibaseGlobalSettings? GlobalSettings { get; internal set; }

    protected string GetLiquibaseGlobalSettings() => string.Empty;

    protected override Arguments ConfigureProcessArguments(Arguments arguments) =>
        base.ConfigureProcessArguments(GlobalSettings != null
            ? GlobalSettings.CreateArguments().Concatenate(arguments)
            : arguments);
}
