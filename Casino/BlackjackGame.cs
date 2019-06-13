using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Blackjack
{ 
    public class BlackjackGame : Game, IWalkAway
    {
        public BlackjackDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new BlackjackDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            foreach (Player player in Players)
            {
                bool valid = false;
                int bet = 0;
                while (!valid)
                {
                    Console.WriteLine("Place your bet!");
                    valid = int.TryParse(Console.ReadLine(), out bet);
                    if (!valid)
                    {
                        Console.WriteLine("Please enter a whole number using digits only.");
                    }
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out!");
                }
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return; //exits out of the method and returns to the while loop in the main program, restarting the play method.
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = BlackjackRules.CheckForBlackjack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player] * 1.5);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = BlackjackRules.CheckForBlackjack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone Loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your Cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackjackRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose you bet of {1}.  Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Would you like to continue?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand);
            Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.isBusted && ! Dealer.Stay)
            {
                Console.WriteLine("Dealer is Hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand);
                Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
            }

            foreach (Player player in Players)
            {
                bool? playerWon = BlackjackRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one Wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += Bets[player] * 2;
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Would you like to play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    player.isActivelyPlaying = true;
                    return;
                }
                else
                {
                    player.isActivelyPlaying = false;
                    return;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Blackjack Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
