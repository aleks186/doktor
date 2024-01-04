using System.ComponentModel.DataAnnotations.Schema;

namespace doctor.Model
{
    public class Pacient
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Mname { get; set; }

        public int Age { get; set; }

        public DateTime Birthday { get; set; }

        public int DoctorId { get; set; }
        

    }
}
