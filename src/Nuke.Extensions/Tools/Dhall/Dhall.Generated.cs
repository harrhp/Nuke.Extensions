// Generated from https://raw.githubusercontent.com/harrhp/Nuke.Extensions/main/src/Nuke.Extensions/Tools/Dhall/Dhall.json

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

namespace Harrhp.Nuke.Extensions.Tools.Dhall
{
    /// <summary>
    ///   <p>Dhall is a programmable configuration language that you can think of as: JSON + functions + types + imports</p>
    ///   <p>For more details, visit the <a href="https://dhall-lang.org/">official website</a>.</p>
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class DhallTasks
    {
        /// <summary>
        ///   Path to the Dhall executable.
        /// </summary>
        public static string DhallPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("DHALL_EXE") ??
            ToolPathResolver.GetPathExecutable("dhall");
        public static Action<OutputType, string> DhallLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   <p>Dhall is a programmable configuration language that you can think of as: JSON + functions + types + imports</p>
        ///   <p>For more details, visit the <a href="https://dhall-lang.org/">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> Dhall(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            using var process = ProcessTasks.StartProcess(DhallPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, DhallLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Render a Dhall expression that evaluates to a Text literal</p>
        ///   <p>For more details, visit the <a href="https://dhall-lang.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--file</c> via <see cref="DhallTextSettings.File"/></li>
        ///     <li><c>--output</c> via <see cref="DhallTextSettings.Output"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> DhallText(DhallTextSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new DhallTextSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Render a Dhall expression that evaluates to a Text literal</p>
        ///   <p>For more details, visit the <a href="https://dhall-lang.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--file</c> via <see cref="DhallTextSettings.File"/></li>
        ///     <li><c>--output</c> via <see cref="DhallTextSettings.Output"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> DhallText(Configure<DhallTextSettings> configurator)
        {
            return DhallText(configurator(new DhallTextSettings()));
        }
        /// <summary>
        ///   <p>Render a Dhall expression that evaluates to a Text literal</p>
        ///   <p>For more details, visit the <a href="https://dhall-lang.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--file</c> via <see cref="DhallTextSettings.File"/></li>
        ///     <li><c>--output</c> via <see cref="DhallTextSettings.Output"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(DhallTextSettings Settings, IReadOnlyCollection<Output> Output)> DhallText(CombinatorialConfigure<DhallTextSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(DhallText, DhallLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Display version</p>
        ///   <p>For more details, visit the <a href="https://dhall-lang.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        /// </remarks>
        public static IReadOnlyCollection<Output> DhallVersion(DhallVersionSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new DhallVersionSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Display version</p>
        ///   <p>For more details, visit the <a href="https://dhall-lang.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        /// </remarks>
        public static IReadOnlyCollection<Output> DhallVersion(Configure<DhallVersionSettings> configurator)
        {
            return DhallVersion(configurator(new DhallVersionSettings()));
        }
        /// <summary>
        ///   <p>Display version</p>
        ///   <p>For more details, visit the <a href="https://dhall-lang.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        /// </remarks>
        public static IEnumerable<(DhallVersionSettings Settings, IReadOnlyCollection<Output> Output)> DhallVersion(CombinatorialConfigure<DhallVersionSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(DhallVersion, DhallLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region DhallTextSettings
    /// <summary>
    ///   Used within <see cref="DhallTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class DhallTextSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Dhall executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? DhallTasks.DhallPath;
        public override Action<OutputType, string> ProcessCustomLogger => DhallTasks.DhallLogger;
        /// <summary>
        ///   Read expression from a file instead of standard input
        /// </summary>
        public virtual string File { get; internal set; }
        /// <summary>
        ///   Write result to a file instead of standard output
        /// </summary>
        public virtual string Output { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("text")
              .Add("--file {value}", File)
              .Add("--output {value}", Output);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region DhallVersionSettings
    /// <summary>
    ///   Used within <see cref="DhallTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class DhallVersionSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Dhall executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? DhallTasks.DhallPath;
        public override Action<OutputType, string> ProcessCustomLogger => DhallTasks.DhallLogger;
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("version");
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region DhallTextSettingsExtensions
    /// <summary>
    ///   Used within <see cref="DhallTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class DhallTextSettingsExtensions
    {
        #region File
        /// <summary>
        ///   <p><em>Sets <see cref="DhallTextSettings.File"/></em></p>
        ///   <p>Read expression from a file instead of standard input</p>
        /// </summary>
        [Pure]
        public static T SetFile<T>(this T toolSettings, string file) where T : DhallTextSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="DhallTextSettings.File"/></em></p>
        ///   <p>Read expression from a file instead of standard input</p>
        /// </summary>
        [Pure]
        public static T ResetFile<T>(this T toolSettings) where T : DhallTextSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="DhallTextSettings.Output"/></em></p>
        ///   <p>Write result to a file instead of standard output</p>
        /// </summary>
        [Pure]
        public static T SetOutput<T>(this T toolSettings, string output) where T : DhallTextSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="DhallTextSettings.Output"/></em></p>
        ///   <p>Write result to a file instead of standard output</p>
        /// </summary>
        [Pure]
        public static T ResetOutput<T>(this T toolSettings) where T : DhallTextSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region DhallVersionSettingsExtensions
    /// <summary>
    ///   Used within <see cref="DhallTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class DhallVersionSettingsExtensions
    {
    }
    #endregion
}
