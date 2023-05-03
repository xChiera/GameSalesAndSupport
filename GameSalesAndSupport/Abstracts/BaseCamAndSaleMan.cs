using GameSalesAndSupport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Abstracts
{
    public abstract class BaseCamAndSaleMan:ISaleService,ICampainService
    {
         public void SellTheGame(Player player,Game game)
        {
            if (game.hasPlayerThisGame)
            {
                Console.WriteLine("You already have this game,please select a game which you don't have for buying");
            }
            if (player.balance >= game.priceWithCampain)
            {
                player.balance = player.balance - game.priceWithCampain;
                Console.WriteLine("The purchase of the game "+game.name+" was successful, have fun");
                Console.WriteLine("Your current balance is now " + player.balance + " TL");
            }
            else
            {
                Console.WriteLine("You dont have enough balance for buying the game " + game.name);
            }
        }

        //The ApplyTheCampain function update the price of game
        public void ApplyTheCampain(Player player, Game game, float PriceUpdate)
        {
            game.priceWithCampain = game.baseGamePrice * PriceUpdate / 100;
        }

        public void IsThereAnyCampain(Player player, Game game, float PriceUpdate)
        {
            //if player have a campain at the game price, function update price of the game
            if (game.hasCampain)
            {
                ApplyTheCampain(player, game, PriceUpdate);
                Console.WriteLine("The game " + game.name + " currently has a campaign, the price of the game is "
                    + game.priceWithCampain + " TL instead of " + game.baseGamePrice + " TL for a short time.");
            }
            // if player DON'T have a campain at the game price, function DON'T update price of the game
            else
            {
                ApplyTheCampain(player, game, 100);
                Console.WriteLine("Unfortunately, you do not have a campaign in the game called "
                    + game.name + ", the current price of the game is " + game.priceWithCampain + " TL");
            }

        }

    }
}
