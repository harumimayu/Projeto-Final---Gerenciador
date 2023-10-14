public interface IConsultaAlunos
{
	List<Aluno> ConsultarAlunosPorCurso(Curso curso);
	List<Aluno> ConsultarAlunosPorIdade(int idade);
	List<Aluno> ConsultarAlunosAtivos();
}

public class ConsultaAlunos : IConsultaAlunos
{
	private List<Aluno> alunos; 
	public ConsultaAlunos(List<Aluno> listaAlunos)
	{
		alunos = listaAlunos;
	}

	public List<Aluno> ConsultarAlunosPorCurso(Curso curso)
	{
		return alunos.FindAll(aluno => aluno.Cursos.Contains(curso));
	}

	public List<Aluno> ConsultarAlunosPorIdade(int idade)
	{
		return alunos.FindAll(aluno => aluno.Idade == idade);
	}

	public List<Aluno> ConsultarAlunosAtivos()
	{
		return alunos.FindAll(aluno => aluno.Status);
	}
}

