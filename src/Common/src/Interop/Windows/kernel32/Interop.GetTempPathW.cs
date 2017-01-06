// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.IO;
using System.Text;
using System.Runtime.InteropServices;

partial class Interop
{
    partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, BestFitMapping = false)]
        internal static extern uint GetTempPathW(int bufferLen, [Out]StringBuilder buffer);
    }
}