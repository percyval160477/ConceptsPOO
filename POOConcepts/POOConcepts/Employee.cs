namespace POOConcepts
{
    public abstract class Employee
    {
        //atributos. snipees (ctor, prop)
        //propiedades
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        //metodo abstracto
        public abstract decimal GetValueToPay();

        //Sobreescribir el ToString:override
        public override string ToString()
        {
            //interpolacion de string
            return $"{Id} - {Firstname} {Lastname}, " +
                $"Birth: {BirthDate}, Hiring: {HiringDate}, " +
                $"IsActive: {IsActive}";
        }

    }
}
