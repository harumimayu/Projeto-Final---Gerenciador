public class Program
{
	static void Main(string[] args)
	{
		//  lista de alunos
		List<Aluno> listaAlunos = new List<Aluno>();

		// lista de cursos
		List<Curso> listaCursos = new List<Curso>();

		//  lista de disciplinas
		List<Disciplina> listaDisciplinas = new List<Disciplina>();

		//  lista de professores
		List<Professor> listaProfessores = new List<Professor>();

		// Criando três alunos
		Aluno aluno1 = new Aluno { Nome = "João", Idade = 20, Matricula = "123456" };
		aluno1.DefinirStatus(false);

		Aluno aluno2 = new Aluno { Nome = "Maria", Idade = 22, Matricula = "654321" };
		aluno2.DefinirStatus(true);

		Aluno aluno3 = new Aluno { Nome = "Pedro", Idade = 19, Matricula = "789012" };
		aluno3.DefinirStatus(true);

		// Adicione os alunos à lista
		listaAlunos.Add(aluno1);
		listaAlunos.Add(aluno2);
		listaAlunos.Add(aluno3);

		//Adicionando Turno dos alunos
		aluno1.Turno = "Manhã";
		aluno2.Turno = "Tarde";
		aluno3.Turno = "Noite";

		// Criando duas disciplinas
		Disciplina disciplina1 = new Disciplina
		{
			Titulo = "Introdução à Programação",
			CargaHoraria = 60,
			Ementa = "Esta disciplina introduz os conceitos básicos de programação, incluindo variáveis, tipos de dados, operadores, instruções de controle e funções."
		};

		Disciplina disciplina2 = new Disciplina
		{
			Titulo = "Banco de Dados",
			CargaHoraria = 45,
			Ementa = "Esta disciplina aborda conceitos de bancos de dados relacionais e SQL."
		};

		// Adicionando as disciplinas à lista
		listaDisciplinas.Add(disciplina1);
		listaDisciplinas.Add(disciplina2);

		// Criando três professores
		Professor professor1 = new Professor { Nome = "Maria", Idade = 30 };
		professor1.AdicionarDisciplina(disciplina1);

		Professor professor2 = new Professor { Nome = "Carlos", Idade = 35 };
		professor2.AdicionarDisciplina(disciplina2);

		Professor professor3 = new Professor { Nome = "Ana", Idade = 28 };
		professor3.AdicionarDisciplina(disciplina1);

		// Adicionando os professores à lista
		listaProfessores.Add(professor1);
		listaProfessores.Add(professor2);
		listaProfessores.Add(professor3);

		// Criando três cursos
		Curso curso1 = new Curso { Nome = "Ciência da Computação", Codigo = "CC" };
		curso1.AdicionarAluno(aluno1);
		curso1.AdicionarAluno(aluno2);
		curso1.AdicionarDisciplina(disciplina1);
		curso1.AdicionarDisciplina(disciplina2);

		Curso curso2 = new Curso { Nome = "Engenharia Elétrica", Codigo = "EE" };
		curso2.AdicionarAluno(aluno2);
		curso2.AdicionarAluno(aluno3);
		curso2.AdicionarDisciplina(disciplina1);

		Curso curso3 = new Curso { Nome = "Matemática Aplicada", Codigo = "MA" };
		curso3.AdicionarAluno(aluno1);
		curso3.AdicionarAluno(aluno3);
		curso3.AdicionarDisciplina(disciplina2);

		// Adicionando os cursos à lista
		listaCursos.Add(curso1);
		listaCursos.Add(curso2);
		listaCursos.Add(curso3);

		// Criando uma instância da classe ConsultaAlunos
		IConsultaAlunos consultaAlunos = new ConsultaAlunos(listaAlunos);

		foreach (var aluno in listaAlunos)
		{
			Console.WriteLine("Aluno: " + aluno.Nome);
			Console.WriteLine("Idade: " + aluno.Idade);
			Console.WriteLine("Matrícula: " + aluno.Matricula);
			Console.WriteLine("Turno: " + aluno.Turno);
			if (aluno.Status)
			{
				Console.WriteLine("Status: Ativo");

				// Exibindo as informações dos cursos em que o aluno está matriculado
				Console.WriteLine("Cursos em que o aluno está matriculado:");
				foreach (var curso in aluno.Cursos)
				{
					Console.WriteLine("  - Curso: " + curso.Nome);
					Console.WriteLine("    Código: " + curso.Codigo);
					Console.WriteLine("    Carga Horária: " + curso.ObterCargaHorariaTotal() + " horas");
					Console.WriteLine("    Professor que está lecionando o curso: " + curso.ObterNomeDoProfessor());
					Console.WriteLine("    Disciplinas do curso:");
					foreach (var disciplina in curso.Disciplinas)
					{
						Console.WriteLine("      - Disciplina: " + disciplina.Titulo);
						Console.WriteLine("        Ementa: " + disciplina.Ementa);
					}
				}
			}
			else
			{
				Console.WriteLine("Status: Inativo");
				Console.WriteLine("O aluno não está matriculado na instituição.");
			}

			Console.WriteLine();
		}
	}
}

