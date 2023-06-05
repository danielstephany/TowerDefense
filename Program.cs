using System;
using TowerDefense;
class Program {
    static void Main (string[] args)
    {
            Map map = new Map(8, 5);
        try {
            MapPath mapPath = new MapPath(new []{
                new MapLocation(0, 2, map),
                new MapLocation(1, 2, map),
                new MapLocation(2, 2, map),
                new MapLocation(3, 2, map),
                new MapLocation(4, 2, map),
                new MapLocation(5, 2, map),
                new MapLocation(6, 2, map),
                new MapLocation(7, 2, map)
            });

            Invader[] invaders = new []{
                new Invader(mapPath),
                new SheildedInvader(mapPath),
                new StrongInvader(mapPath),
                new FastInvader(mapPath)
            };

            Tower[] towers = new[]{
                new Tower(new MapLocation(3, 2, map)),
                new Tower(new MapLocation(5, 3, map)),
                new SniperTower(new MapLocation(5, 1, map)),
                new Tower(new MapLocation(7, 1, map)),
                new PowerfullTower(new MapLocation(7, 3, map))
            };

            Tower tower = new Tower(new MapLocation(3, 2, map)); 

            Level level1 = new Level(invaders, towers);

            bool playerWon = level1.Play();

            Console.WriteLine($"player as {(playerWon ? "won" : "lost")}");
 
        } catch(OutOfBounsException ex)
        {
            Console.WriteLine(ex.Message);
        } catch(TowerDefenseException ex)
        {
            Console.WriteLine($"Unhandled TowerDefenseException Exception: {ex}");
        } catch(Exception ex)
        {
            Console.WriteLine("Unhandled Exception: " + ex);
        }

    }
}