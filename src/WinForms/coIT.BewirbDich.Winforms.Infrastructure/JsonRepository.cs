using System.Text;
using System.Text.Json;
using coIT.BewirbDich.Winforms.Domain;

namespace coIT.BewirbDich.Winforms.Infrastructure;

public class JsonRepository : IRepository
{
    private readonly string _file;
    private List<InsuranceCertificate> _certificates;

    public JsonRepository(string file)
    {
        _file = file;
        Load();
    }

    private void Load()
    {
        if (!File.Exists(_file))
        {
            var empty = Enumerable.Empty<InsuranceCertificate>();
            File.WriteAllText(_file, JsonSerializer.Serialize(empty), Encoding.UTF8);
        }

        var json = File.ReadAllText(_file, Encoding.UTF8);
        _certificates = JsonSerializer.Deserialize<List<InsuranceCertificate>>(json) ?? new List<InsuranceCertificate>();
    }

    public InsuranceCertificate? Find(Guid id)
    {
        return _certificates.SingleOrDefault(dok => dok.Id == id);
    }

    public List<InsuranceCertificate> List()
    {
        return _certificates;
    }

    public void Add(InsuranceCertificate certificate)
    {
        _certificates.Add(certificate);
    }

    public void Save()
    {
        var json = JsonSerializer.Serialize(_certificates);
        File.WriteAllText(_file, json, new UTF8Encoding());
    }
}