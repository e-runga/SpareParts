using System.Text;

namespace SpareParts.Dto
{
    public class CategoryViewDto
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public int? ParentId { get; set; }

        public string SubCategory1 { get; set; }

        public string SubCategory2 { get; set; }

        public int SubCategory1Id { get; set; }

        public int SubCategory2Id { get; set; }

        public int SubCategory1ParentId { get; set; }

        public int SubCategory2ParentId { get; set; }

        public string DisplayName
        {
            get
            {
                var retVal = new StringBuilder();
                retVal.Append(this.Category);

                if (!string.IsNullOrEmpty(this.SubCategory1))
                {
                    retVal.AppendFormat(" / {0}", this.SubCategory1);
                }

                if (!string.IsNullOrEmpty(this.SubCategory2))
                {
                    retVal.AppendFormat(" / {0}", this.SubCategory2);
                }

                return retVal.ToString();
            }
        }
    }
}