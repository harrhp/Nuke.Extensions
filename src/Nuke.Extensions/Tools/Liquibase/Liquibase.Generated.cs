// Generated from https://raw.githubusercontent.com/harrhp/Nuke.Extensions/main/src/Nuke.Extensions/Tools/Liquibase/Liquibase.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Harrhp.Nuke.Extensions.Tools.Liquibase
{
    /// <summary>
    ///   <p>Liquibase is an open-source database-independent library for tracking, managing and applying database schema changes</p>
    ///   <p>For more details, visit the <a href="https://www.liquibase.org/">official website</a>.</p>
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class LiquibaseTasks
    {
        /// <summary>
        ///   Path to the Liquibase executable.
        /// </summary>
        public static string LiquibasePath =>
            ToolPathResolver.TryGetEnvironmentExecutable("LIQUIBASE_EXE") ??
            ToolPathResolver.GetPathExecutable("liquibase");
        public static Action<OutputType, string> LiquibaseLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   <p>Liquibase is an open-source database-independent library for tracking, managing and applying database schema changes</p>
        ///   <p>For more details, visit the <a href="https://www.liquibase.org/">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> Liquibase(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            using var process = ProcessTasks.StartProcess(LiquibasePath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, LiquibaseLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Liquibase is an open-source database-independent library for tracking, managing and applying database schema changes</p>
        ///   <p>For more details, visit the <a href="https://www.liquibase.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;liquibaseGlobalSettings&gt;</c> via <see cref="LiquibaseSettings.LiquibaseGlobalSettings"/></li>
        ///     <li><c>--version</c> via <see cref="LiquibaseSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> Liquibase(LiquibaseSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new LiquibaseSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Liquibase is an open-source database-independent library for tracking, managing and applying database schema changes</p>
        ///   <p>For more details, visit the <a href="https://www.liquibase.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;liquibaseGlobalSettings&gt;</c> via <see cref="LiquibaseSettings.LiquibaseGlobalSettings"/></li>
        ///     <li><c>--version</c> via <see cref="LiquibaseSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> Liquibase(Configure<LiquibaseSettings> configurator)
        {
            return Liquibase(configurator(new LiquibaseSettings()));
        }
        /// <summary>
        ///   <p>Liquibase is an open-source database-independent library for tracking, managing and applying database schema changes</p>
        ///   <p>For more details, visit the <a href="https://www.liquibase.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;liquibaseGlobalSettings&gt;</c> via <see cref="LiquibaseSettings.LiquibaseGlobalSettings"/></li>
        ///     <li><c>--version</c> via <see cref="LiquibaseSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(LiquibaseSettings Settings, IReadOnlyCollection<Output> Output)> Liquibase(CombinatorialConfigure<LiquibaseSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(Liquibase, LiquibaseLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Deploy any changes in the changelog file that have not been deployed</p>
        ///   <p>For more details, visit the <a href="https://www.liquibase.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;liquibaseGlobalSettings&gt;</c> via <see cref="LiquibaseUpdateSettings.LiquibaseGlobalSettings"/></li>
        ///     <li><c>--password</c> via <see cref="LiquibaseUpdateSettings.Password"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> LiquibaseUpdate(LiquibaseUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new LiquibaseUpdateSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Deploy any changes in the changelog file that have not been deployed</p>
        ///   <p>For more details, visit the <a href="https://www.liquibase.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;liquibaseGlobalSettings&gt;</c> via <see cref="LiquibaseUpdateSettings.LiquibaseGlobalSettings"/></li>
        ///     <li><c>--password</c> via <see cref="LiquibaseUpdateSettings.Password"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> LiquibaseUpdate(Configure<LiquibaseUpdateSettings> configurator)
        {
            return LiquibaseUpdate(configurator(new LiquibaseUpdateSettings()));
        }
        /// <summary>
        ///   <p>Deploy any changes in the changelog file that have not been deployed</p>
        ///   <p>For more details, visit the <a href="https://www.liquibase.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;liquibaseGlobalSettings&gt;</c> via <see cref="LiquibaseUpdateSettings.LiquibaseGlobalSettings"/></li>
        ///     <li><c>--password</c> via <see cref="LiquibaseUpdateSettings.Password"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(LiquibaseUpdateSettings Settings, IReadOnlyCollection<Output> Output)> LiquibaseUpdate(CombinatorialConfigure<LiquibaseUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(LiquibaseUpdate, LiquibaseLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region LiquibaseSettings
    /// <summary>
    ///   Used within <see cref="LiquibaseTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class LiquibaseSettings : LiquibaseSettingsBase
    {
        /// <summary>
        ///   Path to the Liquibase executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? LiquibaseTasks.LiquibasePath;
        public override Action<OutputType, string> ProcessCustomLogger => LiquibaseTasks.LiquibaseLogger;
        /// <summary>
        ///   Print version information and exit
        /// </summary>
        public virtual bool? Version { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("--version", Version)
              .Add("{value}", GetLiquibaseGlobalSettings(), customValue: true);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region LiquibaseUpdateSettings
    /// <summary>
    ///   Used within <see cref="LiquibaseTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class LiquibaseUpdateSettings : LiquibaseSettingsBase
    {
        /// <summary>
        ///   Path to the Liquibase executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? LiquibaseTasks.LiquibasePath;
        public override Action<OutputType, string> ProcessCustomLogger => LiquibaseTasks.LiquibaseLogger;
        /// <summary>
        ///   Password to use to connect to the database
        /// </summary>
        public virtual string Password { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("update")
              .Add("--password={value}", Password, secret: true)
              .Add("{value}", GetLiquibaseGlobalSettings(), customValue: true);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region LiquibaseGlobalSettings
    /// <summary>
    ///   Used within <see cref="LiquibaseTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class LiquibaseGlobalSettings : ToolSettings
    {
        /// <summary>
        ///   File with default Liquibase properties
        /// </summary>
        public virtual string DefaultsFile { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("--defaults-file={value}", DefaultsFile);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region LiquibaseSettingsExtensions
    /// <summary>
    ///   Used within <see cref="LiquibaseTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class LiquibaseSettingsExtensions
    {
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="LiquibaseSettings.Version"/></em></p>
        ///   <p>Print version information and exit</p>
        /// </summary>
        [Pure]
        public static T SetVersion<T>(this T toolSettings, bool? version) where T : LiquibaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="LiquibaseSettings.Version"/></em></p>
        ///   <p>Print version information and exit</p>
        /// </summary>
        [Pure]
        public static T ResetVersion<T>(this T toolSettings) where T : LiquibaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="LiquibaseSettings.Version"/></em></p>
        ///   <p>Print version information and exit</p>
        /// </summary>
        [Pure]
        public static T EnableVersion<T>(this T toolSettings) where T : LiquibaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="LiquibaseSettings.Version"/></em></p>
        ///   <p>Print version information and exit</p>
        /// </summary>
        [Pure]
        public static T DisableVersion<T>(this T toolSettings) where T : LiquibaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="LiquibaseSettings.Version"/></em></p>
        ///   <p>Print version information and exit</p>
        /// </summary>
        [Pure]
        public static T ToggleVersion<T>(this T toolSettings) where T : LiquibaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = !toolSettings.Version;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region LiquibaseUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="LiquibaseTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class LiquibaseUpdateSettingsExtensions
    {
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="LiquibaseUpdateSettings.Password"/></em></p>
        ///   <p>Password to use to connect to the database</p>
        /// </summary>
        [Pure]
        public static T SetPassword<T>(this T toolSettings, [Secret] string password) where T : LiquibaseUpdateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="LiquibaseUpdateSettings.Password"/></em></p>
        ///   <p>Password to use to connect to the database</p>
        /// </summary>
        [Pure]
        public static T ResetPassword<T>(this T toolSettings) where T : LiquibaseUpdateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region LiquibaseGlobalSettingsExtensions
    /// <summary>
    ///   Used within <see cref="LiquibaseTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class LiquibaseGlobalSettingsExtensions
    {
        #region DefaultsFile
        /// <summary>
        ///   <p><em>Sets <see cref="LiquibaseGlobalSettings.DefaultsFile"/></em></p>
        ///   <p>File with default Liquibase properties</p>
        /// </summary>
        [Pure]
        public static T SetDefaultsFile<T>(this T toolSettings, string defaultsFile) where T : LiquibaseGlobalSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultsFile = defaultsFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="LiquibaseGlobalSettings.DefaultsFile"/></em></p>
        ///   <p>File with default Liquibase properties</p>
        /// </summary>
        [Pure]
        public static T ResetDefaultsFile<T>(this T toolSettings) where T : LiquibaseGlobalSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultsFile = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
