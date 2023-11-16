using exemplos_dotnet.Models;

Pessoa p1 = new Pessoa(nome: "Bruno", sobrenome: "Silva");

Pessoa p2 = new Pessoa(nome: "Juliana", sobrenome: "Cardeal");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();




//Pessoa p1 = new Pessoa();
//p1.Nome = "Bruno";
//p1.Idade = 20;
//p1.Apresentar();


