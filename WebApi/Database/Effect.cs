using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class Effect
    {
        public Effect()
        {
            MatrixEffect = new HashSet<MatrixEffect>();
            MatrixValueEffect = new HashSet<MatrixValueEffect>();
        }

        public long PkEffectid { get; set; }
        public long FkCategoryid { get; set; }
        public string Effectdescription { get; set; }

        public Category FkCategory { get; set; }
        public ICollection<MatrixEffect> MatrixEffect { get; set; }
        public ICollection<MatrixValueEffect> MatrixValueEffect { get; set; }
    }
}
