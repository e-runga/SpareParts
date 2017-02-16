namespace SpareParts.Dto
{
    public class CustomerDto : BaseDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Phone { get; set; }

        public CustomerTypeDto CustomerType { get; set; }

        public string DisplayName
        {
            get { return string.Format("{0} {1}", this.LastName, this.FirstName); }
        }
    }
}