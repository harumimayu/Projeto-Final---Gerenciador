public class Aluno
{
	public string Nome { get; set; }
	public int Idade { get; set; }
	public string Matricula { get; set; }
	public string Turno { get; set; }

	// Status para verificar o status do aluno (ativo/inativo) na instituição.
	public bool Status { get; set; }

	/// <summary>
	/// Obtém a lista de cursos em que o aluno está matriculado.
	/// </summary>
	public List<Curso> Cursos { get; set; }

	public Aluno()
	{
		Cursos = new List<Curso>();
	}

	/// <summary>
	/// Matricula o aluno em um curso e associa o aluno ao curso.
	/// </summary>
	/// <param name="curso">O curso em que o aluno será matriculado.</param>
	public void MatricularEmCurso(Curso curso)
	{
		if (!Cursos.Contains(curso))
		{
			Cursos.Add(curso);
			curso.AdicionarAluno(this);
		}
	}

	/// <summary>
	/// Define o status do aluno como ativo ou inativo.
	/// </summary>
	/// <param name="ativo">Indica se o aluno está ativo (true) ou inativo (false).</param>
	public void DefinirStatus(bool ativo)
	{
		Status = ativo;
	}

}
