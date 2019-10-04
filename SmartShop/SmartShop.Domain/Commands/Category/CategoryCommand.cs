using SmartShop.Domain.Core.Commands;

namespace SmartShop.Domain.Commands.Category
{
    public abstract class CategoryCommand : Command
    {
        public int Id { get; set; }
        public string Description { get; protected set; }
    }
}
