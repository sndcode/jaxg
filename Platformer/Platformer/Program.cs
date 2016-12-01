#region File Description
//-----------------------------------------------------------------------------
// Program.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

using System;

namespace Platformer
{
    static class Program
    {
        public static bool debugmode;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {

            if (System.Diagnostics.Debugger.IsAttached)
            {
                debugmode = true;
            }
            else if (!System.Diagnostics.Debugger.IsAttached)
            {
                debugmode = false;
            }

            using (PlatformerGame game = new PlatformerGame())
            {
                game.Run();
            }
        }
    }
}

