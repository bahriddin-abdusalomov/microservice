namespace Hospital.Domain.Entities.Equipments;

public class Inventory : BaseEntity
{
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public string Image { get ; set; }
}