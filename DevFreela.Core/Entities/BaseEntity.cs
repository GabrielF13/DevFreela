namespace DevFreela.Core.Entities
{
    public class BaseEntity
    {
        protected BaseEntity()
        { }

        public int id { get; private set; }
    }
}