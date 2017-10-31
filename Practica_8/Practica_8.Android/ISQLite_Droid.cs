﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Practica_8.Droid;
using Xamarin.Forms;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Dependency(typeof(ISQLite_Droid))]
namespace Practica_8.Droid
{
    public class ISQLite_Droid : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            string Path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(Path, filename);
        }
    }
}