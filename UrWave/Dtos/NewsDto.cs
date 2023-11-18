namespace UrWave.Dtos
{
    public class NewsDto
    {
        public int Id { set; get; }
        public string News_Name { get; set; } = string.Empty;
        public string News_NameAr { get; set; } = string.Empty;

        public string News_Description { get; set; } = string.Empty;
        public string News_DescriptionAr { get; set; } = string.Empty;
    }
}
