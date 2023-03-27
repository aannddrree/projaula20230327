namespace projaula20230327
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Steps { get; set; }

        public string play()
        {
            return "Eba! estou jogando..";
        }

        public void run()
        {
            this.Steps = this.Steps + 2;
        }

        public string talk()
        {
            return "Uau! Eu adoro falar!";
        }

        public void walk()
        {
            this.Steps++;
        }

        public override string ToString()
        {
            return "Id: " + this.Id +
                "\nNome: " + this.Name +
                "\nEmail: " + this.Email +
                "\nPassos: " + this.Steps;
        }
    }
}
