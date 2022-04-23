using Nuke.Common.Tooling;

namespace Harrhp.Nuke.Extensions.Tools.Liquibase;

public static class LiquibaseSettingsBaseExtensions
{
    public static T SetGlobalSettings<T>(this T settings, Configure<LiquibaseGlobalSettings> configure)
        where T : LiquibaseSettingsBase
    {
        var liquibaseSettingsBase = settings.NewInstance();
        liquibaseSettingsBase.GlobalSettings =
            settings.GlobalSettings = configure.InvokeSafe(new LiquibaseGlobalSettings());
        return liquibaseSettingsBase;
    }

    public static T ResetCliSettings<T>(this T settings)
        where T : LiquibaseSettingsBase
    {
        var liquibaseSettingsBase = settings.NewInstance();
        liquibaseSettingsBase.GlobalSettings = new LiquibaseGlobalSettings();
        return liquibaseSettingsBase;
    }
}
