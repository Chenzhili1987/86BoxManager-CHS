﻿/*
MIT License

Copyright (c) 2018-2022 David Simunič

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Reflection;
using System.Windows.Forms;

namespace _86boxManager
{
    /// <summary>
    /// Present the Windows Vista-style open file dialog to select a folder. Fall back for older Windows Versions
    /// </summary>
    public class FolderSelectDialog
    {
        private string _initialDirectory;
        private string _title;
        private string _fileName = "";

        public string InitialDirectory
        {
            get { return string.IsNullOrEmpty(_initialDirectory) ? Environment.CurrentDirectory : _initialDirectory; }
            set { _initialDirectory = value; }
        }
        public string Title
        {
            get { return _title ?? "选择一个文件夹"; }
            set { _title = value; }
        }
        public string FileName { get { return _fileName; } }

        public bool Show() { return Show(IntPtr.Zero); }

        /// <param name="hWndOwner">Handle of the control or window to be the parent of the file dialog</param>
        /// <returns>true if the user clicks OK</returns>
        public bool Show(IntPtr hWndOwner)
        {
            var result = VistaDialog.Show(hWndOwner, InitialDirectory, Title);
            _fileName = result.FileName;
            return result.Result;
        }

        private struct ShowDialogResult
        {
            public bool Result { get; set; }
            public string FileName { get; set; }
        }

        private static class VistaDialog
        {
            private const string c_foldersFilter = "文件夹 |\n";

            private const BindingFlags c_flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            private readonly static Assembly s_windowsFormsAssembly = typeof(FileDialog).Assembly;
            private readonly static Type s_iFileDialogType = s_windowsFormsAssembly.GetType("System.Windows.Forms.FileDialogNative+IFileDialog");
            private readonly static MethodInfo s_createVistaDialogMethodInfo = typeof(OpenFileDialog).GetMethod("CreateVistaDialog", c_flags);
            private readonly static MethodInfo s_onBeforeVistaDialogMethodInfo = typeof(FileDialog).GetMethod("OnBeforeVistaDialog", c_flags);
            private readonly static MethodInfo s_getOptionsMethodInfo = typeof(FileDialog).GetMethod("GetOptions", c_flags);
            private readonly static MethodInfo s_setOptionsMethodInfo = s_iFileDialogType.GetMethod("SetOptions", c_flags);
            private readonly static uint s_fosPickFoldersBitFlag = (uint)s_windowsFormsAssembly
                .GetType("System.Windows.Forms.FileDialogNative+FOS")
                .GetField("FOS_PICKFOLDERS")
                .GetValue(null);
            private readonly static ConstructorInfo s_vistaDialogEventsConstructorInfo = s_windowsFormsAssembly
                .GetType("System.Windows.Forms.FileDialog+VistaDialogEvents")
                .GetConstructor(c_flags, null, new[] { typeof(FileDialog) }, null);
            private readonly static MethodInfo s_adviseMethodInfo = s_iFileDialogType.GetMethod("Advise");
            private readonly static MethodInfo s_unAdviseMethodInfo = s_iFileDialogType.GetMethod("Unadvise");
            private readonly static MethodInfo s_showMethodInfo = s_iFileDialogType.GetMethod("Show");

            public static ShowDialogResult Show(IntPtr ownerHandle, string initialDirectory, string title)
            {
                var openFileDialog = new OpenFileDialog
                {
                    AddExtension = false,
                    CheckFileExists = false,
                    DereferenceLinks = true,
                    Filter = c_foldersFilter,
                    InitialDirectory = initialDirectory,
                    Multiselect = false,
                    Title = title
                };

                var iFileDialog = s_createVistaDialogMethodInfo.Invoke(openFileDialog, new object[] { });
                s_onBeforeVistaDialogMethodInfo.Invoke(openFileDialog, new[] { iFileDialog });
                s_setOptionsMethodInfo.Invoke(iFileDialog, new object[] { (uint)s_getOptionsMethodInfo.Invoke(openFileDialog, new object[] { }) | s_fosPickFoldersBitFlag });
                var adviseParametersWithOutputConnectionToken = new[] { s_vistaDialogEventsConstructorInfo.Invoke(new object[] { openFileDialog }), 0U };
                s_adviseMethodInfo.Invoke(iFileDialog, adviseParametersWithOutputConnectionToken);

                try
                {
                    int retVal = (int)s_showMethodInfo.Invoke(iFileDialog, new object[] { ownerHandle });
                    return new ShowDialogResult
                    {
                        Result = retVal == 0,
                        FileName = openFileDialog.FileName
                    };
                }
                finally
                {
                    s_unAdviseMethodInfo.Invoke(iFileDialog, new[] { adviseParametersWithOutputConnectionToken[1] });
                }
            }
        }

        // Wrap an IWin32Window around an IntPtr
        private class WindowWrapper : IWin32Window
        {
            private readonly IntPtr _handle;
            public WindowWrapper(IntPtr handle) { _handle = handle; }
            public IntPtr Handle { get { return _handle; } }
        }
    }
}