using System.ComponentModel.DataAnnotations;


namespace input_database.СonnectionFolder
{
    class Connection
    {
        [Key]
        public int id { get; set; }
        public string id_stage { get; set; }
        public string id_insecticides { get; set; }
        public string title { get; set; }
    }
}
