namespace WebApplication3.Models
{
    public interface IMembers
    {
         List<Members> GetAllMember();
        Members GetMembers(int id);
        List<Members> GetAllMembersbyname(string name);
        List<Members> GetAllMemberbyaddress(string address);

        

       
        Members Add(Members employee);
        Members Update(int id, Members MembersChanges);
        Members Delete(int Id);
    }
}
