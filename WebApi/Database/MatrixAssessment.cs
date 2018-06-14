using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class MatrixAssessment
    {
        public MatrixAssessment()
        {
            MatrixResult = new HashSet<MatrixResult>();
        }

        public long PkMatrixassessmentid { get; set; }
        public long FkMatrixId { get; set; }
        public string Managementnotes { get; set; }
        public string Remarksrequestor { get; set; }
        public string Username { get; set; }
        public DateTime Usertimestamp { get; set; }
        public string Approveusername { get; set; }
        public DateTime? Approveusertimestamp { get; set; }
        public bool Usemaxriskvalue { get; set; }

        public Matrix FkMatrix { get; set; }
        public ICollection<MatrixResult> MatrixResult { get; set; }
    }
}
