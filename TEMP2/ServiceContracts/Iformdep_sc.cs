using project1.Models;

namespace project1.ServiceContracts
{
    public interface Iformdep_sc
    {
        Task<string> process(Formdep_Grp2 req2, Formdep_Grp3 req3);
    }
}
