using SpareParts.Dto;

namespace SpareParts.Explorer.Helper
{
    public static class Extensions
    {
        public static OperatorDto ToOperator(this UserDto user)
        {
            OperatorDto dto = null;

            if (user != null)
            {
                dto = new OperatorDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Mobile = user.Mobile,
                    Phone = user.Mobile
                };
            }

            return dto;
        }

    }
}