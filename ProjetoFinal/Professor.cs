public class Professor
{
	public string Nome { get; set; }
	public int Idade { get; set; }
	public List<Disciplina> Disciplinas { get; set; }

	public Professor()
	{
		Disciplinas = new List<Disciplina>();
	}
	/// <summary>
	/// Adiciona uma disciplina à lista de disciplinas ministradas pelo professor.
	/// </summary>
	/// <param name="disciplina">A disciplina a ser adicionada ao professor.</param>
	public void AdicionarDisciplina(Disciplina disciplina)
	{
		if (!Disciplinas.Contains(disciplina))
		{
			Disciplinas.Add(disciplina);
			disciplina.AtribuirProfessor(this);
		}
	}
}