using coIT.BewirbDich.Winforms.Domain;

namespace coIT.BewirbDich.Winforms.Infrastructure;

public interface IRepository
{
    InsuranceCertificate? Find(Guid id);
    List<InsuranceCertificate> List();
    void Add(InsuranceCertificate certificate);
    void Save();
}