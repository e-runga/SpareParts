namespace SpareParts.Dto
{
    public class CustomerUIDto : BaseDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName
        {
            get
            {
                return string.Format("{0} {1}", this.LastName, this.FirstName);
            }
        }
    }
}