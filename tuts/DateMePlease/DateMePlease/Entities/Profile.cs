namespace DateMePlease.Entities
{
    public class Profile
    {
        public int Id { get; set; }

        public string LookingFor { get; set; }
        public string Introduction { get; set; }
        public string Pitch { get; set; }

        public Member Member { get; set; }

        public Demographics Demographics { get; set; }
    }
}