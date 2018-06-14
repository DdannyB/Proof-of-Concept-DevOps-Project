using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class Probability
    {
        public Probability()
        {
            MatrixProbability = new HashSet<MatrixProbability>();
            MatrixValue = new HashSet<MatrixValue>();
        }

        public long PkProbabilityid { get; set; }
        public string Probabilitydescription { get; set; }

        public ICollection<MatrixProbability> MatrixProbability { get; set; }
        public ICollection<MatrixValue> MatrixValue { get; set; }
    }
}
