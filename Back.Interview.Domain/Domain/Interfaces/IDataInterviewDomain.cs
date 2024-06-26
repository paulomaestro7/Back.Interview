
using Back.Interview.Infrastructure;

namespace Back.Interview.Domain.Interfaces;

public interface IDataInterviewDomain
{
    Task<List<DataInterviewDto>> GetDataAsync();
}
