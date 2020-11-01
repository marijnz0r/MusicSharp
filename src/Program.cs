// <copyright file="Program.cs" company="Mark-James McDougall">
// Licensed under the GNU GPL v3 License. See LICENSE in the project root for license information.
// </copyright>

using System.Runtime.InteropServices;
using MusicSharp;

/// <summary>
/// Entry Point class.
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point.
    /// </summary>
    public static void Main()
    {
        bool isWindows = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        IPlayer player;

        if (isWindows)
        {
            player = new WinPlayer();
        } 
        else
        {
            player = new LinuxPlayer();
        } 

        Gui gui = new Gui(player);
        gui.Start();
    }
}