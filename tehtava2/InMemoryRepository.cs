using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace tehtava2
{
    public class InMemoryRepository : IRepository {
        private List<Player> players = new List<Player>();

        public async Task<Player> CreatePlayer(Player player)
        {
            await Task.CompletedTask;
            players.Add(player);
            return player;
        }

        public async Task<Player> DeletePlayer(Guid id)
        {
            await Task.CompletedTask;
            Player found = GetPlayerById(id);

            if (found != null)
            {
                players.Remove(found);
                return found;
            }
            else
            {
                return null;
            }
        }

        public async Task<Player> GetPlayer(Guid id)
        {
            await Task.CompletedTask;
            return GetPlayerById(id);
        }

        public async Task<Player[]> GetAllPlayers()
        {
            await Task.CompletedTask;
            return players.ToArray();
        }

        public async Task<Player> ModifyPlayer(Guid id, ModifiedPlayer player)
        {
            await Task.CompletedTask;
            Player found = GetPlayerById(id);
            if (found != null)
            {
                found.Score = player.Score;
            }
            return found;
        }

        private Player GetPlayerById(Guid id)
        {
            foreach (Player player in players)
            {
                if (player.Id == id)
                {
                    return player;
                }
            }
            return null;
        }

        private Item GetItemById(Guid playerid, Guid itemid) 
        {
            Player player = GetPlayerById(playerid);

            foreach (Item item in player.items)
            {
                if (item.Id == itemid)
                {
                    return item;
                }
            }
            return null;

        }

        public async Task<Item> CreateItem(Guid playerid, Item item)
        {
            await Task.CompletedTask;
            Player player = GetPlayerById(playerid);
            player.items.Add(item);
            return item;
        }

        public async Task<Item> GetItem(Guid playerid, Guid itemid)
        {
            await Task.CompletedTask;
            Item item = GetItemById(playerid, itemid);
            return item;

        }

        public async Task<Item[]> GetAllItems(Guid playerid)
        {
            await Task.CompletedTask;
            Player player = GetPlayerById(playerid);
            return player.items.ToArray();
        }

        public async Task<Item> ModifyItem(Guid playerid, Guid itemid, ModifiedItem item)
        {
            await Task.CompletedTask;
            Item found = GetItemById(playerid, itemid);
            if (found != null)
            {
                found.Level = item.Level;
            }
            return found;
        }

        public async Task<Item> DeleteItem(Guid playerid, Guid itemid)
        {
            await Task.CompletedTask;
            Item found = GetItemById(playerid, itemid);
            Player player = GetPlayerById(playerid);
            if (found != null)
            {
                player.items.Remove(found);
                return found;
            }
            else
            {
                return null;
            }
        }
    }
}