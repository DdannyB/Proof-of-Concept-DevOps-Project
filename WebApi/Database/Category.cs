using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class Category
    {
        public Category()
        {
            Effect = new HashSet<Effect>();
            MatrixResult = new HashSet<MatrixResult>();
        }

        public long PkCategoryid { get; set; }
        public string Categoryname { get; set; }

        public ICollection<Effect> Effect { get; set; }
        public ICollection<MatrixResult> MatrixResult { get; set; }
    }
}
