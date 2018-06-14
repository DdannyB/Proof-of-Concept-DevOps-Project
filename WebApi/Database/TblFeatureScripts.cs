using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblFeatureScripts
    {
        public long PkFeaturescriptid { get; set; }
        public string Scriptname { get; set; }
        public bool Executed { get; set; }
    }
}
