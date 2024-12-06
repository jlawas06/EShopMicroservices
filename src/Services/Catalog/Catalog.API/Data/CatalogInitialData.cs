using Marten.Schema;

namespace Catalog.API.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync(cancellation))
            return;


        session.Store(GetPreconfigedProducts());
        await session.SaveChangesAsync(cancellation);
    }

    private static IEnumerable<Product> GetPreconfigedProducts()
    {
        return
        [
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Professional Gaming Laptop",
                Category = ["Electronics", "Computers", "Gaming"],
                Description = "High-performance gaming laptop with RTX 4080, 32GB RAM, and 1TB SSD",
                ImageFile = "gaming-laptop.jpg",
                Price = 2499.99m
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Ergonomic Office Chair",
                Category = ["Furniture", "Office"],
                Description = "Adjustable office chair with lumbar support and breathable mesh",
                ImageFile = "office-chair.jpg",
                Price = 299.99m
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Smart Fitness Watch",
                Category = ["Electronics", "Wearables", "Fitness"],
                Description = "Advanced fitness tracker with heart rate monitoring and GPS",
                ImageFile = "fitness-watch.jpg",
                Price = 199.99m
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Wireless Noise-Canceling Headphones",
                Category = ["Electronics", "Audio"],
                Description = "Premium wireless headphones with active noise cancellation",
                ImageFile = "headphones.jpg",
                Price = 349.99m
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Professional DSLR Camera",
                Category = ["Electronics", "Photography"],
                Description = "24.2MP full-frame digital camera with 4K video capability",
                ImageFile = "dslr-camera.jpg",
                Price = 1899.99m
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Standing Desk",
                Category = ["Furniture", "Office"],
                Description = "Electric height-adjustable desk with memory settings",
                ImageFile = "standing-desk.jpg",
                Price = 599.99m
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Mechanical Gaming Keyboard",
                Category = ["Electronics", "Gaming", "Computer Accessories"],
                Description = "RGB mechanical keyboard with custom switches",
                ImageFile = "gaming-keyboard.jpg",
                Price = 149.99m
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "4K Ultra HD Monitor",
                Category = ["Electronics", "Computer Accessories"],
                Description = "32-inch 4K monitor with HDR support",
                ImageFile = "4k-monitor.jpg",
                Price = 699.99m
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Wireless Gaming Mouse",
                Category = ["Electronics", "Gaming", "Computer Accessories"],
                Description = "High-precision wireless gaming mouse with programmable buttons",
                ImageFile = "gaming-mouse.jpg",
                Price = 79.99m
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Streaming Microphone Kit",
                Category = ["Electronics", "Audio", "Streaming"],
                Description = "Professional USB microphone with shock mount and pop filter",
                ImageFile = "streaming-mic.jpg",
                Price = 199.99m
            }
        ];
    }
}
