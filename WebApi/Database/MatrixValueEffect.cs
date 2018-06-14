using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class MatrixValueEffect
    {
        public long PkMatrixvalueeffectid { get; set; }
        public long FkMatrixvalueid { get; set; }
        public long FkEffectid { get; set; }

        public Effect FkEffect { get; set; }
        public MatrixValue FkMatrixvalue { get; set; }
    }
}
