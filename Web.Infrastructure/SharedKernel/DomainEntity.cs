namespace Web.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        //
        // True if domain entity has an identity
        //
        public T Id { get; set; }
        //Check thuoc tinh Id
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
