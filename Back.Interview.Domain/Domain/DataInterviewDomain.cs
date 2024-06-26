using Back.Interview.Domain.Interfaces;
using Back.Interview.Infrastructure;
using Back.Interview.Repository;

namespace Back.Interview.Domain;

public class DataInterviewDomain : IDataInterviewDomain
{

    private readonly IDataInterviewRepository _dataInterviewRepository;

    public DataInterviewDomain(IDataInterviewRepository dataInterviewRepository)
    {
        this._dataInterviewRepository = dataInterviewRepository;
    }
    public async Task<List<DataInterviewDto>> GetDataAsync()
    {
        var result = await _dataInterviewRepository.GetDataInterview();

        //TODO: automapper

        var listResult = new List<DataInterviewDto>();
        result.ForEach((DataInterview x)=> {
            listResult.Add(new DataInterviewDto(){
                Nome = x.Nome,
                Sobrenome = x.Sobrenome
            });
        });

        return listResult;
    }
}
