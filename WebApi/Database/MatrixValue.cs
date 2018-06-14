using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class MatrixValue
    {
        public MatrixValue()
        {
            Matrix = new HashSet<Matrix>();
            MatrixResult = new HashSet<MatrixResult>();
            MatrixValueEffect = new HashSet<MatrixValueEffect>();
        }

        public long PkMatrixvalueid { get; set; }
        public long FkMatrixid { get; set; }
        public long FkProbabilityid { get; set; }
        public int Backcolor { get; set; }
        public string Resultvalue { get; set; }
        public int Sortorder { get; set; }

        public Matrix FkMatrix { get; set; }
        public Probability FkProbability { get; set; }
        public ICollection<Matrix> Matrix { get; set; }
        public ICollection<MatrixResult> MatrixResult { get; set; }
        public ICollection<MatrixValueEffect> MatrixValueEffect { get; set; }
    }
}
