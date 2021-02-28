using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Match_Form.Models;
namespace Match_Form.Controllers
{
    public sealed class Singleton
    {

        private static List<Player> playerList = new List<Player>();
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton()
        {
           
        }
       
        public void addPlayer(Models.Player player)
        {
            playerList.Add(player);
        }

        public List<Player> getPlayer(){
            return playerList;
        }
    }
}
