using System;
using System.Threading.Tasks;

namespace tehtava2
{
    public interface IRepository
    {
    Task<Player> GetPlayer(Guid id);
    Task<Player[]> GetAllPlayers();
    Task<Player> CreatePlayer(Player player);
    Task<Player> ModifyPlayer(Guid id, ModifiedPlayer player);
    Task<Player> DeletePlayer(Guid id);

    Task<Item> CreateItem(Guid playerId, Item item);
    Task<Item> GetItem(Guid playerId, Guid itemId);
    Task<Item[]> GetAllItems(Guid playerId);
    Task<Item> ModifyItem(Guid playerId, Guid itemid, ModifiedItem item);
    Task<Item> DeleteItem(Guid playerId, Guid itemid);
    }
}