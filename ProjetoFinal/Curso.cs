public class Curso
{
	public string Nome { get; set; }
	public string Codigo { get; set; }
	public List<Aluno> Alunos { get; set; }
	public List<Disciplina> Disciplinas { get; set; }

	public Curso()
	{
		Alunos = new List<Aluno>();
		Disciplinas = new List<Disciplina>();
	}

	/// <summary>
	/// Adiciona um aluno à lista de alunos matriculados no curso.
	/// </summary>
	/// <param name="aluno">O aluno a ser adicionado ao curso.</param>

	public void AdicionarAluno(Aluno aluno)
	{
		if (!Alunos.Contains(aluno))
		{
			Alunos.Add(aluno);
			aluno.MatricularEmCurso(this);
		}
	}

	/// <summary>
	/// Adiciona uma disciplina à lista de disciplinas incluídas no curso.
	/// </summary>
	/// <param name="disciplina">A disciplina a ser adicionada ao curso.</param>

	public void AdicionarDisciplina(Disciplina disciplina)
	{
		if (!Disciplinas.Contains(disciplina))
		{
			Disciplinas.Add(disciplina);
			disciplina.Cursos.Add(this);
		}
	}

	/// <summary>
	/// Calcula a carga horária total do curso, somando as cargas horárias de todas as disciplinas do curso.
	/// </summary>
	/// <returns>A carga horária total do curso em horas.</returns>
	public int ObterCargaHorariaTotal()
	{
		int cargaHorariaTotal = 0;
		foreach (var disciplina in Disciplinas)
		{
			cargaHorariaTotal += disciplina.CargaHoraria;
		}
		return cargaHorariaTotal;
	}

	/// <summary>
	/// Obtém o nome do professor do primeiro registro de disciplina do curso, se houver alguma disciplina.
	/// </summary>
	/// <returns>O nome do professor ou "Nenhum Professor" se não houver disciplinas ou vários professores diferentes.</returns>
	public string ObterNomeDoProfessor()
	{
		if (Disciplinas.Count > 0)
		{
			var primeiroProfessor = Disciplinas[0].ObterNomeDoProfessor();
			if (Disciplinas.All(disciplina => disciplina.ObterNomeDoProfessor() == primeiroProfessor))
			{
				return primeiroProfessor;
			}
			else
			{
				return "Vários Professores";
			}
		}
		return "Nenhum Professor";
	}
}