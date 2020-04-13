namespace ZooProjF.Models
{
    public class ExhibitModel
    {
        public int Exhibit_ID { get; set; }
        public int Department_ID { get; set; }
        public int Animal_ID { get; set; }
        public string Name { get; set; }
        public string Exhibit_Habitat { get; set; }
        public string Description { get; set; }
        public string Image_URL { get; set; }
    }
}