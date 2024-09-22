using System;

namespace LSL.AppVeyor.Helpers;

/// <summary>
/// AppVeyorFixingStringExtensions
/// </summary>
public static class AppVeyorFixingStringExtensions
{
    /// <summary>
    /// Replace line ends of type <c>\n</c> to <c>\r\n</c>
    /// </summary>
    /// <remarks>
    /// Appveyor builds with multi-line strings create them with <c>\n</c> rather than using Environment.NewLine. This fixes those constants.
    /// </remarks>
    /// <param name="source"></param>
    /// <returns></returns>
    public static string FixStringConstantNewLines(this string source) => 
        source.IndexOf("\r\n") > -1 ? source : source.Replace("\n", "\r\n");
}