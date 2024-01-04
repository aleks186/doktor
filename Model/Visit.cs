using System.ComponentModel.DataAnnotations.Schema;

namespace doctor.Model
{
    public class Visit
    {
        public int Id { get; set; }

        public DateTime Date{ get; set; }


        public string Description { get; set; }


        public int PacientId { get; set; }
        public int DoctorId { get; set; }



    }
}
