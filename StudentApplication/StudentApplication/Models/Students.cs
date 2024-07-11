namespace StudentApplication.Models
{
    public class Students
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string email {  get; set; }
        public string phone { get; set; }
        public string Address {  get; set; }
        public DateOnly admission_date { get; set; }
        public double fees { get; set; }

        public bool status {  get; set; }

        public Students()
        {
            
        }
        public Students(int id, string name, string email, string phone, string address,DateOnly admission_date, double fees, bool status)
        {
            Id = id;
            Name = name;
            this.email = email;
            this.phone = phone;
            Address = address;
            this.admission_date = admission_date;
            this.fees = fees;
            this.status = status;
        }
    }
}
