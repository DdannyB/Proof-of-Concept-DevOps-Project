using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class Matrix
    {
        public Matrix()
        {
            MatrixAssessment = new HashSet<MatrixAssessment>();
            MatrixEffect = new HashSet<MatrixEffect>();
            MatrixProbability = new HashSet<MatrixProbability>();
            MatrixValue = new HashSet<MatrixValue>();
        }

        public long PkMatrixid { get; set; }
        public string Matrixname { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool Isinverted { get; set; }
        public bool Usevalues { get; set; }
        public long? FkMaxriskvalue { get; set; }

        public MatrixValue FkMaxriskvalueNavigation { get; set; }
        public ICollection<MatrixAssessment> MatrixAssessment { get; set; }
        public ICollection<MatrixEffect> MatrixEffect { get; set; }
        public ICollection<MatrixProbability> MatrixProbability { get; set; }
        public ICollection<MatrixValue> MatrixValue { get; set; }
    }
}
