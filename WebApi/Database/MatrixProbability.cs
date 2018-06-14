using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class MatrixProbability
    {
        public long PkMatrixprobabilityid { get; set; }
        public long FkMatrixid { get; set; }
        public long FkProbabilityid { get; set; }
        public int Sortorder { get; set; }

        public Matrix FkMatrix { get; set; }
        public Probability FkProbability { get; set; }
    }
}
