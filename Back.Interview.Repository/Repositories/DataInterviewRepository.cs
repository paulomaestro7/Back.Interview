
namespace Back.Interview.Repository;

public class DataInterviewRepository : IDataInterviewRepository
{
    public async Task<List<DataInterview>> GetDataInterview()
    {
        return await Task.FromResult<List<DataInterview>>(new List<DataInterview>(){
            new DataInterview(){
                Nome = "Nome 1",
                Sobrenome = "Nome sobrenome 1"
            },
            new DataInterview(){
                Nome = "Nome 2",
                Sobrenome = "Nome sobrenome 2"
            }
        });
    }
}
