namespace Back.Interview.Repository;

public interface IDataInterviewRepository
{
    Task<List<DataInterview>> GetDataInterview();
}
