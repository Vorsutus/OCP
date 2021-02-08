namespace OCPLibrary
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        //Every IApplicantModel will now have an AccountProcesser
        IAccounts AccountProcesser { get; set; }
    }
}