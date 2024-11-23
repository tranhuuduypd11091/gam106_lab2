namespace lab2.DTO
{
    public class UpdateUserInformationDTO
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public IFormFile Avatar { get; set; }   
    }
}
