using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class MatrixEffect
    {
        public long PkMatrixeffectid { get; set; }
        public long FkMatrixid { get; set; }
        public long FkEffectid { get; set; }
        public int Sortorder { get; set; }

        public Effect FkEffect { get; set; }
        public Matrix FkMatrix { get; set; }
    }
}
