using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercer.SSE.LogFileTool;

namespace ChainOfResponsibility
{
    public class GameFramework
    {
        private static void Main(string[] args)
        {
            Log.Initialize();
            new GameFramework().Run();
            Console.ReadKey();
            Log.Close();
        }

        private void Run()
        {
            var simpleWeapon = new Weapon();
            simpleWeapon.Shoot += WeaponShoot;

            var player = new Player {Weapon = simpleWeapon};
            FireWeaponHandler = WeaponHandlerController.Create(player.PowerLevel);
            player.FireWeapon();

            // Upgrade player
            player.PowerLevel++;
            FireWeaponHandler = WeaponHandlerController.Create(player.PowerLevel);
            player.FireWeapon();

            // Upgrade player again
            player.PowerLevel++;
            FireWeaponHandler = WeaponHandlerController.Create(player.PowerLevel);
            player.FireWeapon();

            // Downgrade player to simple level
            player.PowerLevel = 1;
            FireWeaponHandler = WeaponHandlerController.Create(player.PowerLevel);
            player.FireWeapon();

            // Upgrade player to unsupported level
            player.PowerLevel = 5;
            FireWeaponHandler = WeaponHandlerController.Create(player.PowerLevel);
            player.FireWeapon();
        }

        IWeaponHandler FireWeaponHandler { get; set; }

        void WeaponShoot(object sender, ShootWeaponEventArgs e)
        {
            FireWeaponHandler.HandleRequest(e);
        }
    }

    public static class WeaponHandlerController
    {
        public static IWeaponHandler Create(int powerLevel)
        {
            if (powerLevel > 3) return new FireSecretWeaponHandler();

            if (powerLevel > 2)
                return new FireSimpleWeaponHandler(
                    new FireAdvancedWeaponHandler(new FireSecretWeaponHandler()));
            if (powerLevel > 1)
                return new FireSimpleWeaponHandler(new FireAdvancedWeaponHandler(null));

            if (powerLevel > 0) return new FireSimpleWeaponHandler(null);

            throw new Exception("ERROR: Invalid power level.");
        }
    }

    public interface IWeaponHandler
    {
        IWeaponHandler Successor { get; set; }

        void HandleRequest(ShootWeaponEventArgs e);
    }

    public abstract class FireWeaponHandlerBase : IWeaponHandler
    {
        public IWeaponHandler Successor { get; set; }

        protected FireWeaponHandlerBase(IWeaponHandler successor)
        {
            Successor = successor;
        }

        public abstract void HandleRequest(ShootWeaponEventArgs e);
    }

    public class FireSimpleWeaponHandler : FireWeaponHandlerBase
    {
        public FireSimpleWeaponHandler(IWeaponHandler successor) : base(successor) { }

        public override void HandleRequest(ShootWeaponEventArgs e)
        {
            if ((e.Player.PowerLevel < 2) || (Successor == null))
                Console.WriteLine("Firing SIMPLE weapon.");
            else Successor.HandleRequest(e);
        }
    }

    public class FireAdvancedWeaponHandler : FireWeaponHandlerBase
    {
        public FireAdvancedWeaponHandler(IWeaponHandler successor) : base(successor) { }

        public override void HandleRequest(ShootWeaponEventArgs e)
        {
            if ((e.Player.PowerLevel < 3) || (Successor == null))
                Console.WriteLine("Firing ADVANCED weapon.");
            else Successor.HandleRequest(e);
        }
    }

    public class FireSecretWeaponHandler : FireWeaponHandlerBase
    {
        public FireSecretWeaponHandler(IWeaponHandler successor=null) : base(successor) { }

        public override void HandleRequest(ShootWeaponEventArgs e)
        {
            if (e.Player.PowerLevel < 4)
                Console.WriteLine("Firing SECRET weapon.");
            else
                Console.WriteLine("UH-OH!  This power level is unsupported!!");
        }
    }

    public class Player
    {
        public int PowerLevel { get; set; }

        public Weapon Weapon { get; set; }

        public Player()
        {
            PowerLevel = 1;
        }

        public void FireWeapon()
        {
            Weapon.Fire(this);
        }
    }

    public class Weapon
    {
        public event EventHandler<ShootWeaponEventArgs> Shoot;

        public void Fire(Player p)
        {
            OnShoot(new ShootWeaponEventArgs(p));
        }

        private void OnShoot(ShootWeaponEventArgs e)
        {
            if (Shoot != null) Shoot(this, e);
        }
    }

    public class ShootWeaponEventArgs
    {
        public Player Player { get; set; }

        public ShootWeaponEventArgs(Player player)
        {
            Player = player;
        }
    }
}