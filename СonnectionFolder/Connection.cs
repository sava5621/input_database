using System.ComponentModel.DataAnnotations;


namespace input_database.СonnectionFolder
{
    class Connection
    {
        [Key]
        public int id { get; set; }
        public int id_stage { get; set; }
        public int id_insecticides { get; set; }
    }
}
