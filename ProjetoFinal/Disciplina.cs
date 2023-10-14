public class Disciplina
{
	public string Titulo { get; set; }
	public int CargaHoraria { get; set; }
	public string Ementa { get; set; }
	public List<Professor> Professores { get; set; }
	public List<Curso> Cursos { get; set; }

	public Disciplina()
	{
		Professores = new List<Professor>();
		Cursos = new List<Curso>();
	}

	/// <summary>
	/// Associa um professor a esta disciplina, estabelecendo uma relação bidirecional entre ambos.
	/// </summary>
	/// <param name="professor">O professor a ser associado a esta disciplina.</param>

	public void AtribuirProfessor(Professor professor)
	{
		if (!Professores.Contains(professor))
		{
			Professores.Add(professor);
			professor.AdicionarDisciplina(this);
		}
	}
	/// <summary>
	/// Obtém o nome do primeiro professor associado a esta disciplina, se houver algum.
	/// </summary>
	/// <returns>O nome do professor ou "Nenhum Professor" se não houver professores associados.</returns>
	public string ObterNomeDoProfessor()
	{
		if (Professores.Count > 0)
		{
			return Professores[0].Nome;
		}
		return "Nenhum Professor";
	}
}