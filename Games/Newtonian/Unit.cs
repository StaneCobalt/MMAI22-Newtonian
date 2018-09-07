// A unit in the game. May be a manager, intern, or physicist.

// DO NOT MODIFY THIS FILE
// Never try to directly create an instance of this class, or modify its member variables.
// Instead, you should only be reading its variables and calling its functions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add additional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Newtonian
{
    /// <summary>
    /// A unit in the game. May be a manager, intern, or physicist.
    /// </summary>
    public class Unit : Newtonian.GameObject
    {
        #region Properties
        /// <summary>
        /// Whether this Unit has performed its action this turn.
        /// </summary>
        public bool Acted { get; protected set; }

        /// <summary>
        /// The amount of blueium carried by this unit.
        /// </summary>
        public int Blueium { get; protected set; }

        /// <summary>
        /// The amount of blueium ore carried by this unit.
        /// </summary>
        public int BlueiumOre { get; protected set; }

        /// <summary>
        /// If a ship is on this Tile, how much health it has remaining.
        /// </summary>
        public int Health { get; protected set; }

        /// <summary>
        /// The Job this Unit does.
        /// </summary>
        public Newtonian.Job Job { get; protected set; }

        /// <summary>
        /// How many more times this Unit may move this turn.
        /// </summary>
        public int Moves { get; protected set; }

        /// <summary>
        /// The Player that owns and can control this Unit.
        /// </summary>
        public Newtonian.Player Owner { get; protected set; }

        /// <summary>
        /// The amount of redium carried by this unit.
        /// </summary>
        public int Redium { get; protected set; }

        /// <summary>
        /// The amount of redium ore carried by this unit.
        /// </summary>
        public int RediumOre { get; protected set; }

        /// <summary>
        /// Duration of stun immunity.
        /// </summary>
        public int StunImmune { get; protected set; }

        /// <summary>
        /// Duration the unit is stunned.
        /// </summary>
        public int StunTime { get; protected set; }

        /// <summary>
        /// The Tile this Unit is on.
        /// </summary>
        public Newtonian.Tile Tile { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add additional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of Unit. Used during game initialization, do not call directly.
        /// </summary>
        protected Unit() : base()
        {
        }

        /// <summary>
        /// Makes the unit do something to a machine on its tile. Interns sabotage, physicists run, and managers protect.
        /// </summary>
        /// <param name="tile">The tile the unit acts on.</param>
        /// <returns>True if successfully acted, false otherwise.</returns>
        public bool Act(Newtonian.Tile tile)
        {
            return this.RunOnServer<bool>("act", new Dictionary<string, object> {
                {"tile", tile}
            });
        }

        /// <summary>
        /// Attacks a unit on a ajacent tile.
        /// </summary>
        /// <param name="tile">The Tile to attack.</param>
        /// <returns>True if successfully attacked, false otherwise.</returns>
        public bool Attack(Newtonian.Tile tile)
        {
            return this.RunOnServer<bool>("attack", new Dictionary<string, object> {
                {"tile", tile}
            });
        }

        /// <summary>
        /// Drops material at the units feat
        /// </summary>
        /// <param name="amount">The amount of materials to dropped. Amounts &lt;= 0 will drop all the materials on the Unit.</param>
        /// <param name="material">The material the unit will drop.</param>
        /// <returns>True if successfully deposited, false otherwise.</returns>
        public bool Drop(int amount, string material)
        {
            return this.RunOnServer<bool>("drop", new Dictionary<string, object> {
                {"amount", amount},
                {"material", material}
            });
        }

        /// <summary>
        /// Moves this Unit from its current Tile to an adjacent Tile.
        /// </summary>
        /// <param name="tile">The Tile this Unit should move to.</param>
        /// <returns>True if it moved, false otherwise.</returns>
        public bool Move(Newtonian.Tile tile)
        {
            return this.RunOnServer<bool>("move", new Dictionary<string, object> {
                {"tile", tile}
            });
        }

        /// <summary>
        /// Picks up material at the units feat
        /// </summary>
        /// <param name="amount">The amount of materials to pick up. Amounts &lt;= 0 will pick up all the materials on the Unit.</param>
        /// <param name="material">The material the unit will pick up.</param>
        /// <returns>True if successfully deposited, false otherwise.</returns>
        public bool Pickup(int amount, string material)
        {
            return this.RunOnServer<bool>("pickup", new Dictionary<string, object> {
                {"amount", amount},
                {"material", material}
            });
        }



        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add additional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}