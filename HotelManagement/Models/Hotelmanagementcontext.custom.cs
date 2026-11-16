using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models;

// File riêng (partial) để khi scaffold lại DB không bị mất cấu hình
public partial class HotelManagementContext
{
    public const string DefaultConnectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;";
}
