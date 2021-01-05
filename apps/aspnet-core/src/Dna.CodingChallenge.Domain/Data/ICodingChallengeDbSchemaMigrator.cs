using System.Threading.Tasks;

namespace Dna.CodingChallenge.Data
{
    public interface ICodingChallengeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
