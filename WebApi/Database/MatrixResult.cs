using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class MatrixResult
    {
        public long PkMatrixresultid { get; set; }
        public long FkMatrixvalueid { get; set; }
        public long? FkCategoryid { get; set; }
        public int Matrixresulttype { get; set; }
        public long FkMatrixassessmentid { get; set; }

        public Category FkCategory { get; set; }
        public MatrixAssessment FkMatrixassessment { get; set; }
        public MatrixValue FkMatrixvalue { get; set; }
    }
}
