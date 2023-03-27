// See https://aka.ms/new-console-template for more information
using projaula20230327;

Console.WriteLine("Contratos de Aplicação");

Person p1 = new Person()
{
    Id = 1,
    Name = "João Silva",
    Age = 30,
    Email = "joao@teste.com",
    Steps  = 0
};

Console.WriteLine(p1);


IPerson person = new Person();
string msg = person.talk();

Console.WriteLine(msg);
